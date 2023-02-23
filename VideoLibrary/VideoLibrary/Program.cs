using VideoLibrary;

var library = new Library();
string str = "";
while (str != "11")
{
    Console.WriteLine("Меню");
    Console.WriteLine("Введите 1 - вывести названия всех фильмов библиотеки.");
    Console.WriteLine("Введите 2 - вывести всю информацию о фильме.");
    Console.WriteLine("Введите 3 - вывести названия фильмов в корорых снимался актер.");
    Console.WriteLine("Введите 4 - вывести названия фильмов снятых режисером.");
    Console.WriteLine("Введите 5 - вывести названия фильмов по заданной оценке.");
    Console.WriteLine("Введите 6 - вывести названия фильмов по заданному жанру.");
    Console.WriteLine("Введите 7 - вывести информацию об актерах, снимавшихся в заданном фильме.");
    Console.WriteLine("Введите 8 - вывести информацию об актерах, снимавшихся как минимум в N фильмах.");
    Console.WriteLine("Введите 9 - вывести информацию об актерах, которые были режиссерами хотя бы одного из фильмов.");
    Console.WriteLine("Введите 10 - найти все фильмы, вышедшие на экран в текущем и прошлом году.");
    Console.WriteLine("Введите 11 - для выхода");


    str = Console.ReadLine();

    try
    {
        if (str == "1")
        {
            library.ShowAllMovie();

        }
        else if (str == "2")
        {
            Console.Write("Введите название фильма: ");
            string nameOfMovie = Console.ReadLine();
            library.ShowMovieInfo(nameOfMovie);
        }
        else if (str == "3")
        {
            Console.Write("Введите имя актера: ");
            string nameActor = Console.ReadLine();
            library.ShowMoviesByActor(nameActor);
        }
        else if (str == "4")
        {
            Console.Write("Введите имя режиссера: ");
            string nameDirector = Console.ReadLine();
            library.ShowMoviesByDirector(nameDirector);
        }
        else if (str == "5")
        {
            Console.Write("Введите оценку: ");
            int score = Convert.ToInt32(Console.ReadLine());
            library.ShowMoviesByScore(score);
        }
        else if (str == "6")
        {
            Console.Write("Введите название жанра.");
            string genre = Console.ReadLine();
            library.ShowMoviesByGenre(genre);
        }
        else if (str == "7")
        {
            Console.Write("Введите название фильма: ");
            string nameOfMovie = Console.ReadLine();
            library.ShowActorsInfo(nameOfMovie);
        }
        else if (str == "8")
        {
            Console.Write("Введите количество фильмов в которых снимался актер: ");
            int count = Convert.ToInt32(Console.ReadLine());
            library.ShowMoviesWithSameActor(count);
        }
        else if (str == "9")
        {
            library.ShowActorSameDirector();
        }
        else if (str == "10")
        {
            Console.Write("Введите год выхода фильмов для просмотра: ");
            int year = Convert.ToInt32(Console.ReadLine());
            library.ShowThisAndLastYearMovies(year);
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Неправильно введенные данные, попробуйте снова");
    }



}

