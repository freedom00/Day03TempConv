namespace Day03TempConv
{
    internal class CelciusConverter : IConverter
    {
        public double? ToConvert(double degree, Scale scale)
        {
            double? result;
            switch (scale)
            {
                case Scale.Celcius:
                    result = degree;
                    break;

                case Scale.Fahrenheit:
                    result = (9.0 / 5) * degree + 32;
                    break;

                case Scale.Kelvin:
                    result = degree + 273.15;
                    break;

                default:
                    result = null;
                    break;
            }
            return result;
        }
    }
}