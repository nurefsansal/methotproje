namespace CumleGirisiUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            // Kullanýcýnýn girdiði cümleyi al
            string girilenCumle = txtCumle.Text;

            // Label'a girilen cümleyi yaz
            lblSonuc.Text = "Girilen Cümle: " + girilenCumle;
        }

        private void btnBuyukHarf_Click(object sender, EventArgs e)
        {
            // Kullanýcýnýn girdiði cümleyi al
            string girilenCumle = txtCumle.Text;

            // Girdiði cümleyi büyük harfe çevir
            string buyukHarfCumle = GenisletilmisMetotlar.BuyukHarfYap(girilenCumle);

            // Label'a büyük harf yapýlmýþ cümleyi yaz
            lblSonuc.Text = "Büyük Harf Cümle: " + buyukHarfCumle;
        }

        private void btnSesliHarfSayisi_Click(object sender, EventArgs e)
        {
            // Kullanýcýnýn girdiði cümleyi al
            string girilenCumle = txtCumle.Text;

            // Girdiði cümledeki sesli harf sayýsýný bul
            int sesliHarfSayisi = GenisletilmisMetotlar.SesliHarfSayisiBul(girilenCumle);

            // Label'a sesli harf sayýsýný yaz
            lblSonuc.Text = "Sesli Harf Sayýsý: " + sesliHarfSayisi;
        }

        private void btnTersYaz_Click(object sender, EventArgs e)
        {
            // Kullanýcýnýn girdiði cümleyi al
            string girilenCumle = txtCumle.Text;

            // Girdiði cümleyi tersine çevir
            string tersCumle = GenisletilmisMetotlar.TersYaz(girilenCumle);

            // Label'a ters çevrilmiþ cümleyi yaz
            lblSonuc.Text = "Ters Çevrilmiþ Cümle: " + tersCumle;
        }
        public static class GenisletilmisMetotlar
        {
            public static string BuyukHarfYap(string cumle)
            {
                return cumle.ToUpper();
            }

            public static int SesliHarfSayisiBul(string cumle)
            {
                // Sesli harfleri belirle
                char[] sesliHarfler = { 'a', 'e', 'ý', 'i', 'o', 'ö', 'u', 'ü' };

                // Cümlenin sesli harf sayýsýný bul
                int sesliHarfSayisi = cumle.Count(harf => sesliHarfler.Contains(char.ToLower(harf)));

                return sesliHarfSayisi;
            }

            public static string TersYaz(string cumle)
            {
                char[] charArray = cumle.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
        }
    }
}
