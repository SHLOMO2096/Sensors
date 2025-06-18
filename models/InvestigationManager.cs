using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sensors.models
{
    public class InvestigationManager
    {
        private IranianAgent agent;

        public InvestigationManager(IranianAgent singleAgent)
        {
            agent = singleAgent;
        }

        public void AttachSensorAndScan(Sensor sensor)
        {
            agent.AttachSensor(sensor);

            int result = agent.CheckSensor(sensor);

            Console.WriteLine($"Sensor '{sensor.Name}' attached to Agent '{agent.Name}'");
            Console.WriteLine($"Result: {result}/2");

            if (agent.IsExposed())
            {
                Console.WriteLine($" Agent '{agent.Name}' is EXPOSED!");
            }
        }

        public void ShowAttachedSensors()
        {
            Console.WriteLine($"Agent '{agent.Name}' has the following attached sensors:");
            foreach (var sensor in agent.ActiveSensors)
            {
                Console.WriteLine($" - {sensor.Name}");
            }
        }
        public IranianAgent GetAgent()
        {
            return agent;
        }
    }
}
