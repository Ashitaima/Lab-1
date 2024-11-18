using System;
using System.Collections.Generic;
using System.Linq;

namespace TrafficLightSimulation
{
    public class TrafficLight
    {
        private static readonly string[] Signals = { "Red", "Green", "Yellow" };
        private int currentSignalIndex;

        public TrafficLight(string initialSignal)
        {
            currentSignalIndex = Array.IndexOf(Signals, initialSignal);
        }

        public void Update()
        {
            currentSignalIndex = (currentSignalIndex + 1) % Signals.Length;
        }

        public string GetCurrentSignal()
        {
            return Signals[currentSignalIndex];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] initialSignals = Console.ReadLine().Split(' ');

            List<TrafficLight> trafficLights = initialSignals
                .Select(signal => new TrafficLight(signal))
                .ToList();

            int updates = int.Parse(Console.ReadLine());

            for (int i = 0; i < updates; i++)
            {
                foreach (var light in trafficLights)
                {
                    light.Update();
                }

                Console.WriteLine(string.Join(" ", trafficLights.Select(light => light.GetCurrentSignal())));
            }
        }
    }
}
