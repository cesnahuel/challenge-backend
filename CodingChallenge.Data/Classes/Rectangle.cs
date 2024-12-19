using CodingChallenge.Data.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Rectangle : GeometricShape
    {
        private readonly decimal _height;
        private readonly decimal _width;
        public Rectangle(decimal height, decimal width)
        {
            _height = height;
            _width = width;
        }

        public override decimal CalculateArea()
        {
            return _height * _width;
        }
        public override decimal CalculatePerimeter()
        {
            return (_width + _height) * 2;
        }
        public override string GetName(int language, int quantity)
        {
            return ShapeTranslationsHelper.Translate(nameof(Rectangle), language, quantity);
        }
    }
}
