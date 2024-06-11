using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vortice;
using Vortice.D3DCompiler;
using Vortice.Direct3D;
using Vortice.Direct3D11;
using Vortice.Direct3D11.Debug;
using Vortice.DXGI;
using Vortice.DXGI.Debug;
using Vortice.Mathematics;
using static Vortice.Direct3D11.D3D11;
using static Vortice.DXGI.DXGI;


namespace Xultaik.Graphics
{
    public class SwapChainPresenter : IDisposable
    {
        internal IDXGISwapChain1 swapchain;
        internal ID3D11Texture2D back_buffer_texture;

        internal ID3D11RenderTargetView render_target_view;


        public SwapChainPresenter(Device device, Windows windows)
        {
            Device = device;
            IntPtr hwnd = windows.Hwnd;



            SwapChainDescription1 swapChain_description = new()
            {
                Width = windows.Width,
                Height = windows.Height,
                Format = Format.B8G8R8A8_UNorm,
                BufferCount = 2,
                BufferUsage = Usage.RenderTargetOutput,
                SampleDescription = SampleDescription.Default,
                Scaling = Scaling.Stretch,
                SwapEffect = SwapEffect.FlipDiscard,
                AlphaMode = AlphaMode.Ignore
            };

            SwapChainFullscreenDescription fullscreen_description = new()
            {
                Windowed = true
            };

            swapchain = device.Adapter.factory.CreateSwapChainForHwnd(device.native_device, hwnd, swapChain_description, fullscreen_description);
            device.Adapter.factory.MakeWindowAssociation(hwnd, WindowAssociationFlags.IgnoreAltEnter);


            back_buffer_texture = swapchain.GetBuffer<ID3D11Texture2D>(0);
            render_target_view = device.native_device.CreateRenderTargetView(back_buffer_texture);

        }

        public Device Device { get; }


        public void Present()
        {
            swapchain.Present(1, PresentFlags.None);
        }



        public void Dispose()
        {
            render_target_view.Dispose();
            back_buffer_texture.Dispose();
            swapchain.Dispose();    
        }
    }
}
