namespace AppConvertitore
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            //Inizializza i componenti grafici
            InitializeComponent();
        }

        private void btnConverti_Clicked(object sender, EventArgs e)
        {
            string valoreImporto = entConversione.Text;

            double franchi = Convert.ToDouble(valoreImporto);

            double euro = franchi * 1.07;

            string risultato = Convert.ToString(euro);

            lblRisultato.Text = "RIsultato = " + risultato;


        }
    }

}
