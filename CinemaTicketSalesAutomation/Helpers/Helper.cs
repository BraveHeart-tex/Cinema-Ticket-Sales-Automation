using CinemaTicketSalesAutomation.Enums;
using CinemaTicketSalesAutomation.Models;
using System.Collections.Generic;

namespace CinemaTicketSalesAutomation.Helpers
{
    public class Helper
    {
        public static List<Movie> CreateMovies()
        {
            string basePath = "C:/Users/Teknogenetik/Desktop/Dersler/CinemaTicketSalesAutomation/CinemaTicketSalesAutomation/Pictures/";
            return new List<Movie>()
            {
                new Movie()
                {
                    movieName = "Interstellar",
                    category = Category.bilim_kurgu,
                    minute = "2 hours 49 minutes",
                    price = 50,
                    picturePath = basePath + "interstellar.jpg"
                },
                new Movie()
                {
                    movieName = "Don't Breath",
                    category = Category.gerilim,
                    minute = "1 hour 28 minutes",
                    price = 50,
                    picturePath = basePath + "dontbreath.jpg"
                },
                 new Movie()
                {
                    movieName = "Jumanji",
                    category = Category.macera,
                    minute = "1 hours 44 minutes",
                    price = 50,
                    picturePath = basePath + "jumanji.jpg"
                },
                new Movie()
                {
                    movieName = "3 Idiots",
                    category = Category.komedi,
                    minute = "2 hours 51 minutes",
                    price = 50,
                    picturePath = basePath + "3idiots.jpg"
                },
                 new Movie()
                {
                    movieName = "Warcraft",
                    category = Category.fantastik,
                    minute = "2 hours 3 minutes",
                    price = 50,
                    picturePath = basePath + "warcraft.jpg"
                },

                 new Movie()
                {
                    movieName = "Back To the Future",
                    category = Category.komedi,
                    minute = "2 hours 51 minutes",
                    price = 70,
                    picturePath = basePath + "backtothefuture.jpg"
                }

            };
        }
    }
}
