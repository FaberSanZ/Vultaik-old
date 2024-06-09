using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xultiak;

namespace InitializingDirect3D11
{
    public class Sample : Application, IDisposable
    {

        public override void Update(TimerTick time)
        {
            Console.WriteLine(time.TotalTime.ToString());
        }


        public void Dispose()
        {
        }
    }
}
