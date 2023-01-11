namespace CurrencyConverterTask
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
            using (var context = new ConverterContext())
            {
                var data = context.logModels.ToList();
                dataGridView1.DataSource = data;
                dataGridView1.Columns["Id"].Visible = false;
            }
        }
    }
}
