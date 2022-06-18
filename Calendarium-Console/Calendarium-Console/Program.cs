// See https://aka.ms/new-console-template for more information
Console.WriteLine("Este texto está siendo mostrado desde el Program.cs!");
User usuario1 = new User(69, "correo@gmail.com", "ejemplazo777", "contraseña123", "ES");
BaseCalendar calendarioGregoriano = new BaseCalendar(03,"Gregoriano",1,"Ejemplos","https://sitioweb.com/url",2,true,1,33,12,2,29,2000,4,"Domingo","Lunes","Martes","Miercoles","Jueves",
    "Virnes", "Sabado", "Enero","Febrero","Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre", "","","","","","","","",
    31,28,31,30,31,30,31,31,30,31,30,31,0,0,0,0,0,0,0,0);
PersonalCalendar primero = new PersonalCalendar(42,"Primero",4,"Para la tarea", "https://sitioweb.com/url2", true, 1, 03, "Dies Solis", "Dies Lunae", "Dies Martis", "Dies Mercurii",
    "Dies Iovis", "Dies Veneris", "Dies Saturni", "Ianuarius Mensus", "Februarius Mensus", "Martius Mensus", "Aprilis Mensus", "Maius Mensus", "Junius Mensus", "Julius Mensus",
    "Augustus Mensus", "September Mensus", "October Mensus", "November Mensus", "December Mensus","","","","","","","","");
Event eventoEjemplo = new Event(44, "21 de Junio", new DateTime(2022,6,21), 7, 2, true, 1, "BanderaChile.png");
CustomEvent fiesta1 = new CustomEvent(22, "Carrete en casa del Juan", new DateTime(2022,6,29, 19,30,0), 7, 2, false, 1, "Fiesta.png");
Birthday cumpleDelLuciano = new Birthday(45, "Luciano", new DateTime(2022,3,27, 17,30,0),2000);
Anniversary matrimonio = new Anniversary(28,"Matrimonio",new DateTime(2022,11,11),2012,2,false,9,"Flores.png");

eventoEjemplo.MetodoEjemplo();
