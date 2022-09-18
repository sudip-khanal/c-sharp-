using System;
class Program{

public static void Main(string[] args){

int  num;
 Console.WriteLine("Enter The Number :");
 num= Convert.ToInt32(Console.ReadLine());

if(num==0){
    Console.WriteLine( num + " Zero is neithe even nor odd");

}
else if(num%2==0){
    Console.WriteLine( num + " is Even Number");

}
else{
    Console.WriteLine( num + " is Odd Number");
}
 Console.ReadLine();

}

}