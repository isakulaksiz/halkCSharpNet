namespace usingSwitchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double price = Convert.ToDouble(textBoxPrice.Text);
            var taxCount = numericUpDownTaxCount.Value;

            var payment = price / (double)taxCount;

            for (int i = 1; i <= taxCount; i++)
            {
                DateTime paymentDate = DateTime.Now.AddMonths(i);


                switch (paymentDate.DayOfWeek)
                {
                    case DayOfWeek.Sunday:
                        paymentDate = paymentDate.AddDays(1);
                        break;
                    case DayOfWeek.Saturday:
                        paymentDate = paymentDate.AddDays(2);
                        break;
                    default:
                        break;
                }


                listBoxCalender.Items.Add($"{paymentDate.ToLongDateString()} {payment.ToString("C2")}");

            }




        }
    }
}