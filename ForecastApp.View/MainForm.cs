using ForecastApp.ForecastService;
using ForecastApp.ForecastService.Intefraces;
using ForecastApp.GeoService;
using ForecastApp.Models.Enums;

namespace ForecastApp.View
{
    public partial class MainForm : Form
    {
        private readonly IForecastService _forecastService;
        public MainForm(IForecastService forecastService)
        {         
            _forecastService = forecastService;
            InitializeComponent();
        }
        /// <summary>
        /// ���������� ������� �� ������ "������"
        /// </summary>
        private async void button1_Click(object sender, EventArgs e)
        {
            CleanTextBoxes();
            
            if (Int32.TryParse(textBox1.Text, out int result) == true)
            {
                errorTextBox.Visible = true;
                errorTextBox.Text = "������� ������ ������ �����";

                return;
            }
            string cityName = textBox1.Text;

            var forecast = await _forecastService.GetCurrentWeatherAsync(cityName);

            if(forecast.StatusCode == StatusCode.NotFound)
            {
                errorTextBox.Visible = true;
                errorTextBox.Text = "����� �� ������";

                return;
            }
            else if (forecast.StatusCode == StatusCode.Unauthorized)
            {
                errorTextBox.Visible = true;
                errorTextBox.Text = "� ����� ApiKey.txt ������� ������ Api-����";

                return;
            }

            tempTextBox.Text = forecast.Main.Temperature.ToString() + " �C";
            windSpeedTextBox.Text = forecast.Wind.Speed.ToString() + " �/�";
            descTextBox.Text = forecast.Weather[0].Description;
        }

        /// <summary>
        /// ������� ��������� ���� � ���� ����������
        /// </summary>
        public void CleanTextBoxes()
        {
            errorTextBox.Visible = false;
            tempTextBox.Text = null;
            windSpeedTextBox.Text = null;
            descTextBox.Text = null;
        }
    }
}
