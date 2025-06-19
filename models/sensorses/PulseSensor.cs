using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sensors.models.sensorses
{
    public class PulseSensor : Sensor
    {
        public PulseSensor(string name) : base(name)
        {
        }
        public override async Task Activate()
        {
            ActivCount++;
            if (ActivCount >= 3)
            {
                IsBroken = true;
                //Console.WriteLine($"the {Name}Sensor is broken try again in 30 seconds");
                await Task.Delay(30000);
                IsBroken = false;
                ActivCount = 0;
            }
            else
            {
            }
        }
    }
}
