using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vortice.DXGI;
using static Vortice.Direct3D11.D3D11;
using static Vortice.DXGI.DXGI;

namespace Xultaik.Graphics
{
    public class Adapter
    {
        internal IDXGIFactory2 factory;
        internal IDXGIAdapter gpu;


        public Adapter()
        {
            //TODO: device score (Prefer earlier entries in list)
            factory = CreateDXGIFactory1<IDXGIFactory2>();
            factory.EnumAdapters(0, out IDXGIAdapter adapter);
            gpu = adapter;
        }


        public string DeviceName => gpu.Description.Description;




    }
}
