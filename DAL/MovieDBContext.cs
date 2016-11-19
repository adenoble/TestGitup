using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MovieProject.Models;


namespace MovieProject.DAL
{
    public class MovieDBContext: DbContext
    {
        public MovieDBContext() : base("MovieDBConnectionString") {

            Database.SetInitializer<MovieDBContext>(null);

            this.Configuration.LazyLoadingEnabled = false;
               
        }
       //Map model names to corresponding database table and collumn to resolve naming conflict
       /* protected override void OnModelCreating(DbModelBuilder modelBuilder) { 
        modelBuilder.

        }
        */
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Movie> Movie { get; set; }

    }
}