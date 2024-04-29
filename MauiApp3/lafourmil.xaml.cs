namespace MauiApp3;

public partial class lafourmil : ContentPage
{
	public lafourmil()
	{
		InitializeComponent();
	}
    int count = 0;
    private void strt_Clickd(object sender, EventArgs e)
    {
        if (count == 0)
        {
            count = 1;
            Updatecount();
            safha.Source = "C:\\Users\\HP\\source\\repos\\MauiApp3\\MauiApp3\\Resources\\Images\\namla (1).jpg";
        }
        else
        {
            count = 0;
            Updatecount();
            safha.Source = "";
        }
    }

    private void NewPag1_Clicked(object sender, EventArgs e)
    {

    }

    private void next_Clicked(object sender, EventArgs e)
    {

    }

    private void pres_Clicked(object sender, EventArgs e)
    {

    }
    private void Updatecount()
    {
        string cs = count.ToString();
        l.Text = cs;
    }
}