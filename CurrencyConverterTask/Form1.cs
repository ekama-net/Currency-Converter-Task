using Newtonsoft.Json;
using System.Net;
using Timer = System.Threading.Timer;

namespace CurrencyConverterTask
{
    public partial class mainForm : Form
    {
        CurrencyModel rub;
        Timer myTimer;

        public mainForm()
        {
            InitializeComponent();

            //при наличии других api можем создавать экземпляры и конвертировать не только из RUB
            rub = new() { FromCharCode = "RUB", FromName = "Российский рубль", Model = ParseJson("https://www.cbr-xml-daily.ru/daily_json.js") };
            dropDownTo.Items.Add($"{rub.FromCharCode} ({rub.FromName})");

            DateTime dateTime = DateTime.Now;
            //в начале каждого часа подгружает актуальную инфромацию
            myTimer = new Timer(myTimerCallback, "https://www.cbr-xml-daily.ru/daily_json.js",(60 - dateTime.Minute) * 60000, 3600000);

        }
        public void myTimerCallback(Object obj)
        {
            //не знаю со скольки, но после 20:00 курсы перестают обновлятся
            if(DateTime.Now.Hour < 20 && DateTime.Now.Hour > 10)
            {
                MessageBox.Show("Exchange rates have been updated");
                rub.Model = ParseJson(obj.ToString());
                Calculate();
            }
        }

        private void dropDownTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void numericFrom_KeyUp(object sender, KeyEventArgs e)
        {
            Calculate();
        }

        private void dropDownFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericFrom.Value = SelectValute(dropDownFrom.SelectedItem.ToString()[..3])?.Nominal ?? 1;
            Calculate();
        }

        public void Calculate()
        {
            if (numericFrom.Value > 0 && dropDownFrom.SelectedItem != null && dropDownTo.SelectedItem != null)
            {
                var result = Convert.ToDouble(numericFrom.Value) * SelectValute(dropDownFrom.SelectedItem.ToString()[..3])?.Value ?? 1;
                toValue.Text = Math.Round(result,2).ToString();
            }
            else toValue.Text = "0";
        }

        public ApiModel ParseJson(string uri)
        {
            string json;
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            request.Accept = "text / plain; charset = UTF - 8";
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    json = reader.ReadToEnd();
                }
                return JsonConvert.DeserializeObject<ApiModel>(json);
            }
            catch
            {
                return null;
            }
        }

        public ModelValute SelectValute(string shortName) => shortName switch
        {
            "RUB" => rub.Model.Valute.RUB,
            "AUD" => rub.Model.Valute.AUD,
            "AZN" => rub.Model.Valute.AZN,
            "GBP" => rub.Model.Valute.GBP,
            "AMD" => rub.Model.Valute.AMD,
            "BYN" => rub.Model.Valute.BYN,
            "BGN" => rub.Model.Valute.BGN,
            "BRL" => rub.Model.Valute.BRL,
            "HUF" => rub.Model.Valute.HUF,
            "HKD" => rub.Model.Valute.HKD,
            "DKK" => rub.Model.Valute.DKK,
            "USD" => rub.Model.Valute.USD,
            "EUR" => rub.Model.Valute.EUR,
            "INR" => rub.Model.Valute.INR,
            "KZT" => rub.Model.Valute.KZT,
            "CAD" => rub.Model.Valute.CAD,
            "KGS" => rub.Model.Valute.KGS,
            "CNY" => rub.Model.Valute.CNY,
            "MDL" => rub.Model.Valute.MDL,
            "NOK" => rub.Model.Valute.NOK,
            "PLN" => rub.Model.Valute.PLN,
            "RON" => rub.Model.Valute.RON,
            "XDR" => rub.Model.Valute.XDR,
            "SGD" => rub.Model.Valute.SGD,
            "TJS" => rub.Model.Valute.TJS,
            "TRY" => rub.Model.Valute.TRY,
            "TMT" => rub.Model.Valute.TMT,
            "UZS" => rub.Model.Valute.UZS,
            "UAH" => rub.Model.Valute.UAH,
            "CZK" => rub.Model.Valute.CZK,
            "SEK" => rub.Model.Valute.SEK,
            "CHF" => rub.Model.Valute.CHF,
            "ZAR" => rub.Model.Valute.ZAR,
            "KRW" => rub.Model.Valute.KRW,
            "JPY" => rub.Model.Valute.JPY,
            _ => null
        };
    }
}