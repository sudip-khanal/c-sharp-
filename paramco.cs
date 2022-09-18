//parameterized constructor

using System;

class student
{

    int id;
    string name;
    string college;

public student( int Id,string Name,string College){ // here id name and college are 3 argument/parameter of constructor srudent
   this.id=Id;
   this.name=Name;
   this.college=College;

}

public static void Main(string [] args){

student s1= new student(1,"sudip","morgan");

Console.WriteLine("student Id: {0}, Name:{1}, College:{2}",s1.id,s1.name ,s1.college );
Console.ReadLine();

}
}