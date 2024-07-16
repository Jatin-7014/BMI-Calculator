using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BmiCalculator.Models;

namespace BmiCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons= new Person[]{new Person(101, "Billu", 21),
            new Person(102, "Jatin", 22, 6, 50) };

            ShowDetails(persons);
        }

        static void ShowDetails(Person[] persons)
        {
            foreach (Person person in persons)
            {
                Console.WriteLine(person);

                double BmiScore = Math.Round(Person.CalculateBmiScore(person), 3);
                Console.WriteLine($"BmiScore: {BmiScore}");
                BodyType(BmiScore);
            }
        }
        static void BodyType(double BmiScore)
        {
            if(BmiScore>=18.5 && BmiScore<=24.9)
                Console.WriteLine($"Your BodyType is normal based on your BMI Score\n");
            else if(BmiScore>=25)
                Console.WriteLine($"Your BodyType is over-weight based on your BMI Score\n");
            else
                Console.WriteLine($"Your BodyType is under-weight based on your BMI Score\n");
        }
    }
}
