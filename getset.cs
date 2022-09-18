//use of setter and getter method

using System;

 class student
{
  private  int id;
  private string name;

  public void setName(string name){ //this is setter method which is used here to set the name which is private porperty..
   this.name=name;
 }
 public string getName(){  //this is getter method which is used here to get the name which is private porperty..
  return this.name;
 }

  public void setId( int id){
   this.id=id;
 }


 public int getId(){
   return this.id;
 }
 

public static void Main(string [] args){

student s1 = new student();
//calling stetter method
s1.setName("sudip");
s1.setId(1);
//getter method and print the value
Console.WriteLine("Name of the student is " + s1.getName());
Console.WriteLine( "Id of the student is " + s1.getId());
Console.ReadLine();

}
}