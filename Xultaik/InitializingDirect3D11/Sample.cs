using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xultaik;
using Xultaik.Graphics;


namespace InitializingDirect3D11
{
    public class Sample : Application, IDisposable
    {


        public override void Initialize()
        {
            Adapter = new Adapter();
            Device = new Device(Adapter);
            SwapChain = new SwapChainPresenter(Device, Window);
            CommandList = new CommandList(Device);

            Console.WriteLine(Adapter.DeviceName);
            Console.WriteLine(Device.Level);
        }


        public Adapter Adapter { get; set; }
        public Device Device { get; set; }
        public SwapChainPresenter SwapChain { get; set; }
        public CommandList CommandList { get; set; }

        public override void Update(TimerTick time)
        {
            Console.WriteLine(time.TotalTime);
        }


        public override void Draw(TimerTick time)
        {
            CommandList.Clear(SwapChain, 0, 0.2f, 0.4f, 1);
            CommandList.SetViewport(Window.Width, Window.Height);
            CommandList.SetScissorRect(Window.Width, Window.Height);


            SwapChain.Present();
        }

        public void Dispose()
        {
            CommandList.Dispose();
            SwapChain.Dispose();
            Device.Dispose();
        }
    }
}
