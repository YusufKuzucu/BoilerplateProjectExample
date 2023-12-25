using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MicroWebExample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroWebExample.Persistence.Context
{
    public class ApplicationDbContext : AbpDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasData
                (
                  new Blog() { Id = 1, Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras pellentesque scelerisque ipsum, id malesuada tellus feugiat in. Mauris nec mollis nisl. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ", CreateDate = DateTime.Now, Image = "https://i.hizliresim.com/m1hsor9.jpg", Title = "What is Lorem Ipsum?", SortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit" },
                  new Blog() { Id = 2, Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras pellentesque scelerisque ipsum, id malesuada tellus feugiat in. Mauris nec mollis nisl. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ", CreateDate = DateTime.Now, Image = "https://i.hizliresim.com/m1hsor9.jpg", Title = "What is Lorem Ipsum?", SortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit" },
                  new Blog() { Id = 3, Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras pellentesque scelerisque ipsum, id malesuada tellus feugiat in. Mauris nec mollis nisl. Lorem ipsum dolor sit amet, consectetur adipiscing elit. ", CreateDate = DateTime.Now, Image = "https://i.hizliresim.com/m1hsor9.jpg", Title = "What is Lorem Ipsum?", SortDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit" }
                );
            modelBuilder.Entity<Slider>().HasData(
                new Slider() { Id = 1, Image = "https://i.hizliresim.com/erwveyw.jpg", SortDescription = "Lorem ipsum dolor sit amet", Title = "Lorem ipsum" },
                new Slider() { Id = 2, Image = "https://i.hizliresim.com/erwveyw.jpg", SortDescription = "Lorem ipsum dolor sit amet", Title = "Lorem ipsum" }
                );
        }
    }
}
