namespace Counter
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 72F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(109, 128);
            label1.TabIndex = 0;
            label1.Text = "0";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 21F);
            textBox1.Location = new Point(94, 161);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 45);
            textBox1.TabIndex = 1;
            textBox1.Text = "50";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 32F);
            button1.Location = new Point(12, 212);
            button1.Name = "button1";
            button1.Size = new Size(253, 110);
            button1.TabIndex = 2;
            button1.Text = "click";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 24F);
            button2.Location = new Point(12, 328);
            button2.Name = "button2";
            button2.Size = new Size(253, 60);
            button2.TabIndex = 3;
            button2.Text = "reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 167);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 4;
            label2.Text = "target : ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(277, 400);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Counter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label2;
    }
}
