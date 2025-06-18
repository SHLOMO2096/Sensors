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
        //public bool Activate { get; set; }

        public Sensor(string name)
        {
            Name = name;
            

        }
        public abstract void Activate();
        
           
        
    }
}
