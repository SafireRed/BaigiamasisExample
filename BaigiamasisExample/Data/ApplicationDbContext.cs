using BaigiamasisExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace BaigiamasisExample.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<UserHouseStuff> UserHouseStuffs { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Kaip sukurt modeli paziejau tutoriala ir kazkiek sumatchinau su kitu pavyzdziais
            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(k => k.UserId);
                entity.Property(k => k.UserId)
                .IsRequired()
                .ValueGeneratedNever();

                entity.HasOne(k => k.UserInfo)
                .WithOne(k => k.User)
                .HasForeignKey<UserInfo>(k => k.User.UserId)
                .IsRequired();


                entity.HasKey(k => k.Username);
                entity.HasKey(k => k.Salt);
                entity.HasKey(k => k.Role);
                entity.HasIndex(k => k.Username)
                .IsUnique();
            });
            
            //modelBuilder.Entity<UserInfo>().ToTable("userinfos");
            //modelBuilder.Entity<UserInfo>(entity =>
            //{
            //    entity.HasKey(k => k.Id);

            //    entity.Property(k => k.Id)
            //    .IsRequired()
            //    .ValueGeneratedNever();

            //    entity.HasOne(k => k.User)
            //    .WithOne(k => k.UserInfo)
            //    .HasForeignKey<UserInfo>(k => k.Id)
            //    .IsRequired();

            //    entity.HasKey(k => k.FirstName);
            //    entity.HasKey(k => k.LastName);
            //    entity.HasKey(k => k.SocialSecurityNumber);
            //    entity.HasKey(k => k.PhoneNum);
            //    entity.HasKey(k => k.Email);      
            //}); 
            
            //modelBuilder.Entity<UserHouseStuff>().ToTable("userhousestuffs");
            //modelBuilder.Entity<UserHouseStuff>(entity =>
            //{
            //    entity.HasKey(k => k.Id);

            //    entity.Property(k => k.Id)
            //    .IsRequired()
            //    .ValueGeneratedNever();

            //    //neleidzia pacheckint ar egzistuoja kitas info

            //    //entity.HasOne(k => k.UserInfo)
            //    //.WithOne(k => k.UserHouseStuff)
            //    //.HasForeignKey(k => k.Id);
                

            //    entity.HasKey(k => k.City);
            //    entity.HasKey(k => k.Street);
            //    entity.HasKey(k => k.HouseNumber);
            //    entity.HasKey(k => k.ApartmentNumber);                
            //});
                
        }
    }
}
