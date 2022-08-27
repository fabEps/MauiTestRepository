using System.Collections.ObjectModel;

namespace MauiAppRececlerView;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        BindingContext = this;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        Task.Run(() => LoadData(50));
    }

    private void LoadData(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            Data.Add(new DataModel());
        }
    }

    public ObservableCollection<DataModel> Data
    {
        get;
    } = new();

}

