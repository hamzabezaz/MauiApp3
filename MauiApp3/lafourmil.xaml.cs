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
        NewPag1.Navigation.PushAsync(new NewPage1());
    }

    private void next_Clicked(object sender, EventArgs e)
    {
        pres.IsEnabled = true;
        if (count < 9)
        {
            count++;
            Updatecount();
            safha.Source = "C:\\Users\\HP\\source\\repos\\MauiApp3\\MauiApp3\\Resources\\Images\\namla ("+count+").jpg";
        }
        else
        {
            next.IsEnabled = false;
            l.Text = "??????? ???? ???:9";
        }
    }

    private void pres_Clicked(object sender, EventArgs e)
    {
        next.IsEnabled = true;
        if (count > 1)
        {
            count--;
            Updatecount();
            safha.Source = "C:\\Users\\HP\\source\\repos\\MauiApp3\\MauiApp3\\Resources\\Images\\namla (" + count + ").jpg";
        }
        else
        {
            safha.Source = "C:\\Users\\HP\\source\\repos\\MauiApp3\\MauiApp3\\Resources\\Images\\namla (1).jpg";
            pres.IsEnabled = false;
        }
    }
    private void Updatecount()
    {
        string cs = count.ToString();
        l.Text = cs;
    }
}