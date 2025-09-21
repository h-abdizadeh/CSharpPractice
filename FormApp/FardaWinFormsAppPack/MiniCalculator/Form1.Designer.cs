namespace MiniCalculator
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "number 1";
            textBox1.Size = new Size(238, 43);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20F);
            textBox2.Location = new Point(12, 61);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "number 2";
            textBox2.Size = new Size(238, 43);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 107);
            label1.Name = "label1";
            label1.Size = new Size(32, 37);
            label1.TabIndex = 2;
            label1.Text = "0";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 21F);
            button1.Location = new Point(12, 181);
            button1.Name = "button1";
            button1.Size = new Size(55, 55);
            button1.TabIndex = 3;
            button1.Text = "+";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 21F);
            button2.Location = new Point(73, 181);
            button2.Name = "button2";
            button2.Size = new Size(55, 55);
            button2.TabIndex = 4;
            button2.Text = "-";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 21F);
            button3.Location = new Point(134, 181);
            button3.Name = "button3";
            button3.Size = new Size(55, 55);
            button3.TabIndex = 5;
            button3.Text = "×";
            button3.TextAlign = ContentAlignment.TopCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 21F);
            button4.Location = new Point(195, 181);
            button4.Name = "button4";
            button4.Size = new Size(55, 55);
            button4.TabIndex = 6;
            button4.Text = "÷";
            button4.TextAlign = ContentAlignment.TopCenter;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 248);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "mini calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
