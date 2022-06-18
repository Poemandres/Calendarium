using System;

public class Event
{

		private int eventID {get; set;}
		private String? eventNAME {get; set;}
		private DateTime eventDATE {get; set;}
		private int eventTYPE {get; set;}
		private int eventCATEGORY {get; set;}
		private bool eventHOLIDAY {get; set;}
		private int eventIMPORTANCE {get; set;}
		private String? eventICON {get; set;}

	public Event(int eventID, String eventNAME, DateTime eventDATE, int eventTYPE, int eventCATEGORY, bool eventHOLIDAY, int eventIMPORTANCE, String eventICON) { 
		this.eventID = eventID;
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