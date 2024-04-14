namespace WareHouse
{
    partial class AddProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxGroups = new ComboBox();
            textName = new TextBox();
            textInv = new TextBox();
            textDes = new TextBox();
            pictureProduct = new PictureBox();
            btnChoose = new Button();
            btnSubmit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureProduct).BeginInit();
            SuspendLayout();
            // 
            // comboBoxGroups
            // 
            comboBoxGroups.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxGroups.FormattingEnabled = true;
            comboBoxGroups.Location = new Point(165, 12);
            comboBoxGroups.Name = "comboBoxGroups";
            comboBoxGroups.RightToLeft = RightToLeft.Yes;
            comboBoxGroups.Size = new Size(243, 36);
            comboBoxGroups.TabIndex = 0;
            comboBoxGroups.Text = "انتخاب گروه";
            // 
            // textName
            // 
            textName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textName.Location = new Point(165, 54);
            textName.Name = "textName";
            textName.PlaceholderText = "عنوان کالا";
            textName.RightToLeft = RightToLeft.Yes;
            textName.Size = new Size(243, 34);
            textName.TabIndex = 1;
            // 
            // textInv
            // 
            textInv.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textInv.Location = new Point(165, 94);
            textInv.Name = "textInv";
            textInv.PlaceholderText = "موجودی";
            textInv.RightToLeft = RightToLeft.Yes;
            textInv.Size = new Size(243, 34);
            textInv.TabIndex = 2;
            // 
            // textDes
            // 
            textDes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textDes.Location = new Point(12, 134);
            textDes.Multiline = true;
            textDes.Name = "textDes";
            textDes.PlaceholderText = "توضیحات";
            textDes.RightToLeft = RightToLeft.Yes;
            textDes.Size = new Size(396, 188);
            textDes.TabIndex = 3;
            // 
            // pictureProduct
            // 
            pictureProduct.BackColor = Color.Silver;
            pictureProduct.Location = new Point(165, 328);
            pictureProduct.Name = "pictureProduct";
            pictureProduct.Size = new Size(243, 225);
            pictureProduct.TabIndex = 4;
            pictureProduct.TabStop = false;
            // 
            // btnChoose
            // 
            btnChoose.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            btnChoose.Location = new Point(311, 331);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(94, 29);
            btnChoose.TabIndex = 5;
            btnChoose.Text = "انتخاب تصویر";
            btnChoose.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnSubmit.Location = new Point(12, 559);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(397, 69);
            btnSubmit.TabIndex = 6;
            btnSubmit.Text = "ثبت کالا";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 636);
            Controls.Add(btnSubmit);
            Controls.Add(btnChoose);
            Controls.Add(pictureProduct);
            Controls.Add(textDes);
            Controls.Add(textInv);
            Controls.Add(textName);
            Controls.Add(comboBoxGroups);
            Name = "AddProductForm";
            Text = "Add Product";
            Load += AddProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxGroups;
        private TextBox textName;
        private TextBox textInv;
        private TextBox textDes;
        private PictureBox pictureProduct;
        private Button btnChoose;
        private Button btnSubmit;
    }
}