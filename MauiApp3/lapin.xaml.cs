namespace MauiApp3;

public partial class lapin : ContentPage
{
	public lapin()
	{
		InitializeComponent();
	}

    int count = 0;

    private void strta_Clickd(object sender, EventArgs e)
    {
        if (count == 0)
        {
            count = 1;
            Updatecount();
            safha.Source = "C:\\Users\\HP\\source\\repos\\MauiApp3\\MauiApp3\\Resources\\Images\\arnab (1).jpg";
        }
        else
        {
            count = 0;
            Updatecount();
            safha.Source = "C:\\Users\\HP\\source\\repos\\MauiApp3\\MauiApp3\\Resources\\Images\\arnab (0).jpg";
        }
    }

    private void NewPag1_Clicked(object sender, EventArgs e)
    {
        NewPag1.Navigation.PushAsync(new NewPage1());
    }

    private void next_Clicked(object sender, EventArgs e)
    {
        pres.IsEnabled = true;
        if (count < 13)
        {
            count++;
            Updatecount();
            safha.Source = "C:\\Users\\HP\\source\\repos\\MauiApp3\\MauiApp3\\Resources\\Images\\arnab (" + count + ").jpg";
        }
        else
        {
            next.IsEnabled = false;
            l.Text = "??? ?????? ?? :13";
        }
    }

    private void pres_Clicked(object sender, EventArgs e)
    {
        next.IsEnabled = true;
        if (count > 1)
        {
            count--;
            Updatecount();
            safha.Source = "C:\\Users\\HP\\source\\repos\\MauiApp3\\MauiApp3\\Resources\\Images\\arnab (" + count + ").jpg";
        }
        else
        {
            safha.Source = "";
            pres.IsEnabled = false;
        }
    }
    private void Updatecount()
    {
        string cs = count.ToString();
        l.Text = cs;
    }
}