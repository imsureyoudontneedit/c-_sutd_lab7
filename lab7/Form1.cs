using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;
using System;

namespace lab7
{
    public partial class lab7 : Form
    {

        // Переменные для графика

        int buttonClickCount = 0;
        int pointX = 0;

        // Переменные для калькулятора

        private string currentInput = string.Empty;
        private double result = 0;
        private string operation = string.Empty;

        public lab7()
        {
            InitializeComponent();
            InitializeChart();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Деление на 3

        private void dividedBy3_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(numToDived.Text);
            MessageBox.Show($"{(number % 3 == 0 ? "Число делится на 3" : "Число не делится на 3")}", "Да вы батюшка волшебник", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        // Смена цвета 

        private void colorChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = (string)colorChange.Text;
            changeColor.BackColor = Color.FromName(selectedValue);
        }

        // График кликов

        private void InitializeChart()
        {
            showBtnCount.Series.Clear();
            Series series = new Series("Клики");
            series.ChartType = SeriesChartType.Column;
            showBtnCount.Series.Add(series);
            showBtnCount.ChartAreas.Add(new ChartArea());
        }

        private void counter_Click(object sender, EventArgs e)
        {
            buttonClickCount++;
            count.Text = Convert.ToString(buttonClickCount);
        }

        private void placeIntoChart_Click(object sender, EventArgs e)
        {
            if (buttonClickCount > 0)
            {
                showBtnCount.Series[0].Points.AddXY(pointX,buttonClickCount);
                buttonClickCount = 0;
                count.Text = Convert.ToString(buttonClickCount);
                pointX += 5;
            }
            else
            {
                MessageBox.Show("Ты шо меня за дурака держишь, на кнопку выше сначала жамкай!", "Ахтунг, среди нас дебил!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Калькулятор
        private void button4_Click(object sender, EventArgs e)
        {
            calcContainer.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(calcContainer.Text.Length > 0)
                calcContainer.Text = calcContainer.Text.Remove(calcContainer.Text.Length - 1);
        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentInput += button.Text;
            calcContainer.Text = currentInput;
        }

        private void operation_Click(object sender, EventArgs e)
        {
           Button button = (Button)sender;
           if (!string.IsNullOrEmpty(currentInput))
           {
                result = double.Parse(currentInput);
                operation = button.Text;
                currentInput = string.Empty;
           }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                double secondOperand = double.Parse(currentInput);
                switch (operation)
                {
                    case "+":
                        result += secondOperand;
                        break;
                    case "-":
                        result -= secondOperand;
                        break;
                    case "*":
                        result *= secondOperand;
                        break;
                    case "/":
                        if (secondOperand != 0)
                            result /= secondOperand;
                        else
                            MessageBox.Show("Тебя в школе не учили, что на 0 делить нельзя?");
                        break;
                    case "^":
                        result = Math.Pow(result, secondOperand);
                        break;
                }
                calcContainer.Text = result.ToString();
                currentInput = string.Empty;
            }
        }
    }
}
