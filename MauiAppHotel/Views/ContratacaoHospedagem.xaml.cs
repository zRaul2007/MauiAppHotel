using Microsoft.Maui.ApplicationModel.DataTransfer;

namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}

    private async void Button_ClickedAsync(object sender, EventArgs e)
    {
        // Navega para a p�gina Sobre.xaml
        await Navigation.PushAsync(new sobre());
    }
}