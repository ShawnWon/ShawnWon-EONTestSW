using System;
using System.Collections.Generic;
using System.Data.Entity;
using EONtestEF.Models;

namespace EONtestEF.DB
{
    public class EONDBInitializer<T> : DropCreateDatabaseAlways<EONDbContext>
    {
        protected override void Seed(EONDbContext context)
        {
            Users user = new Users("Peter Even","pet@gmail.com","M",DateTime.Today.ToString("yyyy-MM-dd"),true,false,true,"To provide rooms") { };
            context.users.Add(user);
            Users user1 = new Users("Garcia Marques", "sab@gmail.com", "M", DateTime.Today.ToString("yyyy-MM-dd"), true, false,true, "To provide rooms") { };
            context.users.Add(user1);
            Users user2 = new Users("Milan Kundera", "pet@gmail.com", "M", DateTime.Today.ToString("yyyy-MM-dd"), true,true,true, "To provide rooms") { };
            context.users.Add(user2);

            base.Seed(context);
        }
    }
}