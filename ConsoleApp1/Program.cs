using System;
using System.Linq;
using ZW.MyAirport.EF;

namespace ZW.MyAirport
{
    class Program
    {
        static void Main()
        {
            using ( MyAirportContext db = new MyAirportContext())
            {
                // Create

                db.Flights.Add(new Flight
                {
                    CIE = 1,
                    LIG = "knjfe",
                    JEX = 12,
                    
             
                }); 
                db.SaveChanges();


                /*
                // Read
          
                var blog = db.Blogs
                    .OrderBy(b => b.BlogId)
                    .First();

                // Update
                
              
                blog.Posts.Add(
                    new Post
                    {
                        Title = "Hello World",
                        Content = "I wrote an app using EF Core!"
                    });
                db.SaveChanges();

                // Delete
        
                db.Remove(blog);
                db.SaveChanges(); */
            }
        }
    }
}