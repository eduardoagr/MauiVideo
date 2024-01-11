namespace MauiVideo.Models;

public class Movie {

    public string? title { get; set; }

    public string? bulletText { get; set; }

    public string? description { get; set; }

    public int runningTime { get; set; }

    public string? id { get; set; }

    public string? artUrl { get; set; }

    public IList<string>? related { get; set; }
}
