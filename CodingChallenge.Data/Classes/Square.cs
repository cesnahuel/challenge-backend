using CodingChallenge.Data.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Square : GeometricShape
    {
        private readonly decimal _side;

        public Square(decimal side)
        {
            _side = side;
        }

        public override decimal CalculateArea()
        {
            return _side * _side;
        }
        public override decimal CalculatePerimeter()
        {
            return _side * 4;
        }
        public override string GetName(int language, int quantity)
        {
            return ShapeTranslationsHelper.Translate(nameof(Square), language, quantity);
        }
    }
}
