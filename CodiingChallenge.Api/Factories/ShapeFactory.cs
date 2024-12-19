using CodiingChallenge.Api.Request;
using CodiingChallenge.Api.Request.Enum;
using CodingChallenge.Data.Classes;

namespace CodiingChallenge.Api.Factory
{
    /// <summary>
    /// Clase de extension para la creacion de instancias de Formas Geometricas, para desacoplar esta carga en el controlador
    /// De esta manera se puede con la instancia creada se podrá acceder a la funcionalidad de cada forma geometrica
    /// </summary>
    public class ShapeFactory : IShapeFactory
    {
        public GeometricShape CreateShape(ShapeRequest request)
        { 
            switch (request.ShapeType)
            {
                case ShapeType.Circle:
                    if (!request.SideOne.HasValue)
                        throw new ArgumentException("SideOne is required");
                    return new Circle(request.SideOne.Value);
                case ShapeType.Square:
                    if (!request.SideOne.HasValue)
                        throw new ArgumentException("SideOne is required");
                    return new Square(request.SideOne.Value);
                case ShapeType.Rectangle:
                    if (!request.Height.HasValue || !request.Width.HasValue)
                        throw new ArgumentException("Height and Width are required");
                    return new Rectangle(request.Height.Value, request.Width.Value);
                case ShapeType.Trapezium:
                    if (!request.MinorBase.HasValue || !request.MajorBase.HasValue || 
                        !request.Height.HasValue || !request.SideOne.HasValue ||
                        !request.SideTwo.HasValue)
                        throw new ArgumentException("MinorBase, MajorBase, SideOne, SideTwo and Height are required");
                    return new Trapezium(request.MinorBase.Value, request.MajorBase.Value, request.Height.Value, request.SideOne.Value, request.SideOne.Value);
                case ShapeType.EquilateralTriangle:
                    if (!request.SideOne.HasValue)
                        throw new ArgumentException("SideOne is required");
                    return new EquilateralTriangle(request.SideOne.Value);
                
                default:
                    throw new ArgumentException($"Shape type {request.ShapeType} is not supported");
            }
        }
    }
}
