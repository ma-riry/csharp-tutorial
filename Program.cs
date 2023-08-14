Console.OutputEncoding = System.Text.Encoding.UTF8;

Person user = new Person("Matija", "Katić", 32, true);
Person user2 = new Person("Maja", "Perić", 24, false);

Console.WriteLine("***************************************************");

Console.WriteLine("Ime i prezime: {0} {1}", user.ime, user.prezime);
Console.WriteLine("Dob: {0}", user.age); 
Console.WriteLine("Spol: {0}", user.gender ? "Muško" : "Žensko"); 

Console.WriteLine("***************************************************");

Console.WriteLine("Ime i prezime: {0} {1}", user2.ime, user2.prezime);
Console.WriteLine("Dob: {0}", user2.age); 
Console.WriteLine("Spol: {0}", user2.gender ? "Muško" : "Žensko"); // ctrl+D multiple word marking
//ctrl + C copy line, SHIFT ctrl + C multiple lines
Console.WriteLine("***************************************************");
class Person {
    public string ime;
    public string prezime; 
    public int age;
    public bool gender; // male true, female false

    public Person (string ime, string prezime, int age, bool gender) {
        this.ime = ime;
        this.prezime = prezime;
        this.age = age;
        this.gender = gender;
    }
}

// hw


