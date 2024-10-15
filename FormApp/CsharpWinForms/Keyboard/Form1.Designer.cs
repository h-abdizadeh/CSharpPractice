namespace Keyboard
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
            btnWhite1 = new Button();
            btnWhite2 = new Button();
            btnBlack1 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            SuspendLayout();
            // 
            // btnWhite1
            // 
            btnWhite1.BackColor = Color.White;
            btnWhite1.Location = new Point(0, -1);
            btnWhite1.Name = "btnWhite1";
            btnWhite1.Size = new Size(50, 213);
            btnWhite1.TabIndex = 0;
            btnWhite1.UseVisualStyleBackColor = false;
            // 
            // btnWhite2
            // 
            btnWhite2.BackColor = Color.White;
            btnWhite2.Location = new Point(49, -1);
            btnWhite2.Name = "btnWhite2";
            btnWhite2.Size = new Size(50, 213);
            btnWhite2.TabIndex = 1;
            btnWhite2.UseVisualStyleBackColor = false;
            // 
            // btnBlack1
            // 
            btnBlack1.BackColor = Color.Black;
            btnBlack1.Location = new Point(29, -1);
            btnBlack1.Name = "btnBlack1";
            btnBlack1.Size = new Size(40, 150);
            btnBlack1.TabIndex = 2;
            btnBlack1.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Location = new Point(126, -1);
            button1.Name = "button1";
            button1.Size = new Size(40, 150);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Location = new Point(146, -1);
            button2.Name = "button2";
            button2.Size = new Size(50, 213);
            button2.TabIndex = 4;
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Location = new Point(97, -1);
            button3.Name = "button3";
            button3.Size = new Size(50, 213);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Black;
            button4.Location = new Point(222, -1);
            button4.Name = "button4";
            button4.Size = new Size(40, 150);
            button4.TabIndex = 8;
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Location = new Point(242, -1);
            button5.Name = "button5";
            button5.Size = new Size(50, 213);
            button5.TabIndex = 7;
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.White;
            button6.Location = new Point(193, -1);
            button6.Name = "button6";
            button6.Size = new Size(50, 213);
            button6.TabIndex = 6;
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Black;
            button7.Location = new Point(318, 0);
            button7.Name = "button7";
            button7.Size = new Size(40, 150);
            button7.TabIndex = 11;
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.Location = new Point(338, 0);
            button8.Name = "button8";
            button8.Size = new Size(50, 213);
            button8.TabIndex = 10;
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.White;
            button9.Location = new Point(289, 0);
            button9.Name = "button9";
            button9.Size = new Size(50, 213);
            button9.TabIndex = 9;
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = Color.Black;
            button10.Location = new Point(414, 0);
            button10.Name = "button10";
            button10.Size = new Size(40, 150);
            button10.TabIndex = 14;
            button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.White;
            button11.Location = new Point(434, 0);
            button11.Name = "button11";
            button11.Size = new Size(50, 213);
            button11.TabIndex = 13;
            button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = Color.White;
            button12.Location = new Point(385, 0);
            button12.Name = "button12";
            button12.Size = new Size(50, 213);
            button12.TabIndex = 12;
            button12.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 211);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(btnBlack1);
            Controls.Add(btnWhite2);
            Controls.Add(btnWhite1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form1";
            Text = "keyboard";
            KeyDown += Form1_KeyDown;
            KeyPress += Form1_KeyPress;
            KeyUp += Form1_KeyUp;
            ResumeLayout(false);
        }

        #endregion

        private Button btnWhite1;
        private Button btnWhite2;
        private Button btnBlack1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
    }
}