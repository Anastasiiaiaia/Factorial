namespace Factorial19._09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void resolveButton_Click(object sender, EventArgs e)
        {
            int number = (int)numericUpDown1.Value;

            progressBar1.Value = 0;
            textBox1.Text = "";

            long result = await CalculateFactorial(number);

            textBox1.Text = result.ToString();
            progressBar1.Value = 100;
        }

        private async Task<long> CalculateFactorial(int number)
        {
            int middle = number / 2;

            Task<long> task1 = Task.Run(() =>
            {
                long result = 1;

                for (int i = 1; i <= middle; i++)
                {
                    result *= i;
                }

                return result;
            });

            Task<long> task2 = Task.Run(() =>
            {
                long result = 1;

                for (int i = middle + 1; i <= number; i++)
                {
                    result *= i;
                }

                return result;
            });

            long result1 = await task1;
            long result2 = await task2;

            return result1 * result2;
        }

    }
}
