using dotnetPractice.Classes;
using dotnetPractice.Interfaces;

// 101: Static or Non-Static methods
MethodTypes.MyStaticMethod(); // Call static method on the class itself

MethodTypes myObject = new MethodTypes();
myObject.MyNonStaticMethod(); // Call non-static method on an instance of the class

// 101: Access modifiers

// 4 Rules of OOP
// 1. Encapsulation
Console.WriteLine("\nEncapsulation");

var bankAccount = new Encapsulation.BankAccount();
bankAccount.Deposit(100);
bankAccount.Withdraw(50);
Console.WriteLine(bankAccount.GetBalance());

// 2. Abstraction
Console.WriteLine("\nAbstraction");
var ageCalculator = new AgeCalculator();
Console.WriteLine($"Your age from direct method call is: {ageCalculator.CalculateAge(new DateTime(1995, 09, 05))}");

IAgeCalculator IageCalculator = new AgeCalculator();
Console.WriteLine($"Your age from through an interface call is: {IageCalculator.CalculateAge(new DateTime(2002, 05, 15))}");

// 3. Inheritance
Console.WriteLine("\nInheritance");
var student = new Student("John", 20, 1, 10);
student.WelcomingMessage();

var principal = new Principal("Jane", 40, 2, 20);
principal.WelcomingMessage();

// 4. Polymorphism
Console.WriteLine("\nPolymorphism");
Sphere sphere = new Sphere(5);
Console.WriteLine($"The area of the Sphere with direct call: {sphere.CalculateArea()}");
Console.WriteLine($"The volume of the Sphere with direct call: {sphere.CalculateVolume()}");

IGeometryCalculator Isphere = new Sphere(10);
Console.WriteLine($"The area of the Sphere though interface: {Isphere.CalculateArea()}");
Console.WriteLine($"The volume of the Sphere though interface: {Isphere.CalculateVolume()}");

