using CodingChallenge.Data.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Helper
{
    public static class ShapeTranslationsHelper
    {

        private static readonly Dictionary<int, Dictionary<string, string>> Translations = new Dictionary<int, Dictionary<string, string>>
        {
            {
                Language.Spanish, new Dictionary<string, string>
                {
                    { nameof(Square), "Cuadrado" },
                    { nameof(EquilateralTriangle), "Triángulo" },
                    { nameof(Circle), "Círculo" },
                    { nameof(Trapezium), "Trapecio" },
                    { nameof(Rectangle), "Rectángulo" }                    
                }
            },
            {
                Language.English, new Dictionary<string, string>
                {
                    { nameof(Square), "Square" },
                    { nameof(EquilateralTriangle), "Triangle" },
                    { nameof(Circle), "Circle" },
                    { nameof(Trapezium), "Trapezium" },
                    { nameof(Rectangle), "Rectangle" }
                }
            },
            {
                Language.Portuguese, new Dictionary<string, string>
                {
                    { nameof(Square), "Quadrado" },
                    { nameof(EquilateralTriangle), "Triângulo" },
                    { nameof(Circle), "Círculo" },
                    { nameof(Trapezium), "Trapézio" },
                    { nameof(Rectangle), "Retângulo" }
                }
            }
        };

        public static string Translate(string shapeName, int language, int quantity)
        {
            if (!Translations.ContainsKey(language) || !Translations[language].ContainsKey(shapeName))
                return string.Empty;

            string name = Translations[language][shapeName];
            if(string.IsNullOrEmpty(name))
                return string.Empty;

            return quantity > 1 ? $"{name}s" : name;
        }

        public static string TanslateComplement(string word, int language)
        {
            switch (word.ToLower())
            {
                case "shapes":
                    return language == Language.Spanish || language == Language.Portuguese ? "Formas" : word;
                case "perimeter":
                    return language == Language.Spanish || language == Language.Portuguese ? "Perímetro" : word;
                case "area":
                    return language == Language.Spanish || language == Language.Portuguese ? "Área" : word;
                default:
                    return string.Empty;
            }

        }
    }

}
