namespace MauiVideo.ViewModels;

[QueryProperty("Movie", "Movie")]
public partial class DetailPageViewModel : BaseViewModel {

    [ObservableProperty]
    Movie? movie;
}
