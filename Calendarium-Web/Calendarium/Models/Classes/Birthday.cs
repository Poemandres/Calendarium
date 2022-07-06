using System;

public class Birthday
{

		private int personID {get; set;} 
		private String? personNAME {get; set;} 
		private DateTime personBIRTHDATE {get; set;}
		private int personBIRTHYEAR { get; set; }


	public Birthday(int personID, String personNAME, DateTime personBIRTHDATE, int personBIRTHYEAR) { 
		this.personID = personID;
		this.personNAME = personNAME;
		this.personBIRTHDATE = personBIRTHDATE;
		this.personBIRTHYEAR = personBIRTHYEAR;
	}

}