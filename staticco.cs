//static  constructor

using System;

public class bus
{
    
   public string Bus_name="Sajha";

  public void display(){
    Console.WriteLine(Bus_name);
  }

 static void dis(){
  Console.WriteLine("This is a static constructor");
 }


public static void Main(string [] args){

 bus b1= new bus();
 b1.display();
 //caling static method
 dis();
}
}