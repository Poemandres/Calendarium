using System;
using MySql.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Calendarium.Models
{
    public class Birthday
    {

        public int ID { get; set; }
        public String? birthdayNAME { get; set; }
        public DateTime birthdayBIRTHDATE { get; set; }
        public int birthdayBIRTHYEAR { get; set; }


        public Birthday(int ID, String birthdayNAME, DateTime birthdayBIRTHDATE, int birthdayBIRTHYEAR) {
            this.ID = ID;
            this.birthdayNAME = birthdayNAME;
            this.birthdayBIRTHDATE = birthdayBIRTHDATE;
            this.birthdayBIRTHYEAR = birthdayBIRTHYEAR;
        }}
        public class BirthdayContext : DbContext
        {
            public DbSet<Birthday> dbbirthdays { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
            {
                optionBuilder.UseMySQL("server=localhost;database=calendarium;user=root;password=");
            }
        
       }}