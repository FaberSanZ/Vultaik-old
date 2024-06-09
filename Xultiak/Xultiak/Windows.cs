using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Silk.NET.GLFW;
using Silk.NET.Windowing;

namespace engine.Games
{
    public unsafe class Windows : IDisposable
    {

        private readonly WindowHandle* windows_handle;
        private Glfw native_api;

        public Windows(string title, int width, int height)
        {
            Title = title;
            Width = width;
            Height = height;

            native_api = Glfw.GetApi();

            native_api.Init();
            native_api.WindowHint(WindowHintClientApi.ClientApi, ClientApi.NoApi);
            native_api.WindowHint(WindowHintBool.Visible, false);


            windows_handle = native_api.CreateWindow(width, height, title, null, null);

            native_api.MakeContextCurrent(windows_handle);


            GlfwNativeWindow glfw_native = new(native_api, windows_handle);
            Hwnd = glfw_native.Win32!.Value.Hwnd;
        }



        public int Width { get; set; }
        public int Height { get; set; }
        public string Title { get; set; }

        public IntPtr Hwnd { get; set; }

        public void RenderLoop(Action render)
        {
            while (!native_api.WindowShouldClose(windows_handle))
            {

                render();
                native_api.PollEvents();
            }
        }


        public void Show()
        {
            native_api.ShowWindow(windows_handle);

        }



        public void Dispose()
        {

        }
    }
}