using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public abstract class GeometricShape
    {
        public abstract decimal CalculateArea();
        public abstract decimal CalculatePerimeter();
        public abstract string GetName(int language, int quantity);
    }
}
