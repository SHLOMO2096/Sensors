using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sensors.models.sensorses
{
    public class SignalSensor : Sensor
    {
        public SignalSensor(string name) : base(name)
        {
        }
        public override void Activate()
        {
            //Activate = true;
        }
    }
}
