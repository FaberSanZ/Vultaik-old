using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vortice.Direct3D;
using Vortice.Direct3D11;
using static Vortice.Direct3D11.D3D11;
using static Vortice.DXGI.DXGI;

namespace Xultaik.Graphics
{
    public class Device : IDisposable
    {

        internal ID3D11Device native_device;
        internal ID3D11DeviceContext native_device_context;


        public Device(Adapter adapter)
        {
            FeatureLevel[] feature_levels = new[]
{
                FeatureLevel.Level_12_2,
                FeatureLevel.Level_12_1,
                FeatureLevel.Level_12_0,
                FeatureLevel.Level_11_1,
                FeatureLevel.Level_11_0,
                FeatureLevel.Level_10_1,
                FeatureLevel.Level_10_0
            };


            D3D11CreateDevice(adapter.gpu, DriverType.Unknown, DeviceCreationFlags.BgraSupport, feature_levels, out ID3D11Device device, out FeatureLevel featureLevel, out ID3D11DeviceContext device_context);

            native_device = device.QueryInterface<ID3D11Device1>();
            native_device_context = device_context;

            Level = featureLevel;
            Adapter = adapter;
        }


        public FeatureLevel Level { get; set; }
        public Adapter Adapter { get; }

        public void Dispose()
        {
            native_device.Dispose();
        }
    }
}
