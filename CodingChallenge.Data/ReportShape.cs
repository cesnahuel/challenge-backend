using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data
{
    public static class ReportShape
    {
        public static string Print(List<GeometricShape> shapes, int language)
        {
            if(!shapes.Any())
            {
                switch(language)
                {
                    case Language.Spanish:
                        return "<h1>Lista vacía de formas!</h1>";
                    case Language.English:
                        return "<h1>Empty list of shapes!</h1>";
                    case Language.Portuguese:
                        return "<h1>Lista vazia de formas!</h1>";
                }
            }

            StringBuilder sb = new StringBuilder();

            switch (language)
            {
                case Language.Spanish:
                    sb.Append("<h1>Reporte de Formas</h1>");
                    break;
                case Language.English:
                    sb.Append("<h1>Shapes report</h1>");
                    break;
                case Language.Portuguese:
                    sb.Append("<h1>Relatório de Formas</h1>");
                    break;
            }

            var groupsShapes = shapes
                                .GroupBy(s => s.GetType().Name)
                                .Select(s => new {
                                    ShapeName = s.First().GetName(language, s.Count()),
                                    ShapeCount = s.Count(),
                                    ShapeArea = s.Sum(u => u.CalculateArea()),
                                    ShapePerimeter = s.Sum(u=>u.CalculatePerimeter())
                                });
            
            foreach (var group in groupsShapes) 
            {
                sb.Append($"{group.ShapeCount} {group.ShapeName} | {ShapeTranslationsHelper.TanslateComplement("Area", language)} {group.ShapeArea:#.##} | {ShapeTranslationsHelper.TanslateComplement("Perimeter", language)} {group.ShapePerimeter:#.##} <br/>");
            }

            //Footer
            int totalShape = shapes.Count();
            decimal totalArea = shapes.Sum(s => s.CalculateArea());
            decimal totalPerimeter = shapes.Sum(s => s.CalculatePerimeter());

            sb.Append("TOTAL:<br/>");
            sb.Append($"{totalShape} {ShapeTranslationsHelper.TanslateComplement("Shapes", language)} ");
            sb.Append($"{ShapeTranslationsHelper.TanslateComplement("Perimeter", language)} {totalPerimeter.ToString("#.##")} ");
            sb.Append($"{ShapeTranslationsHelper.TanslateComplement("Area", language)} {totalArea.ToString("#.##")}");

            return sb.ToString();
        }
    }
}
