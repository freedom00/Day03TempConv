using System;
using System.Windows;

namespace Day03TempConv
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private IConverter TemperatureConverterFactory()
        {
            if (RadioButtonInputCelcius.IsChecked == true)
            {
                return new CelciusConverter();
            }
            else if (RadioButtonInputFahrenheit.IsChecked == true)
            {
                return new FahrenheitConverter();
            }
            else if (RadioButtonInputKelvin.IsChecked == true)
            {
                return new KelvinConverter();
            }
            else
            {
                return null;
            }
        }

        private double? ConvertTemperature(double degree)
        {
            IConverter converter = TemperatureConverterFactory();
            if (converter == null)
            {
                return null;
            }
            if (RadioButtonOutputCelcius.IsChecked == true)
            {
                return converter.ToConvert(degree, Scale.Celcius);
            }
            else if (RadioButtonOutputFahrenheit.IsChecked == true)
            {
                return converter.ToConvert(degree, Scale.Fahrenheit);
            }
            else if (RadioButtonOutputKelvin.IsChecked == true)
            {
                return converter.ToConvert(degree, Scale.Kelvin);
            }
            else
            {
                return null;
            }
        }

        private void DoClick()
        {
            double degree;
            if (!double.TryParse(TextBoxInput.Text, out degree))
            {
                MessageBox.Show(this, "Input must not be empty", "Input error", MessageBoxButton.OK, MessageBoxImage.Error);
                RadioButtonInputCelcius.IsChecked = false;
                return;
            }

            double? result;
            result = ConvertTemperature(degree);
            if (result == null)
            {
                return;
            }
            else
            {
                TextBoxOutput.Text = ((double)result).ToString("0.00");
            }
        }

        private void RadioButtonInputCelcius_Checked(object sender, RoutedEventArgs e)
        {
            DoClick();
        }

        private void RadioButtonInputFahrenheit_Checked(object sender, RoutedEventArgs e)
        {
            DoClick();
        }

        private void RadioButtonInputKelvin_Checked(object sender, RoutedEventArgs e)
        {
            DoClick();
        }

        private void RadioButtonOutputCelcius_Checked(object sender, RoutedEventArgs e)
        {
            DoClick();
        }

        private void RadioButtonOutputFahrenheit_Checked(object sender, RoutedEventArgs e)
        {
            DoClick();
        }

        private void RadioButtonOutputKelvin_Checked(object sender, RoutedEventArgs e)
        {
            DoClick();
        }
    }
}