
// Console.OutputEncoding = System.Text.Encoding.UTF8;

// string [] posao  = new string[3] {"programer", "devops", "dizajner"};
// string [] ucenik  = new string[3] {"Pero Perić", "Marko Marić", "Maja Perko"};
// int [] ocjena  = new int[3] {2, 3, 5};

// Person user = new Person("Matija", "Katić", 32, posao [0]);
// Person user2 = new Person("Maja", "Perić", 24, posao [2]);
// Person user3 = new Person("Pero", "Perić", 33, posao [1]);
// Person user4 = new Person("Samanta", "Pirić", 20, posao [2]);
// Person user5 = new Person("Nino", "Perić", 50, posao [1]);



// List<Person> userList = new List<Person>();
// List<Person> userList2 = new List<Person>();


// userList.Add(user);
// userList.Add(user2);
// userList.Add(user3);

// userList2.Add(user4);
// userList2.Add(user5);

// PrintUser print = new PrintUser();
// print.printUsers(userList);
// print.printUsers(userList2);



// //forEach Loop
// userList.ForEach(x => {  
// Console.WriteLine("***************************************************");
// Console.WriteLine("Ime i prezime: {0} {1}", x.ime, x.prezime);
// Console.WriteLine("Dob: {0}", x.age); 
// Console.WriteLine("Spol: {0}", x.gender ? "Muško" : "Žensko"); 
// Console.WriteLine("Posao: {0}", x.posao); 
// });



// // Console.WriteLine("Ime i prezime: {0} {1}", user.ime, user.prezime);
// // Console.WriteLine("Dob: {0}", user.age); 
// // Console.WriteLine("Spol: {0}", user.gender ? "Muško" : "Žensko"); 

// // Console.WriteLine("***************************************************");

// // Console.WriteLine("Ime i prezime: {0} {1}", user2.ime, user2.prezime);
// // Console.WriteLine("Dob: {0}", user2.age); 
// // Console.WriteLine("Spol: {0}", user2.gender ? "Muško" : "Žensko"); // ctrl+D multiple word marking
// // //ctrl + C copy line, SHIFT ctrl + C multiple lines
// // Console.WriteLine("***************************************************");
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

// class PrintUser {

//     public void printUsers(list<Person> users) {
// //         users.ForEach(x => {  
// //     Console.WriteLine("***************************************************");
// //     Console.WriteLine("Ime i prezime: {0} {1}", x.ime, x.prezime); //svaki x koji je person imat ce znacajke
// //     Console.WriteLine("Dob: {0}", x.age); 
// //     Console.WriteLine("Spol: {0}", x.gender ? "Muško" : "Žensko"); 
// //     Console.WriteLine("Posao: {0}", x.posao); 
// // });

//     foreach(Person x in users) {
//         Console.WriteLine("***************************************************");
//         Console.WriteLine("Ime i prezime: {0} {1}", x.ime, x.prezime); //svaki x koji je person imat ce znacajke
//         Console.WriteLine("Dob: {0}", x.age); 
//         Console.WriteLine("Spol: {0}", x.gender ? "Muško" : "Žensko"); 
//         Console.WriteLine("Posao: {0}", x.posao); 


//     }

//     }
// }


// // class PrintUser {
// //     users.ForEach(x => {  
// //     Console.WriteLine("***************************************************");
// //     Console.WriteLine("Ime i prezime: {0} {1}", x.ime, x.prezime); //svaki x koji je person imat ce znacajke
// //     Console.WriteLine("Dob: {0}", x.age); 
// //     Console.WriteLine("Spol: {0}", x.gender ? "Muško" : "Žensko"); 
// //     Console.WriteLine("Posao: {0}", x.posao); 

// // }
// // hw 
// // []





// // Tablet app = new Tablet();
// // GraphicsTablet tablet = new GraphicsTablet(app.man[0], app.color[0], 2000, true); // in
// // GraphicsTablet tablet2 = new GraphicsTablet(app.man[1], app.color[1], 3500, true);
// // GraphicsTablet tablet3 = new GraphicsTablet(app.man[2], app.color[2], 5000, true);
// // GraphicsTablet tablet4 = new GraphicsTablet(app.man[3], app.color[1], 2500, false);
// // GraphicsTablet tablet5 = new GraphicsTablet(app.man[4], app.color[2], 3000, false);

// // Console.WriteLine("***************************************************"); //TLS

// // Console.WriteLine("Manufacturer: {0}", tablet.manufacturer); // out
// // Console.WriteLine("Color: {0}", tablet.color);
// // Console.WriteLine("Resolution: {0}", tablet.ppi);
// // Console.WriteLine("Pen Pressure: {0}", tablet.pressure ? "yes" : "no");

