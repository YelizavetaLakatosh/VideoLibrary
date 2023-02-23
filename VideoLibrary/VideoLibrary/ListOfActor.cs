namespace VideoLibrary;

internal class ListOfActors
{
    public Actor[] Actors { get; set; }
    public ListOfActors()
    {
        Actors = new Actor[]
        {
            new Actor {Name = "Леонардо Ди Каприо", DateOfBirth = "11 ноября 1974"},
            new Actor {Name = "Дженнифер Лоуренс", DateOfBirth = "15 августа 1990" },
            new Actor {Name = "Джона Хилл", DateOfBirth = "20 декабря 1983" },
            new Actor {Name = "Мэрил Стрип", DateOfBirth = "22 июня 1949" },
            new Actor {Name = "Эллен Пейдж", DateOfBirth = "21 февраля 1987" },
            new Actor {Name = "Марион Котийяр", DateOfBirth = "30 сентября 1975"},
            new Actor {Name = "Том Харди", DateOfBirth = "15 сентября 1977"},
            new Actor {Name = "Джозеф Гордон-Левитт", DateOfBirth = "17 февраля 1981"},
            new Actor {Name = "Бри Ларсон", DateOfBirth = "17 февраля 1981"},
            new Actor {Name = "Джулианна Мур", DateOfBirth = "17 февраля 1981"},
            new Actor {Name = "Скарлетт Йоханссон", DateOfBirth = "17 февраля 1981"},
        };
    }
    public Actor? GetActor(string name)
    {
        foreach (Actor actor in Actors)
        {
            if (actor.Name == name)
            {
                return actor;
            }
        }
        return null;
    }
}


