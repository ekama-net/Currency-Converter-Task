namespace CurrencyConverterTask
{
    public class LogModel
    {
        public int Id { get; set; }
        public string FromName { get; set; }
        public string ToName { get; set; }
        public decimal Nominal { get; set; }
        public double Result { get; set; }
        public DateTime Date { get; set; }
    }
}
