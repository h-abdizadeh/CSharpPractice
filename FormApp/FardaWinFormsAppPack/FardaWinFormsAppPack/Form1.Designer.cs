namespace FardaWinFormsAppPack
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(0, 0, 64);
            label1.Font = new Font("Segoe UI", 54F, FontStyle.Bold);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(8, 7);
            label1.Name = "label1";
            label1.Size = new Size(269, 104);
            label1.TabIndex = 0;
            label1.Text = "0";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 36F);
            button1.ForeColor = Color.FromArgb(0, 64, 64);
            button1.Location = new Point(11, 181);
            button1.Name = "button1";
            button1.Size = new Size(265, 81);
            button1.TabIndex = 1;
            button1.Text = "up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 24F);
            button2.ForeColor = Color.FromArgb(0, 64, 64);
            button2.Location = new Point(10, 268);
            button2.Name = "button2";
            button2.Size = new Size(265, 81);
            button2.TabIndex = 2;
            button2.Text = "down";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(89, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 34);
            textBox1.TabIndex = 3;
            textBox1.Text = "20";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(284, 361);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "step counter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
    }
}
