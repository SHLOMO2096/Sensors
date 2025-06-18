using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace sensors.models
{
    public class IranianAgent
    {
        public string Name { get; set; }
        public List<string> Sensitivity { get; set; }
        public List<Sensor> ActiveSensors { get; set; }
        private int matchCount = 0;

        public IranianAgent(string name)
        {
            Name = name;
            Sensitivity = new List<string>();
            ActiveSensors = new List<Sensor>();

            List<string> possibleSensorTypes = new List<string> { "Audio", "Pulse", "Motion", "Thermal", "basic", };
            Random random = new Random();
            const int LengthOf = 2;
            for (int i = 0; i < LengthOf; i++)
            {
                int index = random.Next(possibleSensorTypes.Count);
                Sensitivity.Add(possibleSensorTypes[index]);
            }
        }

        public void AttachSensor(Sensor sensor)
        {
            ActiveSensors.Add(sensor);
        }


        public int CheckSensor(Sensor Sensorname)
        {
            
            if (Sensitivity.Contains(Sensorname.Name))
            {
                Sensitivity.Remove(Sensorname.Name);
                matchCount++;
                Console.WriteLine("${matchCount}/2");
            }
            else
            {
                Console.WriteLine($"{matchCount}/2");
            }

            return matchCount;
        }
            
            
        
        public bool IsExposed()
        {
            const int requiredMatches = 2;
            return matchCount >= requiredMatches;
        }
    }
}
