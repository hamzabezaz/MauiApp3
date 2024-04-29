namespace MauiApp3;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    private void Lay_Clicked(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new NewPage2());
    }

    private void lapin_Clicked(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new lapin());
    }

    private void lafourmil_Clicked(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new lafourmil());
    }
}