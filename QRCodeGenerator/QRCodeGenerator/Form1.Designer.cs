using Bunifu.Framework.UI;

namespace QRCodeGenerator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxUnesi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnObrisi = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnGenerisi = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDodaj = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ddlStringovi = new Bunifu.Framework.UI.BunifuDropdown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBoxPrikazi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 45);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QRCodeGenerator.Properties.Resources.LogoRefacotrV2;
            this.pictureBox1.Location = new System.Drawing.Point(303, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(66)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 43);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.panel3.Controls.Add(this.textBoxUnesi);
            this.panel3.Controls.Add(this.btnObrisi);
            this.panel3.Controls.Add(this.btnGenerisi);
            this.panel3.Controls.Add(this.btnDodaj);
            this.panel3.Controls.Add(this.ddlStringovi);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(394, 273);
            this.panel3.TabIndex = 2;
            // 
            // textBoxUnesi
            // 
            this.textBoxUnesi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxUnesi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxUnesi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.textBoxUnesi.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxUnesi.HintText = "";
            this.textBoxUnesi.isPassword = false;
            this.textBoxUnesi.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(66)))));
            this.textBoxUnesi.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(66)))));
            this.textBoxUnesi.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(66)))));
            this.textBoxUnesi.LineThickness = 3;
            this.textBoxUnesi.Location = new System.Drawing.Point(69, 93);
            this.textBoxUnesi.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUnesi.Name = "textBoxUnesi";
            this.textBoxUnesi.Size = new System.Drawing.Size(220, 33);
            this.textBoxUnesi.TabIndex = 6;
            this.textBoxUnesi.Text = "Unesite string za barcode!";
            this.textBoxUnesi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxUnesi.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBoxUnesi.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // btnObrisi
            // 
            this.btnObrisi.ActiveBorderThickness = 1;
            this.btnObrisi.ActiveCornerRadius = 20;
            this.btnObrisi.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(66)))));
            this.btnObrisi.ActiveForecolor = System.Drawing.Color.White;
            this.btnObrisi.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(66)))));
            this.btnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.btnObrisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnObrisi.BackgroundImage")));
            this.btnObrisi.ButtonText = "Obrisi";
            this.btnObrisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObrisi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(66)))));
            this.btnObrisi.IdleBorderThickness = 1;
            this.btnObrisi.IdleCornerRadius = 20;
            this.btnObrisi.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.btnObrisi.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(66)))));
            this.btnObrisi.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(66)))));
            this.btnObrisi.Location = new System.Drawing.Point(112, 200);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(5);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(117, 41);
            this.btnObrisi.TabIndex = 5;
            this.btnObrisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnGenerisi
            // 
            this.btnGenerisi.ActiveBorderThickness = 1;
            this.btnGenerisi.ActiveCornerRadius = 20;
            this.btnGenerisi.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(66)))));
            this.btnGenerisi.ActiveForecolor = System.Drawing.Color.White;
            this.btnGenerisi.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(66)))));
            this.btnGenerisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.btnGenerisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenerisi.BackgroundImage")));
            this.btnGenerisi.ButtonText = "Generisi kod";
            this.btnGenerisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerisi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerisi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(66)))));
            this.btnGenerisi.IdleBorderThickness = 1;
            this.btnGenerisi.IdleCornerRadius = 20;
            this.btnGenerisi.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.btnGenerisi.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(66)))));
            this.btnGenerisi.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(66)))));
            this.btnGenerisi.Location = new System.Drawing.Point(210, 149);
            this.btnGenerisi.Margin = new System.Windows.Forms.Padding(5);
            this.btnGenerisi.Name = "btnGenerisi";
            this.btnGenerisi.Size = new System.Drawing.Size(117, 41);
            this.btnGenerisi.TabIndex = 4;
            this.btnGenerisi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGenerisi.Click += new System.EventHandler(this.btnGenerisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.ActiveBorderThickness = 1;
            this.btnDodaj.ActiveCornerRadius = 20;
            this.btnDodaj.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(66)))));
            this.btnDodaj.ActiveForecolor = System.Drawing.Color.White;
            this.btnDodaj.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(66)))));
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.btnDodaj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDodaj.BackgroundImage")));
            this.btnDodaj.ButtonText = "Dodaj";
            this.btnDodaj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDodaj.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(66)))));
            this.btnDodaj.IdleBorderThickness = 1;
            this.btnDodaj.IdleCornerRadius = 20;
            this.btnDodaj.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.btnDodaj.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(66)))));
            this.btnDodaj.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(66)))));
            this.btnDodaj.Location = new System.Drawing.Point(34, 149);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(5);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(117, 41);
            this.btnDodaj.TabIndex = 3;
            this.btnDodaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // ddlStringovi
            // 
            this.ddlStringovi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(66)))));
            this.ddlStringovi.BorderRadius = 3;
            this.ddlStringovi.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ddlStringovi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(66)))));
            this.ddlStringovi.Items = new string[0];
            this.ddlStringovi.Location = new System.Drawing.Point(69, 27);
            this.ddlStringovi.Name = "ddlStringovi";
            this.ddlStringovi.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ddlStringovi.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.ddlStringovi.selectedIndex = -1;
            this.ddlStringovi.Size = new System.Drawing.Size(220, 35);
            this.ddlStringovi.TabIndex = 0;
            this.ddlStringovi.onItemSelected += new System.EventHandler(this.ddlStringovi_onItemSelected);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(36)))));
            this.panel4.Controls.Add(this.textBoxPrikazi);
            this.panel4.Controls.Add(this.picBox);
            this.panel4.Location = new System.Drawing.Point(391, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(393, 273);
            this.panel4.TabIndex = 3;
            // 
            // textBoxPrikazi
            // 
            this.textBoxPrikazi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPrikazi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.textBoxPrikazi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.textBoxPrikazi.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxPrikazi.HintText = "";
            this.textBoxPrikazi.isPassword = false;
            this.textBoxPrikazi.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(66)))));
            this.textBoxPrikazi.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(66)))));
            this.textBoxPrikazi.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(79)))), ((int)(((byte)(66)))));
            this.textBoxPrikazi.LineThickness = 3;
            this.textBoxPrikazi.Location = new System.Drawing.Point(90, 157);
            this.textBoxPrikazi.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrikazi.Name = "textBoxPrikazi";
            this.textBoxPrikazi.Size = new System.Drawing.Size(220, 33);
            this.textBoxPrikazi.TabIndex = 7;
            this.textBoxPrikazi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(90, 16);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(220, 121);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private BunifuThinButton2 btnObrisi;
        private BunifuThinButton2 btnGenerisi;
        private BunifuThinButton2 btnDodaj;
        private BunifuDropdown ddlStringovi;
        private BunifuMaterialTextbox textBoxUnesi;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picBox;
        private BunifuMaterialTextbox textBoxPrikazi;
    }
}