// // Console.WriteLine("***************************************************");

// // Console.WriteLine("Manufacturer: {0}", tablet2.manufacturer);
// // Console.WriteLine("Color: {0}", tablet2.color);
// // Console.WriteLine("Resolution: {0}", tablet2.ppi);
// // Console.WriteLine("Pen Pressure: {0}", tablet2.pressure ? "yes" : "no");

// // Console.WriteLine("***************************************************");

// // Console.WriteLine("Manufacturer: {0}", tablet3.manufacturer);
// // Console.WriteLine("Color: {0}", tablet3.color);
// // Console.WriteLine("Resolution: {0}", tablet3.ppi);
// // Console.WriteLine("Pen Pressure: {0}", tablet3.pressure ? "yes" : "no");

// // Console.WriteLine("***************************************************");

// // Console.WriteLine("Manufacturer: {0}", tablet4.manufacturer);
// // Console.WriteLine("Color: {0}", tablet4.color);
// // Console.WriteLine("Resolution: {0}", tablet4.ppi);
// // Console.WriteLine("Pen Pressure: {0}", tablet4.pressure ? "yes" : "no");

// // Console.WriteLine("***************************************************");

// // Console.WriteLine("Manufacturer: {0}", tablet5.manufacturer);
// // Console.WriteLine("Color: {0}", tablet5.color);
// // Console.WriteLine("Resolution: {0}", tablet5.ppi);
// // Console.WriteLine("Pen Pressure: {0}", tablet5.pressure ? "yes" : "no");
// // class Tablet
// // { // nzm smije li se

// //     public string[] man = new string[] { "Wacom", "Huion", "XP-Pen", "Gaomon", "Apple" };
// //     public string[] color = new string[] { "white", "black", "grey" };

// // } // nemam pojma
// // class GraphicsTablet
// // {
// //     public string manufacturer; // prikazuje gresku na man, mozda promijeniti ime
// //     public string color; // opet color 
// //     public int ppi;
// //     public bool pressure; // yes true, no false

// //     public GraphicsTablet(string man, string color, int ppi, bool pressure)
// //     {
// //         this.manufacturer = man;
// //         this.color = color;
// //         this.ppi = ppi;
// //         this.pressure = pressure;
// //     }
// // }

// //task
// int [] brojevi = new int [4] { 2, 4, 6, 8};
// int [] drugiBrojevi = new int [4] { 1, 3, 5, 7};

// Mnozenje rezultat = new Mnozenje();
// rezultat.kvadriranje(drugiBrojevi);

// Mnozenje drugiRezultat = new Mnozenje();
// rezultat.kvadriranje(drugiBrojevi);

// class Mnozenje {

//     public void kvadriranje (int[] data) {
//         Console.WriteLine ("POČETAK");
//         foreach(int x in data) {
//             Console.WriteLine ("Broj x " + x);
//             Console.WriteLine (x * x);


//         }
//         Console.WriteLine ("KRAJ");
//     }
// }

string [] ucenik  = new string[5] {"Mateo Marić", "Maja Zvekić", "Niko Jelić", "Samanta Pirić", "Nino Perić"};
int [] ocjena  = new int[5] {1, 2, 3, 4, 5};

Student user = new Student("Mateo", "Marić", 13, 4);
Student user2 = new Student("Maja", "Zvekić", 14, 5);
Student user3 = new Student("Niko", "Jelić", 15, 4);
Student user4 = new Student("Samanta", "Pirić", 14, 3);
Student user5 = new Student("Nino", "Perić", 14, 2);


List<Student> userList = new List<Student>();

userList.Add(user);
userList.Add(user2);
userList.Add(user3);
userList.Add(user4);
userList.Add(user5);

PrintBook print = new PrintBook();
PrintBook.printStudent(userList);

class Student
{
    public string ime;
    public string prezime;
    public int age;
    public int ocjena;

    public Student (string ime, string prezime, int age, int ocjena) {
        this.ime = ime;
        this.prezime = prezime;
        this.age = age;
        this.ocjena = ocjena;
    }
}

class PrintBook {
public void printStudent(List<Student> users) {
    foreach(Student x in users) {      
        Console.WriteLine("***************************************************");
        Console.WriteLine("Ime i prezime: {0} {1}", x.ime, x.prezime);
        Console.WriteLine("Dob: {0}", x.age); 
        Console.WriteLine("Završna ocjena: {0}", x.ocjena); 
}
}
}