namespace CurrencyConverterTask
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label = new System.Windows.Forms.Label();
            this.dropDownFrom = new System.Windows.Forms.ComboBox();
            this.valuteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dropDownTo = new System.Windows.Forms.ComboBox();
            this.toValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericFrom = new System.Windows.Forms.NumericUpDown();
            this.convertButton = new System.Windows.Forms.Button();
            this.logsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.valuteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(70, 24);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(311, 25);
            this.label.TabIndex = 0;
            this.label.Text = "Choose currencies and enter the value";
            // 
            // dropDownFrom
            // 
            this.dropDownFrom.FormattingEnabled = true;
            this.dropDownFrom.Items.AddRange(new object[] {
            "AUD (Австралийский доллар)",
            "AZN (Азербайджанский манат)",
            "GBP (Фунт стерлингов Соединенного королевства)",
            "AMD (Армянских драмов)",
            "BYN (Белорусский рубль)",
            "BGN (Болгарский лев)",
            "BRL (Бразильский реал)",
            "HUF (Венгерских форинтов)",
            "HKD (Гонконгских долларов)",
            "DKK (Датская крона)",
            "USD (Доллар США)",
            "EUR (Евро)",
            "INR (Индийских рупий)",
            "KZT (Казахстанских тенге)",
            "CAD (Канадский доллар)",
            "KGS (Киргизских сомов)",
            "CNY (Китайский юань)",
            "MDL (Молдавских леев)",
            "NOK (Норвежских крон)",
            "PLN (Польский злотый)",
            "RON (Румынский лей)",
            "XDR (СДР (специальные права заимствования))",
            "SGD (Сингапурский доллар)",
            "TJS (Таджикских сомони)",
            "TRY (Турецких лир)",
            "TMT (Новый туркменский манат)",
            "UZS (Узбекских сумов)",
            "UAH (Украинских гривен)",
            "CZK (Чешских крон)",
            "SEK (Шведских крон)",
            "CHF (Швейцарский франк)",
            "ZAR (Южноафриканских рэндов)",
            "KRW (Вон Республики Корея)",
            "JPY (Японских иен)",
            "RUB (Российский рубль)"});
            this.dropDownFrom.Location = new System.Drawing.Point(80, 82);
            this.dropDownFrom.Name = "dropDownFrom";
            this.dropDownFrom.Size = new System.Drawing.Size(462, 33);
            this.dropDownFrom.TabIndex = 1;
            this.dropDownFrom.SelectedIndexChanged += new System.EventHandler(this.dropDownFrom_SelectedIndexChanged);
            // 
            // valuteBindingSource
            // 
            this.valuteBindingSource.DataSource = typeof(CurrencyConverterTask._valute);
            // 
            // dropDownTo
            // 
            this.dropDownTo.FormattingEnabled = true;
            this.dropDownTo.Location = new System.Drawing.Point(80, 148);
            this.dropDownTo.Name = "dropDownTo";
            this.dropDownTo.Size = new System.Drawing.Size(462, 33);
            this.dropDownTo.TabIndex = 2;
            // 
            // toValue
            // 
            this.toValue.Enabled = false;
            this.toValue.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toValue.Location = new System.Drawing.Point(578, 148);
            this.toValue.Name = "toValue";
            this.toValue.Size = new System.Drawing.Size(164, 34);
            this.toValue.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "To";
            // 
            // numericFrom
            // 
            this.numericFrom.Location = new System.Drawing.Point(578, 83);
            this.numericFrom.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericFrom.Name = "numericFrom";
            this.numericFrom.Size = new System.Drawing.Size(164, 31);
            this.numericFrom.TabIndex = 7;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(564, 199);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(194, 53);
            this.convertButton.TabIndex = 8;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // logsButton
            // 
            this.logsButton.BackColor = System.Drawing.SystemColors.Info;
            this.logsButton.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logsButton.Location = new System.Drawing.Point(1, -1);
            this.logsButton.Name = "logsButton";
            this.logsButton.Size = new System.Drawing.Size(50, 50);
            this.logsButton.TabIndex = 9;
            this.logsButton.Text = "Logs";
            this.logsButton.UseVisualStyleBackColor = false;
            this.logsButton.Click += new System.EventHandler(this.logsButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 264);
            this.Controls.Add(this.logsButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.numericFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toValue);
            this.Controls.Add(this.dropDownTo);
            this.Controls.Add(this.dropDownFrom);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Currency Converter";
            ((System.ComponentModel.ISupportInitialize)(this.valuteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFrom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label;
        private ComboBox dropDownFrom;
        private ComboBox dropDownTo;
        private TextBox fromValue;
        private TextBox toValue;
        private Label label1;
        private Label label2;
        private BindingSource valuteBindingSource;
        private NumericUpDown numericFrom;
        private Button convertButton;
        private Button logsButton;
    }
}