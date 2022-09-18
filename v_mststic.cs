 
 //static varible and method
 using System;

 class  meeting
 {
 string present_time;
 string club_name;
 static string country= "Nepal"; // static variable

 public meeting(string club_name,string present_time){  //parametrized constructor
    this.club_name=club_name;
    this.present_time=present_time;
 }
 static void meet(){   //static method 
            Console.WriteLine("The club are registerd under the rule of nepal government");
 }
 
 public void display(){  
        Console.WriteLine( club_name+ " " +  present_time +" ");
        }

    public static void Main( string [] args){

   meeting m1 = new meeting("Itcan","7am"); 
   m1.display();
   Console.WriteLine(meeting.country);
   meet();
   Console.ReadLine();

    }
}