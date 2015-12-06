using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_4
{
    class Movie
    {
        private double MovieCost;
        private string MovieType;
        private double ThisMovieCost;

        public Movie(string movieType, double movie)
        {
            this.MovieType = movieType;
            this.MovieCost = movie;
        }

        public void Print()
        {
            System.Console.WriteLine(this.MovieType + " : $" + this.MovieCost);
        }

        public double Pricing(double movieQty)
        {

            this.ThisMovieCost = this.MovieCost * movieQty;
            return this.ThisMovieCost;
        }
        public double MovieTotals()
        {
            return this.ThisMovieCost;
        }
    }
}
