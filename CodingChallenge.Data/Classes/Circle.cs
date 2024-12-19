using CodingChallenge.Data.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Circle : GeometricShape
    {
        private readonly decimal _side;

        public Circle(decimal side)
        {
            _side = side;
        }

        public override decimal CalculateArea()
        {
            return (decimal)Math.PI * (_side / 2) * (_side / 2);
        }
        public override decimal CalculatePerimeter()
        {
            return (decimal)Math.PI * _side;
        }
        public override string GetName(int language, int quantity)
        {
            return ShapeTranslationsHelper.Translate(nameof(Circle), language, quantity);
        }
    }
}
