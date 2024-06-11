using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vortice.Direct3D11;
using Vortice.DXGI;
using Vortice.Mathematics;

namespace Xultaik.Graphics
{
    public class CommandList : IDisposable
    {
        internal ID3D11DeviceContext device_context;

        public CommandList(Device device)
        {
            device_context = device.native_device_context;
        }


        public void Clear(SwapChainPresenter swapChain, float red, float green, float blue, float alpha)
        {
            device_context.ClearRenderTargetView(swapChain.render_target_view, new Color4(red, green, blue, alpha));
            device_context.OMSetRenderTargets(swapChain.render_target_view, null);




        }



        public void SetViewport(float width, float height)
        {
            device_context.RSSetViewport(new(width, height));
        }


        public void SetScissorRect(float width, float height)
        {
            device_context.RSSetScissorRect(800, 600);
        }

        public void Dispose()
        {
            device_context.ClearState();
            device_context.Flush();
            device_context.Dispose();
        }
    }
}
