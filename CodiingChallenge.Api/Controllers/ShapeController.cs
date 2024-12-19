using CodiingChallenge.Api.Factory;
using CodiingChallenge.Api.Request;
using Microsoft.AspNetCore.Mvc;

namespace CodiingChallenge.Api.Controllers
{
    /// <summary>
    ///  Se creo este controller para la entrada del flujo proveniente del cliente y poder disponibilizar las funciones internas de las formas geometricas, 
    ///  para no crear las instancias de las formas geometricas se optó por implementar el patron Factory
    ///  Se utiliza el protocolo http retornando el valor calculado
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class ShapeController : ControllerBase
    {
        private readonly IShapeFactory _shapeFactory;

        public ShapeController(IShapeFactory shapeFactory)
        {
            _shapeFactory = shapeFactory;
        }

        [HttpPost("calculate-area")]
        public IActionResult CalculateArea([FromBody] ShapeRequest request)
        { 
            var shape = _shapeFactory.CreateShape(request);

            var area = shape.CalculateArea();

            return Ok(area);
        }

        [HttpPost("calculate-perimeter")]
        public IActionResult CalculatePerimeter([FromBody] ShapeRequest request)
        {
            var shape = _shapeFactory.CreateShape(request);

            var perimeter = shape.CalculatePerimeter();

            return Ok(perimeter);
        }
    }
}
