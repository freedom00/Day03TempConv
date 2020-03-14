namespace Day03TempConv
{
    internal class FahrenheitConverter : IConverter
    {
        public double? ToConvert(double degree, Scale scale)
        {
            double? result;
            switch (scale)
            {
                case Scale.Celcius:
                    result = (5.0 / 9) * (degree - 32);
                    break;

                case Scale.Fahrenheit:
                    result = degree;
                    break;

                case Scale.Kelvin:
                    result = (5.0 / 9) * (degree - 32) + 273.15;
                    break;

                default:
                    result = null;
                    break;
            }
            return result;
        }
    }
}