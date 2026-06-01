using System;

namespace MauiAppHotel.Views;

public partial class PerfilUsuario : ContentPage
{
    public PerfilUsuario()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {        
        await DisplayAlert("Perfil", "Função de edição de dados em breve!", "OK");
    }
}