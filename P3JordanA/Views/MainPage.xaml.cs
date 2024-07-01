using P3JordanA.Services;

namespace P3JordanA
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        private readonly P3JordanA.Services.Servicio _servicio;
        public MainPage(Servicio servicio)
        {
            InitializeComponent();
            _servicio = servicio;
        }




        private async void OnCounterClicked(object sender, EventArgs e)
        {
            loading.IsVisible = true;


            var data = await _servicio.GetChistechucks();

            Chuck.ItemsSource = data;


            loading.IsVisible = false;


        }

    }

}
