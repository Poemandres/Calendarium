using System;
using MySql.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Calendarium.Models
{
public class Event
{

		public int ID {get; set;}
		public String? eventNAME {get; set;}
		public DateTime eventDATE {get; set;}
		public int eventTYPE {get; set;}
		public int eventCATEGORY {get; set;}
		public bool eventHOLIDAY {get; set;}
		public int eventIMPORTANCE {get; set;}
		public String? eventICON {get; set;}

	public Event(int ID, String eventNAME, DateTime eventDATE, int eventTYPE, int eventCATEGORY, bool eventHOLIDAY, int eventIMPORTANCE, String eventICON) { 
		this.ID = ID;
		this.eventNAME = eventNAME;
		this.eventDATE = eventDATE;
		this.eventTYPE = eventTYPE;
		this.eventCATEGORY = eventCATEGORY;
		this.eventHOLIDAY = eventHOLIDAY;
		this.eventIMPORTANCE = eventIMPORTANCE;
		this.eventICON = eventICON;
    }

	public void MetodoEjemplo()
	{
		Console.WriteLine("Este texto está siendo mostrado desde el método MetodoEjemplo de la clase Event.");
		Console.WriteLine($"El evento en cuestión es el {eventNAME}.");
		Console.WriteLine($"''{eventNAME}'' es el valor de la variable eventNAME en esta instancia de la clase Event! :D");
	}
}
public class EventContext : DbContext
    {
        public DbSet<Event> dbevents { get; set; }

        protected override void  OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseMySQL("server=localhost;database=calendarium;user=root;password=");
        }
}}