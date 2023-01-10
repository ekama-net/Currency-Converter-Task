namespace CurrencyConverterTask
{
    public class ApiModel
    {
        public DateTime Date { get; set; }
        public DateTime PreviousDate { get; set; }
        public string PreviousURL { get; set; }
        public string Timestamp { get; set; }
        public _valute Valute { get; set; }
    }

    public class _valute 
    {
        public ModelValute RUB { get; set; }
        public ModelValute AUD { get; set; }
        public ModelValute AZN { get; set; }
        public ModelValute GBP { get; set; }
        public ModelValute AMD { get; set; }
        public ModelValute BYN { get; set; }
        public ModelValute BGN { get; set; }
        public ModelValute BRL { get; set; }
        public ModelValute HUF { get; set; }
        public ModelValute HKD { get; set; }
        public ModelValute DKK { get; set; }
        public ModelValute USD { get; set; }
        public ModelValute EUR { get; set; }
        public ModelValute INR { get; set; }
        public ModelValute KZT { get; set; }
        public ModelValute CAD { get; set; }
        public ModelValute KGS { get; set; }
        public ModelValute CNY { get; set; }
        public ModelValute MDL { get; set; }
        public ModelValute NOK { get; set; }
        public ModelValute PLN { get; set; }
        public ModelValute RON { get; set; }
        public ModelValute XDR { get; set; }
        public ModelValute SGD { get; set; }
        public ModelValute TJS { get; set; }
        public ModelValute TRY { get; set; }
        public ModelValute TMT { get; set; }
        public ModelValute UZS { get; set; }
        public ModelValute UAH { get; set; }
        public ModelValute CZK { get; set; }
        public ModelValute SEK { get; set; }
        public ModelValute CHF { get; set; }
        public ModelValute ZAR { get; set; }
        public ModelValute KRW { get; set; }
        public ModelValute JPY { get; set; }
    }

    public class ModelValute
    {
        private double value;
        public string ID { get; set; }
        public string NumCode { get; set; }
        public string CharCode { get; set; }
        public int Nominal { get; set; }
        public string Name { get; set; }
        public double Value 
        { 
            get { return value; }
            set { this.value = value / Nominal; }
        }
        public double Previous { get; set; }
    }
}
