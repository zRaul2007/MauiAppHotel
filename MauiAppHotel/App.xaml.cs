
using MauiAppHotel.Models;

namespace MauiAppHotel
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>
        {
            new Quarto()
            {
                Descricao = "Suite Premium",
                ValorDiariaAdulto = 140.0,
                ValorDiariaCrianca = 70.0
            },

            new Quarto()
            {
                Descricao = "Suite Aconchegante",
                ValorDiariaAdulto = 100.0,
                ValorDiariaCrianca = 50.0
            },
            new Quarto()
            {
                Descricao = "Suite Solteiro",
                ValorDiariaAdulto = 60.0,
                ValorDiariaCrianca = 25.0
            },
            new Quarto()
            {
                Descricao = "Suite do Amor",
                ValorDiariaAdulto = 120.0,
                ValorDiariaCrianca = 60.0
            }
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Height = 600;
            window.Width = 400;

            return window;

        }
    }
}
