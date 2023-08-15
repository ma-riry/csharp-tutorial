using System;
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Person user = new Person("Matija", "Katić", 32, true);
// Person user2 = new Person("Maja", "Perić", 24, false);

// Console.WriteLine("***************************************************");

// Console.WriteLine("Ime i prezime: {0} {1}", user.ime, user.prezime);
// Console.WriteLine("Dob: {0}", user.age); 
// Console.WriteLine("Spol: {0}", user.gender ? "Muško" : "Žensko"); 

// Console.WriteLine("***************************************************");

// Console.WriteLine("Ime i prezime: {0} {1}", user2.ime, user2.prezime);
// Console.WriteLine("Dob: {0}", user2.age); 
// Console.WriteLine("Spol: {0}", user2.gender ? "Muško" : "Žensko"); // ctrl+D multiple word marking
// //ctrl + C copy line, SHIFT ctrl + C multiple lines
// Console.WriteLine("***************************************************");
// class Person {
//     public string ime;
//     public string prezime; 
//     public int age;
//     public bool gender; // male true, female false

//     public Person (string ime, string prezime, int age, bool gender) {
//         this.ime = ime;
//         this.prezime = prezime;
//         this.age = age;
//         this.gender = gender;
//     }
// }

// hw 
// []





Tablet app = new Tablet();
GraphicsTablet tablet = new GraphicsTablet(app.man[0], app.color[0], 2000, true); // in
GraphicsTablet tablet2 = new GraphicsTablet(app.man[1], app.color[1], 3500, true);
GraphicsTablet tablet3 = new GraphicsTablet(app.man[2], app.color[2], 5000, true);
GraphicsTablet tablet4 = new GraphicsTablet(app.man[3], app.color[1], 2500, false);
GraphicsTablet tablet5 = new GraphicsTablet(app.man[4], app.color[2], 3000, false);

Console.WriteLine("***************************************************"); //TLS

Console.WriteLine("Manufacturer: {0}", tablet.manufacturer); // out
Console.WriteLine("Color: {0}", tablet.color);
Console.WriteLine("Resolution: {0}", tablet.ppi);
Console.WriteLine("Pen Pressure: {0}", tablet.pressure ? "yes" : "no");

Console.WriteLine("***************************************************");

Console.WriteLine("Manufacturer: {0}", tablet2.manufacturer);
Console.WriteLine("Color: {0}", tablet2.color);
Console.WriteLine("Resolution: {0}", tablet2.ppi);
Console.WriteLine("Pen Pressure: {0}", tablet2.pressure ? "yes" : "no");

Console.WriteLine("***************************************************");

Console.WriteLine("Manufacturer: {0}", tablet3.manufacturer);
Console.WriteLine("Color: {0}", tablet3.color);
Console.WriteLine("Resolution: {0}", tablet3.ppi);
Console.WriteLine("Pen Pressure: {0}", tablet3.pressure ? "yes" : "no");

Console.WriteLine("***************************************************");

Console.WriteLine("Manufacturer: {0}", tablet4.manufacturer);
Console.WriteLine("Color: {0}", tablet4.color);
Console.WriteLine("Resolution: {0}", tablet4.ppi);
Console.WriteLine("Pen Pressure: {0}", tablet4.pressure ? "yes" : "no");

Console.WriteLine("***************************************************");

Console.WriteLine("Manufacturer: {0}", tablet5.manufacturer);
Console.WriteLine("Color: {0}", tablet5.color);
Console.WriteLine("Resolution: {0}", tablet5.ppi);
Console.WriteLine("Pen Pressure: {0}", tablet5.pressure ? "yes" : "no");
class Tablet
{ // nzm smije li se

    public string[] man = new string[] { "Wacom", "Huion", "XP-Pen", "Gaomon", "Apple" };
    public string[] color = new string[] { "white", "black", "grey" };

} // nemam pojma
class GraphicsTablet
{
    public string manufacturer; // prikazuje gresku na man, mozda promijeniti ime
    public string color; // opet color 
    public int ppi;
    public bool pressure; // yes true, no false

    public GraphicsTablet(string man, string color, int ppi, bool pressure)
    {
        this.manufacturer = man;
        this.color = color;
        this.ppi = ppi;
        this.pressure = pressure;
    }
}

