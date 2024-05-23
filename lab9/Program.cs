using System;
using System.Collections.Generic;
class Animal{
    public required string Name{get;set;}
    public required int Age{get;set;}
    public virtual void SayInfo(){
        Console.WriteLine($"Hi! My name is {Name} and my age is {Age}");
    }
    public virtual void MakeSound(){
        Console.WriteLine("This animal made a sound");
    }
}
class Dog : Animal{
    public override void MakeSound()
    {
        Console.WriteLine("Woof-woof");
    }
}
class Hamster : Animal{
    
    public override void MakeSound()
    {
        Console.WriteLine("Squeak-squeak");
    }
}
class Perrot : Animal{
    public override void MakeSound()
    {
        Console.WriteLine("Kesha love feed!");
    }
}
class Program
{
    static void Main(){

        List<Animal> animals = new List<Animal>{
            new Dog{Name = "Archi", Age = 6},
            new Hamster{Name = "Homa", Age = 2},
            new Perrot{Name = "Kesha", Age = 8}
        };
        
        foreach(var a in animals){
            a.SayInfo();
            a.MakeSound();
            Console.WriteLine("");
        }

        Console.ReadKey();
    }
}