using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    internal class Triangle
    {
        int _length; // Store the length for our Triangle objects
        int _height; // Store the height for our Triangle objects

        // Constructor that receives the length and height when a Triangle object is created
        public Triangle(int length, int height)
        {
            _length = length;
            _height = height;
        }

        // The method that calculates the area A = (A * B) / 2,
        // and then returns the value
        public double GetArea()
        {
            double area = (_length * _height) / 2.0;
            return area;
        }
        // The method that calculates the circumfence
        public double GetCircumfence()
        {
            // First it calculates the hypotenuse; C = square root of (A^2 + B^2)
            double hypotenuse = Math.Sqrt((_length * _length) + (_height * _height));
            // Then it adds them together; Circ = A + B + C
            double circumfence = _length + _height + hypotenuse;
            return circumfence; // Finally it returns the value
        }

    }
}
