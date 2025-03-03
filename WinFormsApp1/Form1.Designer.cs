namespace WinFormsApp1
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            num1 = new Button();
            num2 = new Button();
            num3 = new Button();
            num4 = new Button();
            num5 = new Button();
            num6 = new Button();
            num7 = new Button();
            num8 = new Button();
            equalbutton = new Button();
            addbutton = new Button();
            subbutton = new Button();
            clearbutton = new Button();
            btnMS = new Button();
            memoryItemBindingSource = new BindingSource(components);
            num9 = new Button();
            num0 = new Button();
            label1 = new Label();
            txtResult = new TextBox();
            memoryPanel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)memoryItemBindingSource).BeginInit();
            SuspendLayout();
            // 
            // num1
            // 
            num1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            num1.Location = new Point(12, 283);
            num1.Name = "num1";
            num1.Size = new Size(75, 59);
            num1.TabIndex = 1;
            num1.Text = "1";
            num1.UseVisualStyleBackColor = true;
            num1.Click += NumButton_Click;
            // 
            // num2
            // 
            num2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            num2.Location = new Point(93, 283);
            num2.Name = "num2";
            num2.Size = new Size(75, 59);
            num2.TabIndex = 2;
            num2.Text = "2";
            num2.UseVisualStyleBackColor = true;
            num2.Click += NumButton_Click;
            // 
            // num3
            // 
            num3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            num3.Location = new Point(174, 283);
            num3.Name = "num3";
            num3.Size = new Size(75, 59);
            num3.TabIndex = 3;
            num3.Text = "3";
            num3.UseVisualStyleBackColor = true;
            num3.Click += NumButton_Click;
            // 
            // num4
            // 
            num4.Font = new Font("Segoe UI", 16F);
            num4.Location = new Point(12, 218);
            num4.Name = "num4";
            num4.Size = new Size(75, 59);
            num4.TabIndex = 4;
            num4.Text = "4";
            num4.UseVisualStyleBackColor = true;
            num4.Click += NumButton_Click;
            // 
            // num5
            // 
            num5.Font = new Font("Segoe UI", 16F);
            num5.Location = new Point(93, 218);
            num5.Name = "num5";
            num5.Size = new Size(75, 59);
            num5.TabIndex = 6;
            num5.Text = "5";
            num5.UseVisualStyleBackColor = true;
            num5.Click += NumButton_Click;
            // 
            // num6
            // 
            num6.Font = new Font("Segoe UI", 16F);
            num6.Location = new Point(174, 218);
            num6.Name = "num6";
            num6.Size = new Size(75, 59);
            num6.TabIndex = 5;
            num6.Text = "6";
            num6.UseVisualStyleBackColor = true;
            num6.Click += NumButton_Click;
            // 
            // num7
            // 
            num7.Font = new Font("Segoe UI", 16F);
            num7.Location = new Point(12, 153);
            num7.Name = "num7";
            num7.Size = new Size(75, 59);
            num7.TabIndex = 9;
            num7.Text = "7";
            num7.UseVisualStyleBackColor = true;
            num7.Click += NumButton_Click;
            // 
            // num8
            // 
            num8.Font = new Font("Segoe UI", 16F);
            num8.Location = new Point(93, 153);
            num8.Name = "num8";
            num8.Size = new Size(75, 59);
            num8.TabIndex = 8;
            num8.Text = "8";
            num8.UseVisualStyleBackColor = true;
            num8.Click += NumButton_Click;
            // 
            // equalbutton
            // 
            equalbutton.BackColor = Color.MediumSlateBlue;
            equalbutton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            equalbutton.Location = new Point(93, 348);
            equalbutton.Name = "equalbutton";
            equalbutton.Size = new Size(156, 59);
            equalbutton.TabIndex = 10;
            equalbutton.Text = "=";
            equalbutton.UseVisualStyleBackColor = false;
            equalbutton.Click += equalbutton_Click;
            // 
            // addbutton
            // 
            addbutton.BackColor = SystemColors.Control;
            addbutton.Font = new Font("Segoe UI", 16F);
            addbutton.Location = new Point(255, 348);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(75, 59);
            addbutton.TabIndex = 11;
            addbutton.Text = "+";
            addbutton.UseVisualStyleBackColor = false;
            addbutton.Click += addbutton_Click;
            // 
            // subbutton
            // 
            subbutton.BackColor = SystemColors.Control;
            subbutton.Font = new Font("Segoe UI", 16F);
            subbutton.Location = new Point(255, 283);
            subbutton.Name = "subbutton";
            subbutton.Size = new Size(75, 59);
            subbutton.TabIndex = 12;
            subbutton.Text = "-";
            subbutton.UseVisualStyleBackColor = false;
            subbutton.Click += subbutton_Click;
            // 
            // clearbutton
            // 
            clearbutton.BackColor = SystemColors.Control;
            clearbutton.Font = new Font("Segoe UI", 12F);
            clearbutton.Location = new Point(255, 218);
            clearbutton.Name = "clearbutton";
            clearbutton.Size = new Size(75, 59);
            clearbutton.TabIndex = 13;
            clearbutton.Text = "C";
            clearbutton.UseVisualStyleBackColor = false;
            clearbutton.Click += clearbutton_Click;
            // 
            // btnMS
            // 
            btnMS.BackColor = SystemColors.Control;
            btnMS.Font = new Font("Segoe UI", 12F);
            btnMS.Location = new Point(255, 153);
            btnMS.Name = "btnMS";
            btnMS.Size = new Size(75, 59);
            btnMS.TabIndex = 14;
            btnMS.Text = "MS";
            btnMS.UseVisualStyleBackColor = false;
            btnMS.Click += btnMS_Click;
            // 
            // memoryItemBindingSource
            // 
            memoryItemBindingSource.DataSource = typeof(CalculatorLibrary.Memoryfolder.MemoryItem);
            // 
            // num9
            // 
            num9.Font = new Font("Segoe UI", 16F);
            num9.Location = new Point(174, 153);
            num9.Name = "num9";
            num9.Size = new Size(75, 59);
            num9.TabIndex = 16;
            num9.Text = "9";
            num9.UseVisualStyleBackColor = true;
            num9.Click += NumButton_Click;
            // 
            // num0
            // 
            num0.Font = new Font("Segoe UI", 16F);
            num0.Location = new Point(12, 348);
            num0.Name = "num0";
            num0.Size = new Size(75, 59);
            num0.TabIndex = 17;
            num0.Text = "0";
            num0.UseVisualStyleBackColor = true;
            num0.Click += NumButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(349, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 18;
            label1.Text = "Memory";
            // 
            // txtResult
            // 
            txtResult.AcceptsTab = true;
            txtResult.Font = new Font("Segoe UI", 16F);
            txtResult.Location = new Point(12, 40);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(318, 100);
            txtResult.TabIndex = 20;
            txtResult.Text = "0";
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // memoryPanel
            // 
            memoryPanel.Location = new Point(361, 40);
            memoryPanel.Name = "memoryPanel";
            memoryPanel.Size = new Size(299, 367);
            memoryPanel.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(681, 412);
            Controls.Add(memoryPanel);
            Controls.Add(txtResult);
            Controls.Add(label1);
            Controls.Add(num0);
            Controls.Add(num9);
            Controls.Add(btnMS);
            Controls.Add(clearbutton);
            Controls.Add(subbutton);
            Controls.Add(addbutton);
            Controls.Add(equalbutton);
            Controls.Add(num7);
            Controls.Add(num8);
            Controls.Add(num5);
            Controls.Add(num6);
            Controls.Add(num4);
            Controls.Add(num3);
            Controls.Add(num2);
            Controls.Add(num1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)memoryItemBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button num1;
        private Button num2;
        private Button num3;
        private Button num4;
        private Button num5;
        private Button num6;
        private Button num7;
        private Button num8;
        private Button equalbutton;
        private Button addbutton;
        private Button subbutton;
        private Button clearbutton;
        private Button btnMS;
        private BindingSource memoryItemBindingSource;
        private Button num9;
        private Button num0;
        private Label label1;
        private TextBox txtResult;
        private FlowLayoutPanel memoryPanel;
    }
}
