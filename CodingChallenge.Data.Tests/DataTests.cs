using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                ReportShape.Print(new List<GeometricShape>(), Language.Spanish));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                ReportShape.Print(new List<GeometricShape>(), Language.English));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnPortuges()
        {
            Assert.AreEqual("<h1>Lista vazia de formas!</h1>",
                ReportShape.Print(new List<GeometricShape>(), Language.Portuguese));
        }
        
        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var square = new List<GeometricShape> { new Square(5) };

            var resumen = ReportShape.Print(square, Language.Spanish);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Área 25 | Perímetro 20 <br/>TOTAL:<br/>1 Formas Perímetro 20 Área 25", resumen);
        }
        
        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var square = new List<GeometricShape>
            {
                new Square(5),
                new Square(1),
                new Square(3)
            };

            var resumen = ReportShape.Print(square, FormaGeometrica.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 Shapes Perimeter 36 Area 35", resumen);
        }
        
        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var shapes = new List<GeometricShape>
            {
                new Square(5),
                new Circle(3),
                new EquilateralTriangle(4),
                new Square(2),
                new EquilateralTriangle(9),
                new Circle(2.75m),
                new EquilateralTriangle(4.2m)
            };

            var resumen = ReportShape.Print(shapes, FormaGeometrica.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13.01 | Perimeter 18.06 <br/>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>TOTAL:<br/>7 Shapes Perimeter 97.66 Area 91.65",
                resumen);
        }
        
        [TestCase]
        public static void TestResumenListaConMasTiposEnCastellano()
        {
            var shapes = new List<GeometricShape>
            {
                new Square(5),
                new Circle(3),
                new EquilateralTriangle(4),
                new Square(2),
                new EquilateralTriangle(9),
                new Circle(2.75m),
                new EquilateralTriangle(4.2m)
            };

            var resumen = ReportShape.Print(shapes, FormaGeometrica.Castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Área 29 | Perímetro 28 <br/>2 Círculos | Área 13.01 | Perímetro 18.06 <br/>3 Triángulos | Área 49.64 | Perímetro 51.6 <br/>TOTAL:<br/>7 Formas Perímetro 97.66 Área 91.65",
                resumen);
        }

    }
}
