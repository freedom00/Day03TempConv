namespace Day03TempConv
{
    internal class KelvinConverter : IConverter
    {
        public double? ToConvert(double degree, Scale scale)
        {
            double? result;
            switch (scale)
            {
                case Scale.Celcius:
                    result = degree - 273.15;
                    break;

                case Scale.Fahrenheit:
                    result = (9.0 / 5) * (degree - 273.15) + 32;
                    break;

                case Scale.Kelvin:
                    result = degree;
                    break;

                default:
                    result = null;
                    break;
            }
            return result;
        }
    }
}