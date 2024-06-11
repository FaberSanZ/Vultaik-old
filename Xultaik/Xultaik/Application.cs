using Silk.NET.Windowing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xultaik
{
    public class Application
    {


        public Application()
        {

            Window = new("Xultaik", 1200, 800);

            Time = new();
            Time.Reset();
        }






        public Windows Window { get; set; }
        public TimerTick Time { get; }



        public void Run()
        {

            Initialize();
            LoadContentAsync();

            Time.Tick(); // update
            Window?.Show();
            //Window!.Resize += ExampleBase_Resize;
            Window.RenderLoop(() =>
            {
                Update(Time);
                Draw(Time);
                Time.Tick();
            });
        }


        public virtual void Initialize()
        {
        }


        public virtual Task LoadContentAsync()
        {
            return Task.CompletedTask;
        }

        public virtual void Draw(TimerTick time)
        {
        }

        public virtual void Update(TimerTick time)
        {
        }

        public virtual void Resize(int width, int height)
        {

        }

    }
}
