namespace WareHouse
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
            menuStrip1 = new MenuStrip();
            ابزارToolStripMenuItem = new ToolStripMenuItem();
            ثبتکالاToolStripMenuItem = new ToolStripMenuItem();
            ثبتوویرایشToolStripMenuItem = new ToolStripMenuItem();
            حذفToolStripMenuItem = new ToolStripMenuItem();
            ثبتگروهToolStripMenuItem = new ToolStripMenuItem();
            دربارهبرنامهToolStripMenuItem = new ToolStripMenuItem();
            دربارهبرنامهToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ابزارToolStripMenuItem, دربارهبرنامهToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.Yes;
            menuStrip1.Size = new Size(850, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // ابزارToolStripMenuItem
            // 
            ابزارToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ثبتکالاToolStripMenuItem, ثبتگروهToolStripMenuItem });
            ابزارToolStripMenuItem.Name = "ابزارToolStripMenuItem";
            ابزارToolStripMenuItem.Size = new Size(47, 24);
            ابزارToolStripMenuItem.Text = "ابزار";
            // 
            // ثبتکالاToolStripMenuItem
            // 
            ثبتکالاToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ثبتوویرایشToolStripMenuItem, حذفToolStripMenuItem });
            ثبتکالاToolStripMenuItem.Name = "ثبتکالاToolStripMenuItem";
            ثبتکالاToolStripMenuItem.Size = new Size(224, 26);
            ثبتکالاToolStripMenuItem.Text = "مدیریت کالا";
            // 
            // ثبتوویرایشToolStripMenuItem
            // 
            ثبتوویرایشToolStripMenuItem.Name = "ثبتوویرایشToolStripMenuItem";
            ثبتوویرایشToolStripMenuItem.Size = new Size(224, 26);
            ثبتوویرایشToolStripMenuItem.Text = "ثبت و ویرایش";
            ثبتوویرایشToolStripMenuItem.Click += ثبتوویرایشToolStripMenuItem_Click;
            // 
            // حذفToolStripMenuItem
            // 
            حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            حذفToolStripMenuItem.Size = new Size(224, 26);
            حذفToolStripMenuItem.Text = "حذف";
            // 
            // ثبتگروهToolStripMenuItem
            // 
            ثبتگروهToolStripMenuItem.Name = "ثبتگروهToolStripMenuItem";
            ثبتگروهToolStripMenuItem.Size = new Size(224, 26);
            ثبتگروهToolStripMenuItem.Text = "ثبت گروه";
            // 
            // دربارهبرنامهToolStripMenuItem
            // 
            دربارهبرنامهToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { دربارهبرنامهToolStripMenuItem1 });
            دربارهبرنامهToolStripMenuItem.Name = "دربارهبرنامهToolStripMenuItem";
            دربارهبرنامهToolStripMenuItem.Size = new Size(60, 24);
            دربارهبرنامهToolStripMenuItem.Text = "راهنما";
            // 
            // دربارهبرنامهToolStripMenuItem1
            // 
            دربارهبرنامهToolStripMenuItem1.Name = "دربارهبرنامهToolStripMenuItem1";
            دربارهبرنامهToolStripMenuItem1.Size = new Size(168, 26);
            دربارهبرنامهToolStripMenuItem1.Text = "درباره برنامه";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 608);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "برنامه مدیریت انبار کالا";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ابزارToolStripMenuItem;
        private ToolStripMenuItem ثبتکالاToolStripMenuItem;
        private ToolStripMenuItem ثبتگروهToolStripMenuItem;
        private ToolStripMenuItem دربارهبرنامهToolStripMenuItem;
        private ToolStripMenuItem دربارهبرنامهToolStripMenuItem1;
        private ToolStripMenuItem ثبتوویرایشToolStripMenuItem;
        private ToolStripMenuItem حذفToolStripMenuItem;
    }
}