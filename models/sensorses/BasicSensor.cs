using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sensors.models
{
    internal class BasicSensor : Sensor
    {
        public BasicSensor(string name) : base(name)
        {
        }
        public override void IsActivate()
        {
            Activate = true;
        }
    }
}
