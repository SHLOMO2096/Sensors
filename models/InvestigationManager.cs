using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sensors.models
{
    internal class InvestigationManager
    {
        public InvestigationManager(IranianAgent agent)
        {
            IranianAgent Agent = new IranianAgent("Achmed");
            
        }
        public void start() 
        { 
            
            List<string> Weaknesses = new List<string>();

            for (int i = 0; i>2; i++)
            {
                int index = random.Next(possibleSensorTypes.Count);
                Weaknesses.Add(possibleSensorTypes[index]);
            }
            Agent.Sensitivity = Weaknesses;
            Agent.ActiveSensors = new List<Sensor>();

        }
    }
}
