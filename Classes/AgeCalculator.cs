using dotnetPractice.Interfaces;

namespace dotnetPractice.Classes
{
    public class AgeCalculator : IAgeCalculator
    {
        public int CalculateAge(DateTime birthDate)
        {
            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
                age--;
            return age;
        }
    }
}