using System;

public class CustomEvent
{

		private int customEventID {get; set;}
		private String? customEventNAME {get; set;}
		private DateTime customEventDATE {get; set;}
		private int customEventTYPE {get; set;}
		private int customEventCATEGORY {get; set;}
		private bool customEventHOLIDAY {get; set;}
		private int customEventIMPORTANCE {get; set;}
		private String customEventICON {get; set;}

	public CustomEvent(int customEventID, String customEventNAME, DateTime customEventDATE, int customEventTYPE, int customEventCATEGORY, bool customEventHOLIDAY, 
		int customEventIMPORTANCE, String customEventICON) {
		this.customEventID = customEventID;
		this.customEventNAME = customEventNAME;
		this.customEventDATE = customEventDATE;
		this.customEventTYPE = customEventTYPE;
		this.customEventCATEGORY = customEventCATEGORY;
		this.customEventHOLIDAY = customEventHOLIDAY;
		this.customEventIMPORTANCE = customEventIMPORTANCE;
		this.customEventICON = customEventICON;
	}

}