using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sensors.models
{
    public class ThermalSensor : Sensor
    {

        public ThermalSensor(string name) : base(name)
        {
        }
        public override void Activate()
        {
            //Activate = true;
        }
    }
}
