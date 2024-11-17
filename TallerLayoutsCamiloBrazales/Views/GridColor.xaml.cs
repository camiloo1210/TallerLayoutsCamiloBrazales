namespace TallerLayoutsCamiloBrazales.Views;

public partial class GridColor : ContentPage
{
	public GridColor()
	{
		InitializeComponent();
	}
	private void Boton1(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Page2());
	}
}