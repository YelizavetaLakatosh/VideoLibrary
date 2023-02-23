namespace VideoLibrary;

internal class Library
{
    public List<Movie> Movies { get; set; }

    public ListOfActors ListOfActors { get; set; }
    public Library()
    {
        ListOfActors = new ListOfActors();
        Movies = new List<Movie>
        {
            new Movie
            {
                Name = "Не смотрите наверх",
                PremiereDate = 2021,
                Directors = new Director[]{ new Director {Name = "Адам Маккей"}},
                Actors = new Actor[]
                {
                    ListOfActors.GetActor("Леонардо Ди Каприо"),
                    ListOfActors.GetActor("Дженнифер Лоуренс"),
                    ListOfActors.GetActor("Джона Хилл"),
                    ListOfActors.GetActor("Мэрил Стрип"),

                },
                Score = 4,
                Genre = "чёрная комедия",
                Country = "США"
            },
            new Movie
            {
                Name = "Начало",
                PremiereDate = 2010,
                Directors = new Director[]{ new Director {Name = "Кристофер Нолан"} },
                Actors = new Actor[]
                {
                    ListOfActors.GetActor("Леонардо Ди Каприо"),
                    ListOfActors.GetActor("Эллен Пейдж"),
                    ListOfActors.GetActor("Марион Котийяр"),
                    ListOfActors.GetActor("Том Харди"),

                },
                Score = 5,
                Genre = "научная фантастика, боевик, триллер, драма",
                Country = "США"
            },
            new Movie
            {
                Name = "Страсти Дон Жуана",
                PremiereDate = 2013,
                Directors = new Director[]{ new Director {Name = "Джозеф Гордон-Левитт"} },
                Actors = new Actor[]
                {
                    ListOfActors.GetActor("Джозеф Гордон-Левитт"),
                    ListOfActors.GetActor("Бри Ларсон"),
                    ListOfActors.GetActor("Джулианна Мур"),
                    ListOfActors.GetActor("Скарлетт Йоханссон"),

                },
                Score = 3,
                Genre = "комедия",
                Country = "США"

            },

        };
    }
    public void ShowMovieInfo(string nameOfMovie)
    {
        foreach (Movie movie in Movies)
        {
            if (nameOfMovie == movie.Name)
            {
                Console.WriteLine(movie.ToString());
            }
        }
    }

    public void ShowMoviesByActor(string nameOfActor)
    {
        var movies = Movies.Where(movie => movie.Actors.Any(actor => actor.Name.Contains(nameOfActor))).Select(movie => movie.Name);
        Console.WriteLine(string.Join(", ", movies));
    }

    public void ShowMoviesByDirector(string nameOfDirector)
    {
        var movies = Movies.Where(movie => movie.Directors.Any(director => director.Name.Contains(nameOfDirector))).Select(movie => movie.Name);
        Console.WriteLine(string.Join(", ", movies));
    }

    public void ShowMoviesByScore(int score)
    {
        var movies = Movies.Where(movie => movie.Score == score).Select(movie => movie.Name);
        Console.WriteLine(string.Join(", ", movies));
    }

    public void ShowMoviesByGenre(string genre)
    {
        var movies = Movies.Where(movie => movie.Genre.Contains(genre)).Select(movie => movie.Name);
        Console.WriteLine(string.Join(", ", movies));
    }
    public void ShowThisAndLastYearMovies(int year)
    {
        foreach (Movie movie in Movies)
        {
            if (year == movie.PremiereDate || year - 1 == movie.PremiereDate)
            {
                Console.WriteLine($"{movie.Name} ({movie.PremiereDate})");
            }
        }
    }

    public void ShowActorsInfo(string nameOfMovie)
    {
        foreach (Movie movie in Movies)
        {
            if (nameOfMovie == movie.Name)
            {
                foreach (Actor actor in movie.Actors)
                {
                    Console.WriteLine($"{actor.Name} {actor.DateOfBirth}");
                }

            }
        }
    }

    public void ShowMoviesWithSameActor(int count)
    {
        int n = 0;
        foreach (Actor actors in ListOfActors.Actors)
        {
            foreach (Movie movie in Movies)
            {
                foreach (var actor in movie.Actors)
                {
                    if (actor.Name == actors.Name)
                    {
                        n++;
                    }
                }
            }
            if (n == count)
            {
                Console.WriteLine($"{actors.Name} {actors.DateOfBirth}");
            }
            n = 0;
        }


    }

    public void ShowActorSameDirector()
    {
        foreach (Actor actors in ListOfActors.Actors)
        {
            foreach (Movie movie in Movies)
            {
                foreach (Director director in movie.Directors)
                {
                    if (director.Name == actors.Name)
                    {
                        Console.WriteLine("Актер работающий и режисером:");
                        Console.WriteLine($"{actors.Name} {actors.DateOfBirth}");
                    }
                }
            }
        }
    }

    public void AddMovie(string nameMovie, string nameActors, string nameDirectors, string genre, string countries, int year, int score)
    {
        var actors = nameActors.Split(", ").Select(actor => ListOfActors.GetActor(actor)).ToArray();
        var directors = nameDirectors.Split(", ").Select(director => new Director { Name = director}).ToArray();
        Movie newMovie = new Movie
        {
            Name = nameMovie,
            PremiereDate = year,
            Directors = directors,
            Actors = actors,
            Score = score,
            Genre = genre,
            Country = countries
        };
        Movies.Add(newMovie);

    }

    public void ShowAllMovie()
    {
        Console.WriteLine("Все фильмы в медиатеке:");
        Console.WriteLine(String.Join(", ", Movies.Select(mov => mov.Name)) + ".");
    }

}
