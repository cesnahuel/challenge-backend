using CodingChallenge.Data.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class EquilateralTriangle : GeometricShape
    {
        private readonly decimal _side;

        public EquilateralTriangle(decimal side)
        {
            _side = side;
        }

        public override decimal CalculateArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _side * _side;
        }
        public override decimal CalculatePerimeter()
        {
            return _side * 3;
        }
        public override string GetName(int language, int quantity)
        {
            return ShapeTranslationsHelper.Translate(nameof(EquilateralTriangle), language, quantity);
        }
    }

}
