using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KendoUIDemo.Models
{
    public class Movie
    {
        public string Name { get; set; }
        public double Rating { get; set; }
        public string Year { get; set; }
    }

    public class MovieFactory
    {
        public static List<Movie> Create()
        {
            return new List<Movie>
                       {
                           new Movie {Name = "Maos Last Dancer", Rating = 4.1, Year = "1/1/2010"},
                           new Movie {Name = "Iron Man 2", Rating = 4, Year = "1/1/2010"},
                           new Movie {Name = "How to Train Your Dragon", Rating = 4.3, Year = "1/1/2010"},
                           new Movie {Name = "The Cabin in the Woods", Rating = 4, Year = "1/1/2011"},
                           new Movie {Name = "Wake Up", Rating = 4, Year = "1/1/2010"},
                           new Movie {Name = "The Fighter", Rating = 4.1, Year = "1/1/2010"},
                           new Movie {Name = "Despicable Me", Rating = 4.2, Year = "1/1/2010"},
                           new Movie {Name = "Harry Potter and the Deathly Hallows: Part I", Rating = 4.2, Year = "1/1/2010"},
                           new Movie {Name = "Toy Story 3", Rating = 4.3, Year = "1/1/2010"},
                           new Movie {Name = "Harry Potter and the Deathly Hallows: Part II", Rating = 4.4, Year = "1/1/2011"},
                           new Movie {Name = "The 5th Quarter", Rating = 4, Year = "1/1/2010"},
                           new Movie {Name = "Megamind", Rating = 4, Year = "1/1/2010"},
                           new Movie {Name = "Miami Trauma: Season 1", Rating = 4, Year = "1/1/2010"},
                           new Movie {Name = "Turtle: The Incredible Journey", Rating = 4, Year = "1/1/2011"},
                           new Movie {Name = "Rubicon: Season 1", Rating = 4, Year = "1/1/2010"},
                           new Movie {Name = "Kung Fu Panda 2", Rating = 4, Year = "1/1/2011"},
                           new Movie {Name = "American: The Bill Hicks Story", Rating = 4.1, Year = "1/1/2010"},
                           new Movie {Name = "13 Assassins", Rating = 4, Year = "1/1/2011"},
                           new Movie {Name = "Secretariat", Rating = 4.2, Year = "1/1/2010"},
                           new Movie {Name = "Red Dawn", Rating = 4, Year = "1/1/2012"},
                           new Movie {Name = "Tangled", Rating = 4.3, Year = "1/1/2010"},
                           new Movie {Name = "Sins of the Mother", Rating = 4, Year = "1/1/2010"},
                           new Movie {Name = "Letters to God", Rating = 4.2, Year = "1/1/2010"},
                           new Movie {Name = "Planet Hulk", Rating = 4, Year = "1/1/2010"},
                           new Movie {Name = "Bhutto", Rating = 4, Year = "1/1/2010"},
                           new Movie {Name = "GasLand", Rating = 4, Year = "1/1/2010"},
                           new Movie {Name = "Restrepo", Rating = 4, Year = "1/1/2010"},
                           new Movie {Name = "Waste Land", Rating = 4, Year = "1/1/2010"},
                           new Movie {Name = "Boy", Rating = 4.3, Year = "1/1/2010"},
                           new Movie {Name = "Tucker & Dale vs. Evil", Rating = 4.1, Year = "1/1/2010"},
                           new Movie {Name = "180° South", Rating = 4.1, Year = "1/1/2010"},
                           new Movie { Name = "30 for 30: Winning Time: Reggie Miller vs. The New York Knicks", Rating = 4.2,Year = "1/1/2010"},
                           new Movie {Name = "My Name is Khan", Rating = 4, Year = "1/1/2010"},
                           new Movie {Name = "Inception", Rating = 4, Year = "1/1/2010"},
                           new Movie { Name = "Roads to Memphis: The Assassination of Martin Luther King, Jr.: American Experience", Rating = 4, Year = "1/1/2010"},
                           new Movie {Name = "The Buddha", Rating = 4, Year = "1/1/2010"},
                           new Movie {Name = "Love", Rating = 4.1, Year = "1/1/2011"},
                           new Movie {Name = "Temple Grandin", Rating = 4.2, Year = "1/1/2010"},
                           new Movie {Name = "Bugs Bunny: Hare Extraordinaire", Rating = 4.1, Year = "1/1/2010"},
                           new Movie {Name = "Horses", Rating = 4.3, Year = "1/1/2010"},
                           new Movie {Name = "National Geographic: American Serengeti", Rating = 4, Year = "1/1/2010"},
                           new Movie { Name = "UFC 110: Nogueira vs. Velasquez: Bonus Material", Rating = 4.1, Year = "1/1/2010" },
                           new Movie {Name = "Hood to Coast", Rating = 4.2, Year = "1/1/2010"},
                           new Movie {Name = "The Way", Rating = 4.1, Year = "1/1/2010"},
                           new Movie {Name = "The Happy Poet", Rating = 4, Year = "1/1/2010"},
                           new Movie {Name = "NY Export: Opus Jazz", Rating = 4.2, Year = "1/1/2010"},
                           new Movie {Name = "Batman: Under The Red Hood", Rating = 4, Year = "1/1/2010"},
                           new Movie {Name = "Undisputed III: Redemption", Rating = 4, Year = "1/1/2010"},
                           new Movie {Name = "The Round Up", Rating = 4, Year = "1/1/2010"},
                           new Movie {Name = "The Kings Speech", Rating = 4.3, Year = "1/1/2010"}
                       };
        } 
    }
}