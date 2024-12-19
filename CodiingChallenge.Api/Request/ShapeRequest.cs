using CodiingChallenge.Api.Request.Enum;

namespace CodiingChallenge.Api.Request
{
    public class ShapeRequest
    {
        public ShapeType ShapeType { get; set; }
        public decimal? SideOne { get; set; }
        public decimal? SideTwo { get; set; }
        public decimal? Height { get; set; }
        public decimal? Width { get; set; }
        public decimal? MinorBase { get; set; }
        public decimal? MajorBase { get; set; }
    }
}
