using System;
using MySql.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MysqlProject.Models
{
    public class Birthday
    {

        private int ID { get; set; }
        private String? birthdayNAME { get; set; }
        private DateTime birthdayBIRTHDATE { get; set; }
        private int birthdayBIRTHYEAR { get; set; }


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