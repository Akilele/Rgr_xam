using System;
using Microsoft.EntityFrameworkCore;
using prakt3.models;

namespace prakt3.database
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new ApplicationContext();
            context.Database.Migrate();
        }
    }
}
