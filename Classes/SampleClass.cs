// Usings are here when you have to external files, sources, etc.
using dotnetPractice.Interfaces;

// Where can you find your class?
namespace dotnetPractice.Classes
{
    // Class of your file [access modifier] + (static) + class + name
    public class SampleClass
    {
        // How classes should build up?
        // 1. Fields
        // Fields: These are variables that hold data for an object. 
        // They are declared at the class level and can have various access modifiers, such as public, private, or protected. For example:
        public string CarManufacturer {get; set;}
        internal string Type {get; set;}
        public bool IsElectric;

        // 2. Properties: These are similar to fields, but they are accessed through methods rather than directly. 
        // They are typically used to control access to a field or to perform additional logic when getting or setting a value. For example:
        public decimal Price{
            get{
                return Price;
            }
            set{
                if(value > 0){
                    Price = value;
                }
            }
        }

        public bool IsElectricCar()
        {
            return this.IsElectric;
        }

        public string SetCarManufacturer(string manufacturer)
        {
            return this.CarManufacturer = manufacturer;
        }

        // 3. Constructors:  These are special methods that are used to create and initialize objects. 
        // They have the same name as the class and can have various parameters. For example:
        public SampleClass(string carManufacturer, string type, bool isElectric)
        {
            this.CarManufacturer = carManufacturer;
            this.Type = type;
            this.IsElectric = isElectric;
        }

        // 4. Methods: After the constructor you can write the class related methods. For example:
        // If I use "static" decorator I can call it directly, if not, I have to create an instance for it (+ I can use with Interfaces)
        public bool IsThisCarExpensive(decimal price)
        {
            if(price > 10000){
                return true;
            }
            return false;
        }


    }
}