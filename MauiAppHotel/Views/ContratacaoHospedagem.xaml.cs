using System;

namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    public ContratacaoHospedagem()
    {
        InitializeComponent();
    }

    // ADICIONE ESTE BLOCO ABAIXO:
    private async void Button_Sobre_Clicked(object sender, EventArgs e)
    {
        // Navega para a SobrePage de forma animada
        await Navigation.PushAsync(new Views.Sobre());
    }
}