namespace VideoLibrary;

internal class Movie
{
    public string Name { get; set; } = string.Empty;
    public int PremiereDate { get; set; }
    public string Country { get; set; } = string.Empty;
    public int Score { get; set; }
    public string Genre { get; set; } = string.Empty;
    public Actor[] Actors { get; set; } = Array.Empty<Actor>();
    public Director[] Directors { get; set; } = Array.Empty<Director>();

    public override string ToString()
    {
        var actors = string.Join(", ", Actors.Select(actor => actor.Name));
        var directors = string.Join(", ", Directors.Select(director => director.Name));
        return @$"{Name}, год выхода фильма {PremiereDate}, страна {Country}, 
актеры: {actors}, 
режиссеры {directors},
оценка за фильм {Score}, 
жанр {Genre}.";
    }
}
