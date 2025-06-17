using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sensors.models
{
    internal class IranianAgent
    {
        public string Name { get; set; }
        public List<string> Sensitivity { get; set; }
        public List<Sensor> ActiveSensors { get; set; }
        public IranianAgent(string name) 
        {
            Name = name;
            Sensitivity = new List<string>();
            ActiveSensors = new List<Sensor>();

            List<string> possibleSensorTypes = new List<string> { "Audio", "Pulse", "Motion", "Thermal", "basic", };
            Random random = new Random();
            for (int i = 0; i > 2; i++)
            {
                int index = random.Next(possibleSensorTypes.Count);
                Sensitivity.Add(possibleSensorTypes[index]);
            }
        }

        public void AttachSensor(Sensor sensor)
        {
            ActiveSensors.Add(sensor);
        }

        public IranianAgent clone()
        {
            return new IranianAgent(this.Name)
            {
                Sensitivity = new List<string>(this.Sensitivity),
                ActiveSensors = new List<Sensor>(this.ActiveSensors)
            };

        }
        public int GetActiveSensorsCount()
        {
            
        }
        public bool IsExposed()
        {

        }
    }
}
