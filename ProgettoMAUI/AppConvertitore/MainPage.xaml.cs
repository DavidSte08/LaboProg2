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
            try
            {
                lblRisultato.TextColor = Colors.Green;
                double franchi = Convert.ToDouble(entConversione.Text);
                string risultato = Convert.ToString(Math.Round(franchi * 1.07, 2));
                lblRisultato.Text = "Risultato = " + risultato + " Euro";
            }
            catch (ArgumentNullException aex)
            {
                lblRisultato.TextColor = Colors.Red;
                DisplayAlert("Argument Null Exception",  
                    "inserisci qualcosa nel campo", 
                    "Ok");
                entConversione.Focus();
            }
            catch (FormatException fex)
            {
                lblRisultato.TextColor = Colors.Red;
                DisplayAlert("Format Exception",
                    "inserisci valore numerico nel campo", 
                    "Ok");
                entConversione.Focus();
            }
            catch (OverflowException oex)
            {
                lblRisultato.TextColor = Colors.Red;
                DisplayAlert("Overflow Exception",
                    "troppo lungo", 
                    "Ok");
                entConversione.Focus();
            }

        }

        private void btnReset_Clicked(object sender, EventArgs e)
        {
            lblRisultato.TextColor = Colors.Black;
            entConversione.Text = "";
            lblRisultato.Text = "Pronto per convertire";
            entConversione.Focus();
        }

    }
}
