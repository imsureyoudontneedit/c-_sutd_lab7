using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;
using System;

namespace lab7
{
    public partial class lab7 : Form
    {

        // ���������� ��� �������

        int buttonClickCount = 0;
        int pointX = 0;

        // ���������� ��� ������������

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

        // ������� �� 3

        private void dividedBy3_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(numToDived.Text);
            MessageBox.Show($"{(number % 3 == 0 ? "����� ������� �� 3" : "����� �� ������� �� 3")}", "�� �� ������� ���������", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        // ����� ����� 

        private void colorChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = (string)colorChange.Text;
            changeColor.BackColor = Color.FromName(selectedValue);
        }

        // ������ ������

        private void InitializeChart()
        {
            showBtnCount.Series.Clear();
            Series series = new Series("�����");
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
                MessageBox.Show("�� �� ���� �� ������ �������, �� ������ ���� ������� ������!", "������, ����� ��� �����!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // �����������
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
                            MessageBox.Show("���� � ����� �� �����, ��� �� 0 ������ ������?");
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
