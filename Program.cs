using System;

class Program
{
    public class Film
    {
        public string FilmName { get; set; }
        public double ImdbScore { get; set; }

        public Film(string _filmName, double _imdbPuanı)
        {
            FilmName = _filmName;
            ImdbScore = _imdbPuanı;
        }
    }
    public static void Main(string[] args)
    {

        List<Film> filmList = new List<Film>();

        bool continueApp = true;

        while (continueApp)
        {
            Console.WriteLine("Enter a Film Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter IMDb Score : ");
            double imdbPuan = Convert.ToDouble(Console.ReadLine());
            filmList.Add(new Film(name, imdbPuan));
            Console.WriteLine("Do you want to add another film? (y/n)");
            string answer = Console.ReadLine().ToLower();
            continueApp = answer == "y";
        }

        Console.WriteLine("All Movies : ");
        foreach (var film in filmList)
        {
            Console.WriteLine(film.FilmName);
        }
        Console.WriteLine("Movies with an IMDb score between 4 and 9 : ");
        var filmWithFilter = filmList.Where(f => f.ImdbScore >= 4 && f.ImdbScore <= 9);
        foreach (var film in filmWithFilter)
        {
            Console.Write($"Film Name : {film.FilmName}, IMDb Score : {film.ImdbScore}");
        }

        Console.Write("Movies starting with A : ");
        var startsWithA = filmList.Where(f => f.FilmName.StartsWith("A", StringComparison.OrdinalIgnoreCase));
        foreach (var film in startsWithA)
        {
            Console.WriteLine($"{film.FilmName}, IMDb Score : {film.ImdbScore}");
        }



    }

}
