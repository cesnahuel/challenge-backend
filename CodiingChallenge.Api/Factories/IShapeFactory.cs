using CodiingChallenge.Api.Request;
using CodingChallenge.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodiingChallenge.Api.Factory
{
    public interface IShapeFactory
    {
        GeometricShape CreateShape(ShapeRequest request);
    }
}
