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
            // Kullan�c�n�n girdi�i c�mleyi al
            string girilenCumle = txtCumle.Text;

            // Label'a girilen c�mleyi yaz
            lblSonuc.Text = "Girilen C�mle: " + girilenCumle;
        }

        private void btnBuyukHarf_Click(object sender, EventArgs e)
        {
            // Kullan�c�n�n girdi�i c�mleyi al
            string girilenCumle = txtCumle.Text;

            // Girdi�i c�mleyi b�y�k harfe �evir
            string buyukHarfCumle = GenisletilmisMetotlar.BuyukHarfYap(girilenCumle);

            // Label'a b�y�k harf yap�lm�� c�mleyi yaz
            lblSonuc.Text = "B�y�k Harf C�mle: " + buyukHarfCumle;
        }

        private void btnSesliHarfSayisi_Click(object sender, EventArgs e)
        {
            // Kullan�c�n�n girdi�i c�mleyi al
            string girilenCumle = txtCumle.Text;

            // Girdi�i c�mledeki sesli harf say�s�n� bul
            int sesliHarfSayisi = GenisletilmisMetotlar.SesliHarfSayisiBul(girilenCumle);

            // Label'a sesli harf say�s�n� yaz
            lblSonuc.Text = "Sesli Harf Say�s�: " + sesliHarfSayisi;
        }

        private void btnTersYaz_Click(object sender, EventArgs e)
        {
            // Kullan�c�n�n girdi�i c�mleyi al
            string girilenCumle = txtCumle.Text;

            // Girdi�i c�mleyi tersine �evir
            string tersCumle = GenisletilmisMetotlar.TersYaz(girilenCumle);

            // Label'a ters �evrilmi� c�mleyi yaz
            lblSonuc.Text = "Ters �evrilmi� C�mle: " + tersCumle;
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
                char[] sesliHarfler = { 'a', 'e', '�', 'i', 'o', '�', 'u', '�' };

                // C�mlenin sesli harf say�s�n� bul
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
