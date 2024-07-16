using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiCalculator.Models
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age {  get; set; }
        public double Height { get; set; } = 5;
        public int Weight { get; set; } = 50;

        public Person(int id,string name,int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }
        public Person(int id, string name, int age, int height, int weight) : this(id, name, age)
        {
            Height = height;
            Weight = weight;
        }

        public override string ToString()
        {
            string title = "==================Details of individuals:==========================";
            return $"{title}\n" +
                $"Id: {Id}\nName: {Name}\nAge: {Age}yrs\nHeight: {Height}ft\nWeight: {Weight}kg\n";
        }

        public static double CalculateBmiScore(Person person)
        {
            double ht = Math.Round((person.Height/3.281),2);
            double result = person.Weight / (ht * ht);
            return result;
        }


    }
}
