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
        // Navega para a página Sobre.xaml
        await Navigation.PushAsync(new sobre());
    }
}