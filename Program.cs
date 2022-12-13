using System;

class Animal
{
    public void eat()
    {
        Console.WriteLine("Los animales comen.");
    }
}

class Kryptonian : Animal
{

}

class Vehicle 
{

}


//interface principal
interface Flyer
{
     void takeOff();
     void land();
     void fly();
 
}

//interface superman hereda de kryptonian

class Superman : Kryptonian, Flyer
{
    public void takeOff()
    {
        Console.WriteLine("\nTodos se quitan.");
    }

    public void land()
    {
        Console.WriteLine("\nTodos se mueven por la tierra");
    }

    public void leapBuilding()
    {
        Console.WriteLine("\nLes gusta saltar");
    }

    public void stopBullet()
    {
        Console.WriteLine("\nSe detienen constantemente");
    }

    public void fly()
    {
        Console.WriteLine("\nPuede volar.");
    }
    public void eat()
    {
        Console.WriteLine("\nTodos comen");
    }
}

class Bird : Flyer
{
    public void takeOff() { }
    public void land() { }
    public void fly() { }
    public void buildNest() { }
    public void layEggs() { }
    public void eat() { }
}

class Airplane : Vehicle, Flyer
{
    public void takeOff() { }
    public void land() { }
    public void fly() { }
}

class SeaPlane : Airplane
{

}

class Helicopter : Airplane
{
    
}

//tester-class

class Program
{
     static void Main()
    {
        Animal animal = new Animal();
        animal.eat();

        //Superman
        Superman superman = new Superman();
        superman.fly();
        superman.eat();
        superman.land();
        superman.leapBuilding();
        superman.stopBullet();
        superman.takeOff();
    }
}