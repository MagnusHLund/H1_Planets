using H1_Planets.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Planets.View
{
    internal class View
    {
        /// <summary>
        /// Shows all information about each planet in the list
        /// The planet parameter has its value from the list
        /// </summary>
        /// <param name="planet"></param>
        public void OutputPlanetInfo(Planet planet)
        {
            // Task 3, 5, 6
            Console.WriteLine($"Name: {planet.Name}\n" +
                $"Mass: {planet.Mass} (1024kg)\n" +
                $"Density: {planet.Density} kg/m3\n" +
                $"Gravity: {planet.Gravity} \n" +
                $"Diameter: {planet.Diameter}\n" +
                $"Rotation Period: {planet.RotationPeriod} (hours)\n" +
                $"Length of Day: {planet.DayLength} (hours)\n" +
                $"Distance from Sun: {planet.SunDistance} (106 km)\n" +
                $"Orbital Period: {planet.OrbitTime} (days)\n" +
                $"Orbital Velocity: {planet.OrbitVelocity} (km/s)\n" +
                $"Mean Temperature: {planet.MeanTemp} (C)\n" +
                $"Number of Moons: {planet.TotalMoons}\n" +
                $"Has rings? {planet.HasRings}\n\n");
        }

        public void Message(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ReadLine();
            Console.ResetColor();
        }

        public void Count(int count)
        {
            Console.WriteLine(count);
        }
    }
}
