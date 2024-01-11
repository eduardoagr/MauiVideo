namespace MauiVideo.Views;
public partial class MainPage : ContentPage {
    public MainPage(MainPageViewModel mainPageViewModel) {
        InitializeComponent();

        BindingContext = mainPageViewModel;
    }
}
