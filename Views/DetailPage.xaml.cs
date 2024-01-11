namespace MauiVideo.Views;

public partial class DetailPage : ContentPage {
    public DetailPage(DetailPageViewModel detailPageViewModel) {
        InitializeComponent();
        BindingContext = detailPageViewModel;
    }
}