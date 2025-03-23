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
        public Form1()
        {
            InitializeComponent();
        }

        private char operation = ' ';
        private bool entervalue = false;
        private bool OperationPending = false;

        private void NumButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (txtResult.Text == "0" || entervalue)
            {
                txtResult.Text = btn.Text;
                entervalue = false;
            }
            else if (btn.Text == "-" && !txtResult.Text.Contains("-"))
            {
                txtResult.Text = "-" + txtResult.Text;  // Сөрөг тоо бичихийг зөвшөөрнө
            }
            else
            {
                txtResult.Text += btn.Text;
            }
            OperationPending = false;
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            CalculatePendingOperation();
            operation = '+';
            entervalue = true;
            OperationPending = true;
        }

        private void subbutton_Click(object sender, EventArgs e)
        {
            CalculatePendingOperation();
            operation = '-';
            entervalue = true;
            OperationPending = true;
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            calc.Result = 0;
            operation = ' ';
        }
        private void equalbutton_Click(object sender, EventArgs e)
        {
            CalculatePendingOperation();
            txtResult.Text = calc.Result.ToString();
            operation = ' ';
            entervalue = true;
        }
        private void CalculatePendingOperation()
        {
            if (OperationPending) return;
            if (int.TryParse(txtResult.Text, out int num))
            {
                if (operation == '+')
                {
                    calc.Add(num);
                }
                else if (operation == '-')
                {
                    calc.Sub(num);
                }
                else
                {
                    calc.Result = num;
                }
            }
        }
        private void btnMS_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtResult.Text, out int value))
            {
                calc.Result = value;
                MemoryItem memItem = calc.MSave();
                AddMemoryItem(memItem);
            }
            entervalue = true;
        }


        private void AddMemoryItem(MemoryItem memItem)
        {
            Panel memoryItemPanel = new Panel
            {
                Height = 50,
                Width = memoryPanel.Width - 20,
                BorderStyle = BorderStyle.FixedSingle
            };

            Label lblValue = new Label
            {
                Text = memItem.Value.ToString(),
                AutoSize = true,
                Location = new Point(5, 5)
            };

            Button btnMC = new Button
            {
                Text = "MC",
                Width = 60,
                Height = 45,
                Location = new Point(85, 2)
            };
            btnMC.Click += (s, e) => 
            {
                memItem.MC(calc.memory.memoryList); 
                memoryPanel.Controls.Remove(memoryItemPanel); 
            };

            Button btnMPlus = new Button
            {
                Text = "M+",
                Width = 60,
                Height = 45,
                Location = new Point(150, 2)
            };
            btnMPlus.Click += (s, e) =>
            {
                if (int.TryParse(txtResult.Text, out int inputValue))
                {
                    memItem.MAdd(inputValue);
                    lblValue.Text = memItem.Value.ToString();
                }
                entervalue = true;
            };

            Button btnMMinus = new Button
            {
                Text = "M-",
                Width = 60,
                Height = 45,
                Location = new Point(215, 2)
            };
            btnMMinus.Click += (s, e) =>
            {
                if (int.TryParse(txtResult.Text, out int inputValue))
                {
                    memItem.MSub(inputValue);
                    lblValue.Text = memItem.Value.ToString();
                }
                entervalue = true;
            };

            memoryItemPanel.Controls.Add(lblValue);
            memoryItemPanel.Controls.Add(btnMC);
            memoryItemPanel.Controls.Add(btnMPlus);
            memoryItemPanel.Controls.Add(btnMMinus);

            memoryPanel.Controls.Add(memoryItemPanel);
            memoryPanel.Height = 800;

            if (memoryPanel.Controls.Count * 70 > 800)
            {
                memoryPanel.AutoScroll = true;
            }
            else
            {
                memoryPanel.AutoScroll = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            memoryPanel.AutoScroll = true;
        }
    }
}