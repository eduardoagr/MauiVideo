namespace MauiVideo.ViewModels;

public partial class MainPageViewModel(HttpService httpService, IConnectivity connectivity) : BaseViewModel {

    public ObservableCollection<Movie> Movies { get; set; } = [];

    [RelayCommand]
    async Task OnApearing() {

        if(connectivity.NetworkAccess != NetworkAccess.Internet) {
            bool answer = await Shell.Current.DisplayAlert("Please check that you have internet and try again", "try again?", "Yes", "No");
            if(answer) {
                await GetMovies();
            }
        } else {
            await GetMovies();
        }
    }

    [RelayCommand]
    async Task SelectedItemAsync(Movie Movie) {


        if(Movie != null) {
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}", true, new Dictionary<string, object> {

              {"Movie", Movie }

           });
        }
    }

    private async Task GetMovies() {

        IsBusy = true;

        var MovieJson = await httpService.GetAsync<List<Movie>>("https://assets.acmeaom.com/interview-project/uwpvideos.json");

        Movies.Clear();

        foreach(var item in MovieJson!.OrderBy(movie => movie.title, StringComparer.OrdinalIgnoreCase)) {
            Movies.Add(item);
        }

        IsBusy = false;
    }
}
