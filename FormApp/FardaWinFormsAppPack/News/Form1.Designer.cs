namespace News
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
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            textBox1 = new TextBox();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            timer2 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 35);
            button1.TabIndex = 0;
            button1.Text = "خروج";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 404);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 45);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.Teal;
            label1.Font = new Font("Segoe UI", 21F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(670, 0);
            label1.Name = "label1";
            label1.Size = new Size(130, 45);
            label1.TabIndex = 0;
            label1.Text = "فردا نیوز";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Italic);
            label2.Location = new Point(12, 11);
            label2.Name = "label2";
            label2.Size = new Size(61, 25);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(289, 19);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(499, 23);
            textBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(289, 48);
            button2.Name = "button2";
            button2.Size = new Size(75, 35);
            button2.TabIndex = 4;
            button2.Text = "ثبت خبر";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.pic1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(12, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(657, 304);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.pic1;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(675, 94);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(113, 50);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.blocks;
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(675, 150);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(113, 50);
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // timer2
            // 
            timer2.Enabled = true;
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "news";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox1;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer2;
    }
}
