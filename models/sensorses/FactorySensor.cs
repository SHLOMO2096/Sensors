using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sensors.models.sensorses
{
    public class FactorySensor
    {
        public static Sensor CreatSensor(string sensorName)
        {
            switch (sensorName)
            {
                case "Audio":
                    return new AudioSensor(sensorName);
                case "Thermal":
                    return new ThermalSensor(sensorName);
                case "Pulse":
                    return new PulseSensor(sensorName);
                case "Motion":
                    return new MotionSensor(sensorName);
                case "Magnetic":
                    return new MagneticSensor(sensorName);
                case "Signal":
                    return new SignalSensor(sensorName);
                case "Light":
                    return new LightSensor(sensorName);
                default:
                    throw new ArgumentException("Invalid sensor name");
            }
        }
    }
}
