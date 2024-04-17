namespace _10lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double dayRate = 0.05;
            const double nightRate = 0.05 * 0.7;

            if (!double.TryParse(durationTextBox.Text, out double duration) || duration <= 0)
            {
                MessageBox.Show("Пожалуйста, введите корректную продолжительность разговора.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isNightTime = nightTimeCheckBox.Checked;

            double cost;
            if (isNightTime)
            {
                cost = duration * nightRate;
            }
            else
            {
                cost = duration * dayRate;
            }

            resultLabel.Text = $"Стоимость разговора: {cost:C}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nightTimeCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void durationTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
