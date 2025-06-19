using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sensors.models
{
    public abstract class Sensor
    {
        public string Name { get; set; }
        public bool IsBroken { get; set; } = false;
        protected int ActivCount { get; set; }
        public Sensor(string name)
        {
            Name = name;
            ActivCount = 0;
        }

        public abstract Task Activate();
    }
}
