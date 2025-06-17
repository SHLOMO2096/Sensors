using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sensors.models;

namespace sensors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasicSensor basic = new BasicSensor("basic");
            TermiSensor termi = new TermiSensor("Thermal");
            IranianAgent fachrizade = new IranianAgent("fachrizade");
            fachrizade.AttachSensor(basic);
        }
    }
}
