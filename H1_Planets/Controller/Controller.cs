using H1_Planets.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace H1_Planets.Controller
{
    internal class Controller
    {
        View.View view = new View.View();
        Planet planet = new Planet();

        /// <summary>
        /// Task 2
        /// A list containing all the planets that i had to create, using the properties from the planets class
        /// </summary>
        List<Planet> planets = new List<Planet>()
        {
            new Planet()
            {
                Name = "Mercury",
                Mass = 0.330f,
                Diameter = 4879,
                Density = 5427,
                Gravity = 3.7f,
                RotationPeriod = 1407.6f,
                DayLength = 4222.6f,
                SunDistance = 57.9f,
                OrbitTime = 88.0f,
                OrbitVelocity = 47.4f,
                MeanTemp = 167,
                TotalMoons = 0,
                HasRings = false
            },
            new Planet()
            {
                Name = "Earth",
                Mass = 5.97f,
                Diameter = 12756,
                Density = 5514,
                Gravity = 9.8f,
                RotationPeriod = 23.9f,
                DayLength = 24f,
                SunDistance = 149.6f,
                OrbitTime = 365.2f,
                OrbitVelocity = 29.8f,
                MeanTemp = 15,
                TotalMoons = 1,
                HasRings = false
            },
            new Planet()
            {
                Name = "Mars",
                Mass = 0.642f,
                Diameter = 6792,
                Density = 3933,
                Gravity = 3.7f,
                RotationPeriod = 24.6f,
                DayLength = 24.7f,
                SunDistance = 227.9f,
                OrbitTime = 687f,
                OrbitVelocity = 24.1f,
                MeanTemp = -65,
                TotalMoons = 2,
                HasRings = false
            },
            new Planet()
            {
                Name = "Jupiter",
                Mass = 1898f,
                Diameter = 142984,
                Density = 1326,
                Gravity = 23.1f,
                RotationPeriod = 9.9f,
                DayLength = 9.9f,
                SunDistance = 778.6f,
                OrbitTime = 4331f,
                OrbitVelocity = 13.1f,
                MeanTemp = -110,
                TotalMoons = 67,
                HasRings = true
            },
            new Planet()
            {
                Name = "Saturn",
                Mass = 568f,
                Diameter = 120536,
                Density = 687,
                Gravity = 9.0f,
                RotationPeriod = 10.7f,
                DayLength = 10.7f,
                SunDistance = 1433.5f,
                OrbitTime = 10747f,
                OrbitVelocity = 9.7f,
                MeanTemp = -140,
                TotalMoons = 67,
                HasRings = true
            },
            new Planet()
            {
                Name = "UrAnus",
                Mass = 86.8f,
                Diameter = 51118,
                Density = 1271,
                Gravity = 8.7f,
                RotationPeriod = -17.2f,
                DayLength = -17.2f,
                SunDistance = 2872.5f,
                OrbitTime = 30589f,
                OrbitVelocity = 6.8f,
                MeanTemp = -195,
                TotalMoons = 27,
                HasRings = true
            },
            new Planet()
            {
                Name = "Neptune",
                Mass = 102f,
                Diameter = 49528,
                Density = 1638,
                Gravity = 11.0f,
                RotationPeriod = 16.1f,
                DayLength = 16.1f,
                SunDistance = 4495.1f,
                OrbitTime = 59.8f,
                OrbitVelocity = 5.4f,
                MeanTemp = -200,
                TotalMoons = 14,
                HasRings = true
            },
            new Planet()
            {
                Name = "Pluto",
                Mass = 0.0146f,
                Diameter = 2370,
                Density = 2095,
                Gravity = 0.7f,
                RotationPeriod = -153.3f,
                DayLength = 153.3f,
                SunDistance = 5906.4f,
                OrbitTime = 90.56f,
                OrbitVelocity = 4.7f,
                MeanTemp = -225,
                TotalMoons = 5,
                HasRings = false
            }
        };

        /// <summary>
        /// MainController calls the task from the assignment, using the appropriately named methods.
        /// </summary>
        public void MainController()
        {
            TaskThree();
            TaskFour();
            TaskSix();
            TaskSeven();
            TaskEight();
            TaskNine();
            TaskTen();
            TaskEleven();
        }

        /// <summary>
        /// This method calls the view, with each planet from the list.
        /// Then the view outputs all the planet information to the console.
        /// </summary>
        void OutputAll()
        {
            foreach (Planet planetInfo in planets)
            {
                view.OutputPlanetInfo(planetInfo);
            }
        }

        /// <summary>
        /// Task 3 requires that all the planets get output to the console
        /// </summary>
        void TaskThree()
        {
            OutputAll();

            view.Message("This is task 1/2/3 ^ \nPress enter to see next task");
        }
        /// <summary>
        /// Task 4 adds Venus to the list and in the 2nd position, due to its distance in order, from the sun.
        /// Task 5 requires me to output the list, to show Venus in the correct position.
        /// </summary>
        void TaskFour()
        {
            planets.Insert(1, planet);
            planets[1] = new Planet();

            planets[1].Name = "Venus";
            planets[1].Mass = 4.87f;
            planets[1].Diameter = 12104;
            planets[1].Density = 5243;
            planets[1].Gravity = 8.9f;
            planets[1].RotationPeriod = -5832.5f;
            planets[1].DayLength = 2802f;
            planets[1].SunDistance = 108.2f;
            planets[1].OrbitTime = 224.7f;
            planets[1].OrbitVelocity = 35.0f;
            planets[1].MeanTemp = 364;
            planets[1].TotalMoons = 0;
            planets[1].HasRings = false;

            OutputAll();

            view.Message("This is task 4/5 ^ \nPress enter to see next task");
        }

        /// <summary>
        /// Task 6 Finds pluto and deletes it from the list. Due to it not being a planet.
        /// </summary>
        void TaskSix()
        {
            for (int i = 0; i < planets.Count; i++)
            {
                if (planets[i].Name == "Pluto")
                {
                    planets.Remove(planets[i]);
                }
            }

            OutputAll();

            view.Message("This is task 6 ^ \nPress enter to see next task");
        }

        /// <summary>
        /// Task 7 adds pluto again. Assignment cant make up its mind.
        /// </summary>
        void TaskSeven()
        {
            planets.Add(planet);
            Planet pluto = planets.Last();

            pluto.Name = "Pluto";
            pluto.Mass = 0.0146f;
            pluto.Diameter = 2370;
            pluto.Density = 2095;
            pluto.Gravity = 0.7f;
            pluto.RotationPeriod = -153.3f;
            pluto.DayLength = 153.3f;
            pluto.SunDistance = 5906.4f;
            pluto.OrbitTime = 90.56f;
            pluto.OrbitVelocity = 4.7f;
            pluto.MeanTemp = -225;
            pluto.TotalMoons = 5;
            pluto.HasRings = false;

            OutputAll();

            view.Message("This is task 7 ^ \nPress enter to see next task");
        }

        /// <summary>
        /// Outputs the length of the list
        /// </summary>
        void TaskEight()
        {
            view.Count(planets.Count());
            view.Message("This is task 8 ^ \nPress enter to see next task");
        }

        /// <summary>
        /// Puts the planets with a less than 0 mean temperature in a new list and outputs that list to the console
        /// </summary>
        void TaskNine()
        {
            List <Planet> lowMeanTemp = new List<Planet>();

            foreach (Planet planet in planets)
            {
                if(planet.MeanTemp < 0)
                {
                    lowMeanTemp.Add(planet);
                    view.OutputPlanetInfo(planet);
                }
            }

            view.Message("This is task 9 ^ \nPress enter to see next task");
        }

        /// <summary>
        /// Create a new list which contains all planets with that has a diameter between 10k and 50k.
        /// Outputs the result to the console, through the view.
        /// </summary>
        void TaskTen()
        {
            List<Planet> diameter = new List<Planet>();

            foreach (Planet planet in planets)
            {
                if (planet.Diameter > 10000 && planet.Diameter < 50000)
                {
                    diameter.Add(planet);
                    view.OutputPlanetInfo(planet);
                }
            }

            view.Message("This is task 10 ^ \nPress enter to see next task");
        }

        /// <summary>
        /// Delete all the list elements
        /// </summary>
        void TaskEleven()
        {
            planets.Clear();

            OutputAll();
            view.Message("This is task 11 ^ \nPress enter to see next task");
        }
    }
}
