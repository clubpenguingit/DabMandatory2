using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Configuration;


namespace DABManatory2
{
    class BlackBoardContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=DESKTOP-UGIDUH3;Initial Catalog=MandatoryDAB2;Integrated Security=True");
    }
}
