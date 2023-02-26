using System;
using System.Xml.Linq;

namespace Movies
{
    abstract class Movie
    {
        // Property
        public abstract string Title { get; set; }

        public abstract int Year { get; set; }

        public abstract int Rating { get; set; }
        // Methods
        public abstract string Describe();

        public abstract string ReleaseRating();
       
    }

    class Program
    {
        class Action : Movie
        {
            // override the abstract property
            public override string Title { get; set; }
            public override int Year { get; set; }
            public override int Rating { get; set; }

            public string DirectorName { get; set; }

            public Action()
            {
                Title = string.Empty;
                DirectorName = string.Empty;
                Year = 0;
                Rating = 0;
            }
            public Action(string title, string directorname, int year, int rating)
            {
                Title = title;
                DirectorName = directorname;
                Year = year;

                Rating = rating;
            }
            // override the abstract method
            public override string Describe()
            {
                return "The film " + Title + "was directed by " + DirectorName + "." ;
            }
            public override string ReleaseRating()
            {
                return "This movie was released in the year of " + Year + " and received a " + Rating + " on Rotten Tomatoes.";
            }
        }
        static void Main(string[] args)
        {
            Action movie1 = new Action("Top Gun: Maverick ", "Joseph Kosinski", 2022, 96);
            
            Console.WriteLine(movie1.Describe());
            Console.WriteLine(movie1.ReleaseRating());
            Console.WriteLine("");

            // Create Action object 
            Action movie2 = new Action();
            movie2.Title = "The Woman King ";
            movie2.DirectorName = "Gina Prince-Bythewood";
            movie2.Year = 2022;
            movie2.Rating = 94;
           
            Console.WriteLine(movie2.Describe());
            Console.WriteLine(movie2.ReleaseRating());
        }
    }
}

