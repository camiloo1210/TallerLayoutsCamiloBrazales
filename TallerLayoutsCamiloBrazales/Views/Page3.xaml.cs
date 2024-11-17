namespace TallerLayoutsCamiloBrazales.Views;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}
	private void Boton3(object sender, EventArgs e)
	{
		Navigation.PushAsync(new GridColor());
	}
}