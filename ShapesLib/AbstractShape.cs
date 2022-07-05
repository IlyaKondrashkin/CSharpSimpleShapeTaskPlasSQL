
namespace ShapesLib
{
    public abstract class AbstractShape : Shape
    {
        private double? _area;

        protected abstract double CalculateArea();

        public double Area
        {
            get
            {
                if (!_area.HasValue)
                {
                    _area = CalculateArea();
                }
                return _area.Value;
            }
        }
    }
}
