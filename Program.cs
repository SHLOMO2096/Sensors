using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sensors.models;

namespace sensors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IranianAgent agent = new IranianAgent("Ali");
            InvestigationManager manager = new InvestigationManager(agent);

            List<string> availableSensors = new List<string> { "Audio", "Pulse", "Motion", "Thermal", "Basic" };

            Console.WriteLine("Welcome to the Iranian Agent Exposure Game");
            Console.WriteLine("An agent is hiding with 2 weaknesses. Try to find them!");

            while (!manager.GetAgent().IsExposed())
            {
                Console.WriteLine("\nChoose a sensor to attach:");
                for (int i = 0; i < availableSensors.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {availableSensors[i]}");
                }

                Console.Write("Enter a number (1-5): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int choice) && choice >= 1 && choice <= availableSensors.Count)
                {
                    string sensorName = availableSensors[choice - 1];
                    Sensor sensor = new BasicSensor(sensorName);

                    manager.AttachSensorAndScan(sensor);
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }

            Console.WriteLine("\n The agent has been successfully exposed!");
        }
    }
    
}
