namespace MonetixProyecto;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    // Método para manejar eventos si necesitas usar botones
    private void OnButtonClicked(object sender, EventArgs e)
    {
        // Lógica del botón "Entrar"
        DisplayAlert("Entrar", "Has iniciado sesión.", "OK");
    }
}
