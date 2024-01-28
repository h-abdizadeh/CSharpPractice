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
            labelScreen = new Label();
            button0 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            buttonFloat = new Button();
            buttonResult = new Button();
            buttonSum = new Button();
            buttonMinus = new Button();
            buttonDiv = new Button();
            buttonMult = new Button();
            SuspendLayout();
            // 
            // labelScreen
            // 
            labelScreen.BackColor = Color.White;
            labelScreen.BorderStyle = BorderStyle.FixedSingle;
            labelScreen.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            labelScreen.ForeColor = Color.FromArgb(64, 64, 64);
            labelScreen.Location = new Point(12, 9);
            labelScreen.Name = "labelScreen";
            labelScreen.Size = new Size(318, 87);
            labelScreen.TabIndex = 0;
            labelScreen.Text = "0";
            // 
            // button0
            // 
            button0.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button0.ForeColor = Color.Teal;
            button0.Location = new Point(94, 366);
            button0.Name = "button0";
            button0.Size = new Size(75, 75);
            button0.TabIndex = 1;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Teal;
            button1.Location = new Point(13, 123);
            button1.Name = "button1";
            button1.Size = new Size(75, 75);
            button1.TabIndex = 2;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Teal;
            button2.Location = new Point(94, 123);
            button2.Name = "button2";
            button2.Size = new Size(75, 75);
            button2.TabIndex = 3;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Teal;
            button3.Location = new Point(175, 123);
            button3.Name = "button3";
            button3.Size = new Size(75, 75);
            button3.TabIndex = 4;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.Teal;
            button4.Location = new Point(13, 204);
            button4.Name = "button4";
            button4.Size = new Size(75, 75);
            button4.TabIndex = 5;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.Teal;
            button5.Location = new Point(94, 204);
            button5.Name = "button5";
            button5.Size = new Size(75, 75);
            button5.TabIndex = 6;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.Teal;
            button6.Location = new Point(175, 204);
            button6.Name = "button6";
            button6.Size = new Size(75, 75);
            button6.TabIndex = 7;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.Teal;
            button7.Location = new Point(13, 285);
            button7.Name = "button7";
            button7.Size = new Size(75, 75);
            button7.TabIndex = 8;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.Teal;
            button8.Location = new Point(94, 285);
            button8.Name = "button8";
            button8.Size = new Size(75, 75);
            button8.TabIndex = 9;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = Color.Teal;
            button9.Location = new Point(175, 285);
            button9.Name = "button9";
            button9.Size = new Size(75, 75);
            button9.TabIndex = 10;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            // 
            // buttonFloat
            // 
            buttonFloat.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFloat.ForeColor = Color.Teal;
            buttonFloat.Location = new Point(13, 366);
            buttonFloat.Name = "buttonFloat";
            buttonFloat.Size = new Size(75, 75);
            buttonFloat.TabIndex = 11;
            buttonFloat.Text = ".";
            buttonFloat.UseVisualStyleBackColor = true;
            // 
            // buttonResult
            // 
            buttonResult.BackColor = Color.FromArgb(255, 128, 0);
            buttonResult.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            buttonResult.ForeColor = Color.White;
            buttonResult.Location = new Point(175, 366);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(75, 75);
            buttonResult.TabIndex = 12;
            buttonResult.Text = "=";
            buttonResult.TextAlign = ContentAlignment.TopCenter;
            buttonResult.UseVisualStyleBackColor = false;
            buttonResult.Click += buttonResult_Click;
            // 
            // buttonSum
            // 
            buttonSum.BackColor = Color.Teal;
            buttonSum.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSum.ForeColor = Color.White;
            buttonSum.Location = new Point(256, 123);
            buttonSum.Name = "buttonSum";
            buttonSum.Size = new Size(75, 75);
            buttonSum.TabIndex = 13;
            buttonSum.Text = "+";
            buttonSum.TextAlign = ContentAlignment.TopCenter;
            buttonSum.UseVisualStyleBackColor = false;
            buttonSum.Click += buttonSum_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.BackColor = Color.Teal;
            buttonMinus.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMinus.ForeColor = Color.White;
            buttonMinus.Location = new Point(256, 204);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(75, 75);
            buttonMinus.TabIndex = 14;
            buttonMinus.Text = "-";
            buttonMinus.TextAlign = ContentAlignment.TopCenter;
            buttonMinus.UseVisualStyleBackColor = false;
            // 
            // buttonDiv
            // 
            buttonDiv.BackColor = Color.Teal;
            buttonDiv.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDiv.ForeColor = Color.White;
            buttonDiv.Location = new Point(256, 285);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(75, 75);
            buttonDiv.TabIndex = 15;
            buttonDiv.Text = "÷";
            buttonDiv.TextAlign = ContentAlignment.TopCenter;
            buttonDiv.UseVisualStyleBackColor = false;
            // 
            // buttonMult
            // 
            buttonMult.BackColor = Color.Teal;
            buttonMult.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            buttonMult.ForeColor = Color.White;
            buttonMult.Location = new Point(255, 366);
            buttonMult.Name = "buttonMult";
            buttonMult.Size = new Size(75, 75);
            buttonMult.TabIndex = 16;
            buttonMult.Text = "×";
            buttonMult.TextAlign = ContentAlignment.TopCenter;
            buttonMult.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 453);
            Controls.Add(buttonMult);
            Controls.Add(buttonDiv);
            Controls.Add(buttonMinus);
            Controls.Add(buttonSum);
            Controls.Add(buttonResult);
            Controls.Add(buttonFloat);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button0);
            Controls.Add(labelScreen);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Mini Calculator";
            ResumeLayout(false);
        }

        #endregion

        private Label labelScreen;
        private Button button0;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonFloat;
        private Button buttonResult;
        private Button buttonSum;
        private Button buttonMinus;
        private Button buttonDiv;
        private Button buttonMult;
    }
}