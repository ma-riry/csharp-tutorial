string [] man = new string [] {"Wacom", "Huion", "XP-Pen", "Gaomon", "Apple"};
string [] color = new string [] {"white", "black", "grey"};


Object tablet = new Object(man[0], color[0], 2000, true); // in
Object tablet2 = new Object(man[1], color[1], 3500, true);
Object tablet3 = new Object(man[2], color[2], 5000, true);
Object tablet4 = new Object(man[3], color[1], 2500, false);
Object tablet5 = new Object(man[4], color[2], 3000, false);

Console.WriteLine("***************************************************");

Console.WriteLine("Manufacturer: {0}", tablet.man [0]); // out
Console.WriteLine("Color: {0}", tablet.color [0]);
Console.WriteLine("Resolution: {0}", tablet.ppi); 
Console.WriteLine("Pen Pressure: {0}", tablet.pressure ? "yes" : "no"); 

Console.WriteLine("***************************************************");

Console.WriteLine("Manufacturer: {1}", tablet2.man[1]); 
Console.WriteLine("Color: {1}", tablet2.color[1]);
Console.WriteLine("Resolution: {0}", tablet2.ppi); 
Console.WriteLine("Pen Pressure: {0}", tablet2.pressure ? "yes" : "no"); 

Console.WriteLine("***************************************************");

Console.WriteLine("Manufacturer: {2}", tablet3.man[2]); 
Console.WriteLine("Color: {2}", tablet3.color[2]);
Console.WriteLine("Resolution: {0}", tablet3.ppi); 
Console.WriteLine("Pen Pressure: {0}", tablet3.pressure ? "yes" : "no"); 

Console.WriteLine("***************************************************");

Console.WriteLine("Manufacturer: {3}", tablet4.man[3]); 
Console.WriteLine("Color: {1}", tablet4.color[1]);
Console.WriteLine("Resolution: {0}", tablet4.ppi); 
Console.WriteLine("Pen Pressure: {0}", tablet4.pressure ? "yes" : "no"); 

Console.WriteLine("***************************************************");

Console.WriteLine("Manufacturer: {4}", tablet5.man[4]); 
Console.WriteLine("Color: {2}", tablet5.color[2]);
Console.WriteLine("Resolution: {0}", tablet5.ppi); 
Console.WriteLine("Pen Pressure: {0}", tablet5.pressure ? "yes" : "no"); 

class Object {
    public string man;
    public string color; 
    public int ppi;
    public bool pressure; // yes true, no false

    public Object (string man, string color, int ppi, bool pressure) {
        this.man = man;
        this.color = color;
        this.ppi = ppi;
        this.pressure = pressure;
    }
}