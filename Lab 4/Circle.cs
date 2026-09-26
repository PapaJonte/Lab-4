using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    internal class Circle
    {
         int _radius;  // Store the radius value for the Circle objects

        // Constructor that receives a radius when a Circle object is created
        public Circle(int radius)
        {
            _radius = radius;
        }
        // The method that calculates the area A = r^2 * pi,
        // and then returns the value
        public double GetArea() 
        {
            double area = _radius * _radius * Math.PI;
            return area;
        }
        // The method that calculates the circumference C = r * 2pi,
        // and then returns the value
        public double GetCircumference()
        {
            double circumference = _radius * 2 * Math.PI;
            return circumference;
        }
        // The method that calculates the volume V = (4/3) * pi * r^3,
        // and then returns the value
        public double GetVolume()
        {
            double volume = (4.0 / 3.0) * Math.PI * _radius * _radius * _radius;
            return volume;
        }
    }
}
