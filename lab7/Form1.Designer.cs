namespace lab7
{
    partial class lab7
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lab7));
            changeColor = new TabPage();
            colorChange = new ComboBox();
            label3 = new Label();
            tabPage1 = new TabPage();
            dividedBy3 = new Button();
            label2 = new Label();
            numToDived = new TextBox();
            label1 = new Label();
            mainTabControl = new TabControl();
            tabPage3 = new TabPage();
            label4 = new Label();
            count = new Label();
            placeIntoChart = new Button();
            counter = new Button();
            showBtnCount = new System.Windows.Forms.DataVisualization.Charting.Chart();
            tabPage4 = new TabPage();
            buttonEqual = new Button();
            button19 = new Button();
            button17 = new Button();
            button16 = new Button();
            button15 = new Button();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            calcContainer = new TextBox();
            changeColor.SuspendLayout();
            tabPage1.SuspendLayout();
            mainTabControl.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)showBtnCount).BeginInit();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // changeColor
            // 
            changeColor.BackColor = Color.White;
            changeColor.Controls.Add(colorChange);
            changeColor.Controls.Add(label3);
            changeColor.Location = new Point(4, 24);
            changeColor.Name = "changeColor";
            changeColor.Padding = new Padding(3);
            changeColor.Size = new Size(791, 420);
            changeColor.TabIndex = 1;
            changeColor.Text = "BackColor";
            // 
            // colorChange
            // 
            colorChange.FormattingEnabled = true;
            colorChange.Items.AddRange(new object[] { "Yellow", "Red", "Blue", "Green", "Orange", "Purple", "Black" });
            colorChange.Location = new Point(317, 163);
            colorChange.Name = "colorChange";
            colorChange.Size = new Size(121, 23);
            colorChange.TabIndex = 2;
            colorChange.SelectedIndexChanged += colorChange_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Lucida Console", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(167, 108);
            label3.Name = "label3";
            label3.Size = new Size(407, 16);
            label3.TabIndex = 1;
            label3.Text = "Я у мамы дизайнер, но мне кое-что мешает";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dividedBy3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(numToDived);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(791, 420);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Деление на 3";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dividedBy3
            // 
            dividedBy3.Cursor = Cursors.Hand;
            dividedBy3.Font = new Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dividedBy3.Location = new Point(308, 192);
            dividedBy3.Name = "dividedBy3";
            dividedBy3.Size = new Size(131, 44);
            dividedBy3.TabIndex = 5;
            dividedBy3.Text = "Узнай истину";
            dividedBy3.Click += dividedBy3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(208, 132);
            label2.Name = "label2";
            label2.Size = new Size(306, 12);
            label2.TabIndex = 7;
            label2.Text = "Введите число для проверки его деления на 3\r\n";
            // 
            // numToDived
            // 
            numToDived.Cursor = Cursors.IBeam;
            numToDived.Font = new Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numToDived.Location = new Point(260, 167);
            numToDived.Name = "numToDived";
            numToDived.Size = new Size(221, 19);
            numToDived.TabIndex = 4;
            numToDived.Text = "Введите число для проверки";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(145, 106);
            label1.Name = "label1";
            label1.Size = new Size(432, 12);
            label1.TabIndex = 6;
            label1.Text = "На данной странице вы можете проверить свои силы в математике\r\n";
            // 
            // mainTabControl
            // 
            mainTabControl.Controls.Add(tabPage1);
            mainTabControl.Controls.Add(changeColor);
            mainTabControl.Controls.Add(tabPage3);
            mainTabControl.Controls.Add(tabPage4);
            mainTabControl.Location = new Point(0, 0);
            mainTabControl.Name = "mainTabControl";
            mainTabControl.SelectedIndex = 0;
            mainTabControl.Size = new Size(799, 448);
            mainTabControl.TabIndex = 4;
            mainTabControl.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(count);
            tabPage3.Controls.Add(placeIntoChart);
            tabPage3.Controls.Add(counter);
            tabPage3.Controls.Add(showBtnCount);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(791, 420);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "График";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(421, 87);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 3;
            label4.Text = "Количество:";
            // 
            // count
            // 
            count.AutoSize = true;
            count.Location = new Point(502, 87);
            count.Name = "count";
            count.Size = new Size(13, 15);
            count.TabIndex = 2;
            count.Text = "0";
            // 
            // placeIntoChart
            // 
            placeIntoChart.Location = new Point(287, 131);
            placeIntoChart.Name = "placeIntoChart";
            placeIntoChart.Size = new Size(128, 23);
            placeIntoChart.TabIndex = 1;
            placeIntoChart.Text = "Записать данные";
            placeIntoChart.UseVisualStyleBackColor = true;
            placeIntoChart.Click += placeIntoChart_Click;
            // 
            // counter
            // 
            counter.Location = new Point(287, 83);
            counter.Name = "counter";
            counter.Size = new Size(128, 23);
            counter.TabIndex = 1;
            counter.Text = "Нажми меня!!1!!";
            counter.UseVisualStyleBackColor = true;
            counter.Click += counter_Click;
            // 
            // showBtnCount
            // 
            chartArea1.Name = "ChartArea1";
            showBtnCount.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            showBtnCount.Legends.Add(legend1);
            showBtnCount.Location = new Point(143, 160);
            showBtnCount.Name = "showBtnCount";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            showBtnCount.Series.Add(series1);
            showBtnCount.Size = new Size(567, 219);
            showBtnCount.TabIndex = 0;
            showBtnCount.Text = "chart1";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(buttonEqual);
            tabPage4.Controls.Add(button19);
            tabPage4.Controls.Add(button17);
            tabPage4.Controls.Add(button16);
            tabPage4.Controls.Add(button15);
            tabPage4.Controls.Add(button14);
            tabPage4.Controls.Add(button13);
            tabPage4.Controls.Add(button12);
            tabPage4.Controls.Add(button11);
            tabPage4.Controls.Add(button10);
            tabPage4.Controls.Add(button9);
            tabPage4.Controls.Add(button8);
            tabPage4.Controls.Add(button7);
            tabPage4.Controls.Add(button6);
            tabPage4.Controls.Add(button5);
            tabPage4.Controls.Add(button4);
            tabPage4.Controls.Add(button3);
            tabPage4.Controls.Add(button2);
            tabPage4.Controls.Add(calcContainer);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(791, 420);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Калькулятор";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonEqual
            // 
            buttonEqual.Location = new Point(292, 134);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(44, 23);
            buttonEqual.TabIndex = 19;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = true;
            buttonEqual.Click += buttonEquals_Click;
            // 
            // button19
            // 
            button19.Location = new Point(442, 250);
            button19.Name = "button19";
            button19.Size = new Size(44, 23);
            button19.TabIndex = 19;
            button19.Text = "+";
            button19.UseVisualStyleBackColor = true;
            button19.Click += operation_Click;
            // 
            // button17
            // 
            button17.Location = new Point(442, 192);
            button17.Name = "button17";
            button17.Size = new Size(44, 23);
            button17.TabIndex = 17;
            button17.Text = "*";
            button17.UseVisualStyleBackColor = true;
            button17.Click += operation_Click;
            // 
            // button16
            // 
            button16.Location = new Point(442, 221);
            button16.Name = "button16";
            button16.Size = new Size(44, 23);
            button16.TabIndex = 16;
            button16.Text = "-";
            button16.UseVisualStyleBackColor = true;
            button16.Click += operation_Click;
            // 
            // button15
            // 
            button15.Location = new Point(392, 221);
            button15.Name = "button15";
            button15.Size = new Size(44, 23);
            button15.TabIndex = 15;
            button15.Text = "3";
            button15.UseVisualStyleBackColor = true;
            button15.Click += buttonNumber_Click;
            // 
            // button14
            // 
            button14.Location = new Point(342, 221);
            button14.Name = "button14";
            button14.Size = new Size(44, 23);
            button14.TabIndex = 14;
            button14.Text = "2";
            button14.UseVisualStyleBackColor = true;
            button14.Click += buttonNumber_Click;
            // 
            // button13
            // 
            button13.Location = new Point(292, 221);
            button13.Name = "button13";
            button13.Size = new Size(44, 23);
            button13.TabIndex = 13;
            button13.Text = "1";
            button13.UseVisualStyleBackColor = true;
            button13.Click += buttonNumber_Click;
            // 
            // button12
            // 
            button12.Location = new Point(442, 163);
            button12.Name = "button12";
            button12.Size = new Size(44, 23);
            button12.TabIndex = 12;
            button12.Text = "/";
            button12.UseVisualStyleBackColor = true;
            button12.Click += operation_Click;
            // 
            // button11
            // 
            button11.Location = new Point(392, 192);
            button11.Name = "button11";
            button11.Size = new Size(44, 23);
            button11.TabIndex = 11;
            button11.Text = "6";
            button11.UseVisualStyleBackColor = true;
            button11.Click += buttonNumber_Click;
            // 
            // button10
            // 
            button10.Location = new Point(342, 192);
            button10.Name = "button10";
            button10.Size = new Size(44, 23);
            button10.TabIndex = 10;
            button10.Text = "5";
            button10.UseVisualStyleBackColor = true;
            button10.Click += buttonNumber_Click;
            // 
            // button9
            // 
            button9.Location = new Point(292, 192);
            button9.Name = "button9";
            button9.Size = new Size(44, 23);
            button9.TabIndex = 9;
            button9.Text = "4";
            button9.UseVisualStyleBackColor = true;
            button9.Click += buttonNumber_Click;
            // 
            // button8
            // 
            button8.Location = new Point(342, 134);
            button8.Name = "button8";
            button8.Size = new Size(44, 23);
            button8.TabIndex = 8;
            button8.Text = "^";
            button8.UseVisualStyleBackColor = true;
            button8.Click += operation_Click;
            // 
            // button7
            // 
            button7.Location = new Point(392, 163);
            button7.Name = "button7";
            button7.Size = new Size(44, 23);
            button7.TabIndex = 7;
            button7.Text = "9";
            button7.UseVisualStyleBackColor = true;
            button7.Click += buttonNumber_Click;
            // 
            // button6
            // 
            button6.Location = new Point(342, 163);
            button6.Name = "button6";
            button6.Size = new Size(44, 23);
            button6.TabIndex = 6;
            button6.Text = "8";
            button6.UseVisualStyleBackColor = true;
            button6.Click += buttonNumber_Click;
            // 
            // button5
            // 
            button5.Location = new Point(292, 163);
            button5.Name = "button5";
            button5.Size = new Size(44, 23);
            button5.TabIndex = 5;
            button5.Text = "7";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonNumber_Click;
            // 
            // button4
            // 
            button4.Location = new Point(392, 134);
            button4.Name = "button4";
            button4.Size = new Size(44, 23);
            button4.TabIndex = 4;
            button4.Text = "CE";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(342, 250);
            button3.Name = "button3";
            button3.Size = new Size(44, 23);
            button3.TabIndex = 3;
            button3.Text = "0";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonNumber_Click;
            // 
            // button2
            // 
            button2.Location = new Point(442, 134);
            button2.Name = "button2";
            button2.Size = new Size(44, 23);
            button2.TabIndex = 2;
            button2.Text = "back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // calcContainer
            // 
            calcContainer.Location = new Point(292, 96);
            calcContainer.Name = "calcContainer";
            calcContainer.Size = new Size(194, 23);
            calcContainer.TabIndex = 0;
            calcContainer.KeyPress += calcContainer_KeyPress;
            // 
            // lab7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainTabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "lab7";
            Text = "Зомбидаболатория";
            Load += Form1_Load;
            changeColor.ResumeLayout(false);
            changeColor.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            mainTabControl.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)showBtnCount).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabPage changeColor;
        private TabPage tabPage1;
        private Button dividedBy3;
        private Label label2;
        private TextBox numToDived;
        private Label label1;
        private TabControl mainTabControl;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label label3;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button3;
        private Button button2;
        private TextBox calcContainer;
        private Button button19;
        private ComboBox colorChange;
        private Button button8;
        private Button button4;
        private System.Windows.Forms.DataVisualization.Charting.Chart showBtnCount;
        private Button placeIntoChart;
        private Button counter;
        private Label count;
        private Label label4;
        private Button buttonEqual;
    }
}
