using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sensors.models
{
    internal class Sensor
    {
        public string Name { get; set; }
        public bool Activate { get; set; }

        public Sensor(string name)
        {
            Name = name;
            Activate = false;
            IsActivate();

        }
        public virtual void IsActivate()
        {
            Activate = true;
        }
    }
}
