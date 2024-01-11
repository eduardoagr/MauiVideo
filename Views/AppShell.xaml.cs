namespace MauiVideo;

public partial class AppShell : Shell {
    public AppShell() {
        InitializeComponent();
        RegisterPages();
    }

    private void RegisterPages() {
        Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
    }
}
