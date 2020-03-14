namespace Day03TempConv
{
    internal enum Scale
    { Celcius, Fahrenheit, Kelvin };

    internal interface IConverter
    {
        double? ToConvert(double degree, Scale scale);
    }
}