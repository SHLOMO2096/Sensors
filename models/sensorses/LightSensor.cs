using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sensors.models.sensorses
{
    public class LightSensor : Sensor
    {
        public LightSensor(string name) : base(name)
        {
        }
        public override void Activate()
        {
            //Activate = true;
        }
    }
}
