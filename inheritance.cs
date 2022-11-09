using System;
public class vehicle
{
public string name;
public int id;


class car:vehicle{

public void car_start(){
   Console.WriteLine ("Lst's start the car");
}


}


public static void Main(string[] args){
car c1 = new car();
c1.name("Honda");
c1.id(100);
c1.car_start();

}
}
