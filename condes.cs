//constructor and destructor
// in c# class name and constructor must be same.....

using System;
class car{


public car(){ //constructor
    Console.WriteLine("car is being purchased........");

}

~car(){ //~ symbole is use to define the destructer 
    Console.WriteLine("car is sold........");
}

public static void Main(string [] args){
  car obj  = new car();
  Console.ReadLine();

}

}