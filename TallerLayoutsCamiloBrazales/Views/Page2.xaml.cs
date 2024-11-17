namespace TallerLayoutsCamiloBrazales.Views;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

	private void Boton2(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Page3());
	}
}