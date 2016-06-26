namespace HabboPicturesearcher
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.sKoreLabel1 = new Sulakore.Components.SKoreLabel();
            this.sKoreButton1 = new Sulakore.Components.SKoreButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.HotelListCB = new System.Windows.Forms.ComboBox();
            this.sKoreLabel2 = new Sulakore.Components.SKoreLabel();
            this.HabboPicture2 = new System.Windows.Forms.PictureBox();
            this.HabboPicture1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HabboPicture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HabboPicture1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Location = new System.Drawing.Point(12, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(691, 1);
            this.panel1.TabIndex = 11;
            // 
            // sKoreLabel1
            // 
            this.sKoreLabel1.AutoSize = true;
            this.sKoreLabel1.Location = new System.Drawing.Point(199, 358);
            this.sKoreLabel1.Name = "sKoreLabel1";
            this.sKoreLabel1.Size = new System.Drawing.Size(93, 13);
            this.sKoreLabel1.TabIndex = 10;
            this.sKoreLabel1.Text = "Habbo Username:";
            // 
            // sKoreButton1
            // 
            this.sKoreButton1.BackColor = System.Drawing.Color.Transparent;
            this.sKoreButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.sKoreButton1.Location = new System.Drawing.Point(434, 371);
            this.sKoreButton1.Name = "sKoreButton1";
            this.sKoreButton1.Size = new System.Drawing.Size(100, 22);
            this.sKoreButton1.TabIndex = 9;
            this.sKoreButton1.Text = "Search pictures";
            this.sKoreButton1.Click += new System.EventHandler(this.sKoreButton1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(202, 374);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 8;
            // 
            // HotelListCB
            // 
            this.HotelListCB.FormattingEnabled = true;
            this.HotelListCB.Items.AddRange(new object[] {
            "com",
            "com.br",
            "com.tr",
            "fi",
            "es",
            "de",
            "fr",
            "nl",
            "it"});
            this.HotelListCB.Location = new System.Drawing.Point(356, 373);
            this.HotelListCB.Name = "HotelListCB";
            this.HotelListCB.Size = new System.Drawing.Size(72, 21);
            this.HotelListCB.TabIndex = 12;
            this.HotelListCB.Tag = "";
            this.HotelListCB.Text = "com";
            // 
            // sKoreLabel2
            // 
            this.sKoreLabel2.AutoSize = true;
            this.sKoreLabel2.Location = new System.Drawing.Point(353, 357);
            this.sKoreLabel2.Name = "sKoreLabel2";
            this.sKoreLabel2.Size = new System.Drawing.Size(35, 13);
            this.sKoreLabel2.TabIndex = 13;
            this.sKoreLabel2.Text = "Hotel:";
            // 
            // HabboPicture2
            // 
            this.HabboPicture2.BackgroundImage = global::HabboPicturesearcher.Properties.Resources.ahshasdfhasdf;
            this.HabboPicture2.InitialImage = global::HabboPicturesearcher.Properties.Resources.loadingimg;
            this.HabboPicture2.Location = new System.Drawing.Point(362, 12);
            this.HabboPicture2.Name = "HabboPicture2";
            this.HabboPicture2.Size = new System.Drawing.Size(320, 320);
            this.HabboPicture2.TabIndex = 4;
            this.HabboPicture2.TabStop = false;
            // 
            // HabboPicture1
            // 
            this.HabboPicture1.BackgroundImage = global::HabboPicturesearcher.Properties.Resources.ahshasdfhasdf;
            this.HabboPicture1.InitialImage = global::HabboPicturesearcher.Properties.Resources.loadingimg;
            this.HabboPicture1.Location = new System.Drawing.Point(12, 12);
            this.HabboPicture1.Name = "HabboPicture1";
            this.HabboPicture1.Size = new System.Drawing.Size(320, 320);
            this.HabboPicture1.TabIndex = 3;
            this.HabboPicture1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(690, 418);
            this.Controls.Add(this.sKoreLabel2);
            this.Controls.Add(this.HotelListCB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sKoreLabel1);
            this.Controls.Add(this.sKoreButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.HabboPicture2);
            this.Controls.Add(this.HabboPicture1);
            this.Name = "Form1";
            this.Text = "Habbo picture searcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HabboPicture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HabboPicture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox HabboPicture1;
        private System.Windows.Forms.PictureBox HabboPicture2;
        private System.Windows.Forms.Panel panel1;
        private Sulakore.Components.SKoreLabel sKoreLabel1;
        private Sulakore.Components.SKoreButton sKoreButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox HotelListCB;
        private Sulakore.Components.SKoreLabel sKoreLabel2;
    }
}

