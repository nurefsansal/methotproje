namespace CumleGirisiUygulamasi
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
            txtCumle = new TextBox();
            btnOnayla = new Button();
            btnBuyukHarf = new Button();
            btnSesliHarfSayisi = new Button();
            lblSonuc = new Label();
            btnTersYaz = new Button();
            SuspendLayout();
            // 
            // txtCumle
            // 
            txtCumle.Location = new Point(37, 63);
            txtCumle.Multiline = true;
            txtCumle.Name = "txtCumle";
            txtCumle.Size = new Size(1062, 400);
            txtCumle.TabIndex = 0;
            txtCumle.Text = "Cümle ya da kelime giriniz";
            // 
            // btnOnayla
            // 
            btnOnayla.Location = new Point(37, 469);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(167, 72);
            btnOnayla.TabIndex = 1;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = true;
            btnOnayla.Click += btnOnayla_Click;
            // 
            // btnBuyukHarf
            // 
            btnBuyukHarf.Location = new Point(339, 469);
            btnBuyukHarf.Name = "btnBuyukHarf";
            btnBuyukHarf.Size = new Size(164, 72);
            btnBuyukHarf.TabIndex = 2;
            btnBuyukHarf.Text = "Büyük Harf";
            btnBuyukHarf.UseVisualStyleBackColor = true;
            btnBuyukHarf.Click += btnBuyukHarf_Click;
            // 
            // btnSesliHarfSayisi
            // 
            btnSesliHarfSayisi.Location = new Point(639, 469);
            btnSesliHarfSayisi.Name = "btnSesliHarfSayisi";
            btnSesliHarfSayisi.Size = new Size(172, 72);
            btnSesliHarfSayisi.TabIndex = 3;
            btnSesliHarfSayisi.Text = " Sesli Harf Sayısı";
            btnSesliHarfSayisi.UseVisualStyleBackColor = true;
            btnSesliHarfSayisi.Click += btnSesliHarfSayisi_Click;
            // 
            // lblSonuc
            // 
            lblSonuc.AutoSize = true;
            lblSonuc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSonuc.Location = new Point(163, 607);
            lblSonuc.Name = "lblSonuc";
            lblSonuc.Size = new Size(106, 32);
            lblSonuc.TabIndex = 4;
            lblSonuc.Text = "lblSonuc";
            // 
            // btnTersYaz
            // 
            btnTersYaz.Location = new Point(939, 469);
            btnTersYaz.Name = "btnTersYaz";
            btnTersYaz.Size = new Size(160, 72);
            btnTersYaz.TabIndex = 5;
            btnTersYaz.Text = "Ters Yaz";
            btnTersYaz.UseVisualStyleBackColor = true;
            btnTersYaz.Click += btnTersYaz_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1647, 986);
            Controls.Add(btnTersYaz);
            Controls.Add(lblSonuc);
            Controls.Add(btnSesliHarfSayisi);
            Controls.Add(btnBuyukHarf);
            Controls.Add(btnOnayla);
            Controls.Add(txtCumle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCumle;
        private Button btnOnayla;
        private Button btnBuyukHarf;
        private Button btnSesliHarfSayisi;
        private Label lblSonuc;
        private Button btnTersYaz;
    }
}
