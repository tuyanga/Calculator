using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CalculatorLibrary.Calculatorfoler;
using CalculatorLibrary.Memoryfolder;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Calculator calc = new Calculator();
        private Memory memory = new Memory();
        public Form1()
        {
            InitializeComponent();
        }

        private int currentValue = 0;
        private int previousValue = 0;
        private char operation = ' ';
        private bool entervalue = false;

        private void NumButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (txtResult.Text == "0" || entervalue)
            {
                txtResult.Text = btn.Text;
                entervalue = false;
            }
            else
            {
                txtResult.Text += btn.Text;
            }
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtResult.Text, out previousValue))
            {
                operation = '+';
                txtResult.Clear();
                entervalue = true;
            }
        }

        private void subbutton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtResult.Text, out previousValue))
            {
                operation = '-';
                txtResult.Clear();
                entervalue = true;
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            currentValue = 0;
            previousValue = 0;
            operation = ' ';
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtResult.Text, out int value))
            {
                memory.MSave(value);
                AddMemoryItem(value);
            }
            entervalue = true;
        }

        private void equalbutton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtResult.Text, out currentValue))
            {
                if (operation == '+')
                    txtResult.Text = (previousValue + currentValue).ToString();
                else if (operation == '-')
                    txtResult.Text = (previousValue - currentValue).ToString();
            }
            entervalue = true;
        }

        private void AddMemoryItem(int value)
        {
            Panel memoryItem = new Panel
            {
                Height = 30,
                Width = memoryPanel.Width - 5,
                BorderStyle = BorderStyle.FixedSingle
            };

            Label lblValue = new Label
            {
                Text = value.ToString(),
                AutoSize = true,
                Location = new Point(5, 5)
            };

            Button btnMC = new Button
            {
                Text = "MC",
                Width = 40,
                Height = 25,
                Location = new Point(60, 2)
            };
            btnMC.Click += (s, e) => { memoryPanel.Controls.Remove(memoryItem); calc.MClear(); };

            Button btnMPlus = new Button
            {
                Text = "M+",
                Width = 40,
                Height = 25,
                Location = new Point(105, 2)
            };
            btnMPlus.Click += (s, e) => { memory.MAdd(int.Parse(txtResult.Text)); lblValue.Text = memory.MRecall().ToString(); entervalue = true; };

            Button btnMMinus = new Button
            {
                Text = "M-",
                Width = 40,
                Height = 25,
                Location = new Point(150, 2)
            };
            btnMMinus.Click += (s, e) => { memory.MSub(int.Parse(txtResult.Text)); lblValue.Text = memory.MRecall().ToString(); entervalue = true; };

            memoryItem.Controls.Add(lblValue);
            memoryItem.Controls.Add(btnMC);
            memoryItem.Controls.Add(btnMPlus);
            memoryItem.Controls.Add(btnMMinus);

            memoryPanel.Controls.Add(memoryItem);
        }
    }
}
