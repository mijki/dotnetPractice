using dotnetPractice.Interfaces;

namespace dotnetPractice.Classes
{
    public abstract class Human
    {
        public string Name {get; set;}
        public int Age {get; set;}

        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void WelcomingMessage();
    }

    public class Student : Human
    {
        public int AuthorizationLevel {get; set;}
        public int Grade {get; set;}
        
        public Student (string name, int age, int AuthorizationLevel, int grade) : base( name, age)
        {
            this.AuthorizationLevel = AuthorizationLevel;
            this.Grade = grade;
        }
        public override void WelcomingMessage()
        {
            Console.WriteLine("Student class message");
        }
    }

    public class Principal : Human
    {
        public int AuthorizationLevel {get; set;}
        public int YearsOfExperience {get; set;}

        public Principal (string name, int age, int AuthorizationLevel, int YearsOfExperience) : base( name, age)
        {
            this.AuthorizationLevel = AuthorizationLevel;
            this.YearsOfExperience = YearsOfExperience;
        }

        public override void WelcomingMessage()
        {
            Console.WriteLine("Principal class message");
        }
    }

    public abstract class GeometryCalculator : IGeometryCalculator
    {
        protected decimal area;
        internal decimal volume;

        protected decimal GetArea()
        {
            return area;
        }

        protected void SetArea(decimal area)
        {
            this.area = area;
        }

        internal decimal GetVolume()
        {
            return volume;
        }

        internal void SetVolume(decimal volume)
        {
            this.volume = volume;
        }

        public abstract double CalculateArea();
        public abstract double CalculateVolume();
    }

    public class Sphere : GeometryCalculator
    {
        private double radius;

        public Sphere(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea()
        {
            return 4 * Math.PI * Math.Pow(radius, 2);
        }

        public override double CalculateVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }
    }

    public class Rectangle : GeometryCalculator
    {
        private double length;
        private double width;
        private double height;

        public Rectangle(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public override double CalculateArea()
        {
            return length * width;
        }

        public override double CalculateVolume()
        {
            return length * width * height;
        }
    }

    public class Cone : GeometryCalculator
    {
        private double radius;
        private double height;

        public Cone(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public override double CalculateArea()
        {
            double slantHeight = Math.Sqrt(Math.Pow(radius, 2) + Math.Pow(height, 2));
            return Math.PI * radius * (radius + slantHeight);
        }

        public override double CalculateVolume()
        {
            return (1.0 / 3.0) * Math.PI * Math.Pow(radius, 2) * height;
        }
    }


}
    
