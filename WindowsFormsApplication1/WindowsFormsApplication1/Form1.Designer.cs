namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nyX_Theme1 = new CS_ClassLibraryTester.NYX_Theme();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.nyX_Button3 = new CS_ClassLibraryTester.NYX_Button();
            this.nyX_Button2 = new CS_ClassLibraryTester.NYX_Button();
            this.nyX_Button1 = new CS_ClassLibraryTester.NYX_Button();
            this.nyX_Theme1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nyX_Theme1
            // 
            this.nyX_Theme1.Animated = true;
            this.nyX_Theme1.BackColor = System.Drawing.SystemColors.Window;
            this.nyX_Theme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.nyX_Theme1.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.nyX_Theme1.Controls.Add(this.listBox1);
            this.nyX_Theme1.Controls.Add(this.nyX_Button3);
            this.nyX_Theme1.Controls.Add(this.nyX_Button2);
            this.nyX_Theme1.Controls.Add(this.nyX_Button1);
            this.nyX_Theme1.Cursor = System.Windows.Forms.Cursors.Default;
            this.nyX_Theme1.Customization = "";
            this.nyX_Theme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nyX_Theme1.Font = new System.Drawing.Font("Verdana", 9F);
            this.nyX_Theme1.Image = null;
            this.nyX_Theme1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nyX_Theme1.Location = new System.Drawing.Point(0, 0);
            this.nyX_Theme1.MaximumSize = new System.Drawing.Size(300, 300);
            this.nyX_Theme1.MinimumSize = new System.Drawing.Size(300, 300);
            this.nyX_Theme1.Movable = true;
            this.nyX_Theme1.Name = "nyX_Theme1";
            this.nyX_Theme1.NoRounding = false;
            this.nyX_Theme1.Sizable = false;
            this.nyX_Theme1.Size = new System.Drawing.Size(300, 300);
            this.nyX_Theme1.SmartBounds = true;
            this.nyX_Theme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.nyX_Theme1.TabIndex = 4;
            this.nyX_Theme1.Text = "Sesli Komut";
            this.nyX_Theme1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.nyX_Theme1.Transparent = false;
            this.nyX_Theme1.Click += new System.EventHandler(this.nyX_Theme1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Items.AddRange(new object[] {
            "change",
            "switch",
            "open d lab",
            "open d box",
            "open facebook",
            "open chrome",
            "open studio",
            "shutdown",
            "cancel shutdown",
            "close",
            "show",
            "hide",
            "exit"});
            this.listBox1.Location = new System.Drawing.Point(87, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 88);
            this.listBox1.TabIndex = 5;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // nyX_Button3
            // 
            this.nyX_Button3.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.nyX_Button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nyX_Button3.Customization = "";
            this.nyX_Button3.Font = new System.Drawing.Font("Arial", 8F);
            this.nyX_Button3.Image = null;
            this.nyX_Button3.Location = new System.Drawing.Point(278, 3);
            this.nyX_Button3.Name = "nyX_Button3";
            this.nyX_Button3.NoRounding = false;
            this.nyX_Button3.Size = new System.Drawing.Size(19, 20);
            this.nyX_Button3.TabIndex = 4;
            this.nyX_Button3.Text = "X";
            this.nyX_Button3.Transparent = false;
            this.nyX_Button3.Click += new System.EventHandler(this.nyX_Button3_Click);
            // 
            // nyX_Button2
            // 
            this.nyX_Button2.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.nyX_Button2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.nyX_Button2.Customization = "";
            this.nyX_Button2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nyX_Button2.Image = null;
            this.nyX_Button2.Location = new System.Drawing.Point(173, 153);
            this.nyX_Button2.Name = "nyX_Button2";
            this.nyX_Button2.NoRounding = false;
            this.nyX_Button2.Size = new System.Drawing.Size(103, 41);
            this.nyX_Button2.TabIndex = 3;
            this.nyX_Button2.Text = "Durdur";
            this.nyX_Button2.Transparent = false;
            this.nyX_Button2.Click += new System.EventHandler(this.nyX_Button2_Click);
            // 
            // nyX_Button1
            // 
            this.nyX_Button1.Colors = new CS_ClassLibraryTester.Bloom[0];
            this.nyX_Button1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.nyX_Button1.Customization = "";
            this.nyX_Button1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nyX_Button1.Image = null;
            this.nyX_Button1.Location = new System.Drawing.Point(28, 153);
            this.nyX_Button1.Name = "nyX_Button1";
            this.nyX_Button1.NoRounding = false;
            this.nyX_Button1.Size = new System.Drawing.Size(103, 41);
            this.nyX_Button1.TabIndex = 2;
            this.nyX_Button1.Text = "Başlat";
            this.nyX_Button1.Transparent = false;
            this.nyX_Button1.Click += new System.EventHandler(this.nyX_Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.nyX_Theme1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sesli Komut";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.nyX_Theme1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CS_ClassLibraryTester.NYX_Button nyX_Button1;
        private CS_ClassLibraryTester.NYX_Button nyX_Button2;
        private CS_ClassLibraryTester.NYX_Theme nyX_Theme1;
        private CS_ClassLibraryTester.NYX_Button nyX_Button3;
        private System.Windows.Forms.ListBox listBox1;
    }
}

