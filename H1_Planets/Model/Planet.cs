using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Planets.Model
{
    /// <summary>
    /// Class that 
    /// </summary>
    internal class Planet
    {
        // Task 1
        private string _name;
        private float _mass;
        private int _diameter;
        private short _density;
        private float _gravity;
        private float _rotationPeriodHours;
        private float _lengthDayHours;
        private float _sunDistance;
        private float _orbitTime;
        private float _orbitVelocity;
        private short _meanTemp;
        private byte _totalMoons;
        private bool _hasRings;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public float Mass
        {
            get { return _mass; }
            set { _mass = value; }
        }

        public int Diameter
        {
            get { return _diameter; }
            set { _diameter = value; }
        }

        public short Density
        {
            get { return _density; }
            set { _density = value; }
        }

        public float Gravity
        {
            get { return _gravity; }
            set { _gravity = value; }
        }
        public float RotationPeriod
        {
            get { return _rotationPeriodHours; }
            set { _rotationPeriodHours = value; }
        }
        public float DayLength
        {
            get { return _lengthDayHours; }
            set { _lengthDayHours = value; }
        }
        public float SunDistance
        {
            get { return _sunDistance; }
            set { _sunDistance = value; }
        }
        public float OrbitTime
        {
            get { return _orbitTime; }
            set { _orbitTime = value; }
        }
        public float OrbitVelocity
        {
            get { return _orbitVelocity; }
            set { _orbitVelocity = value; }
        }
        public short MeanTemp
        {
            get { return _meanTemp; }
            set { _meanTemp = value; }
        }
        public byte TotalMoons
        {
            get { return _totalMoons; }
            set { _totalMoons = value; }
        }
        public bool HasRings
        {
            get { return _hasRings; }
            set { _hasRings = value; }
        }
    }
}
