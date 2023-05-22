using OOPS;
using System;

Console.WriteLine("Hello World!");

Customer obj = new Customer();
//obj.displayData();

//fields calling
Console.WriteLine("Customer=" + obj.CustID);
Console.WriteLine("Name=" + obj.Name);
Console.WriteLine("Adress=" + obj.Address);

// FunOverLoad obj1 = new FunOverLoad();

// obj1.setName("Tom");
// Console.WriteLine("Name=" + obj1.name);

// obj1.setName("Tom", "Jerry");
// Console.WriteLine("Name=" + obj1.name);

// obj1.setName("Tom", "Jerry", "Spike");
// Console.WriteLine("Name=" + obj1.name);


PartialPart obj1 = new PartialPart();
obj1.displayData1();
obj1.displayData2();

//Encapsulation
Encapsulation objencaps = new Encapsulation(60);
objencaps.MySquare();

//Inheritance
Father objfather = new Father();
objfather.FatherMethod();
//Here Child object can access both class methods
Child objchild = new Child();
objchild.FatherMethod();
objchild.ChildMethod();

