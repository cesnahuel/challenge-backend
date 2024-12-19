using CodingChallenge.Data.Helper;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Trapezium : GeometricShape
    {
        private readonly decimal _minorBase;
        private readonly decimal _majorBase;
        private readonly decimal _height;
        private readonly decimal _sideOne;
        private readonly decimal _sideTwo;
        public Trapezium(decimal minorBase, decimal majorBase, decimal height, decimal sideOne, decimal sideTwo)
        {
            _minorBase = minorBase;
            _majorBase = majorBase;
            _height = height;
            _sideOne = sideOne;
            _sideTwo = sideTwo;
        }

        public override decimal CalculateArea()
        {
            return ((_minorBase + _majorBase)*_height)/2;
        }
        public override decimal CalculatePerimeter()
        {
            return _minorBase *_majorBase + _sideOne + _sideTwo;
        }
        public override string GetName(int language, int quantity)
        {
            return ShapeTranslationsHelper.Translate(nameof(Trapezium), language, quantity);
        }
    }
}
