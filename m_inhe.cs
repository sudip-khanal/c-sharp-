using System;

public class Animal{

    public string name ="Tiger";

    public void speak(){
        Console.WriteLine("roreeeeeeeeeeee>>......");
    }
}



class Tiger: Animal{

}


class Cat:Tiger{
     public new void speak(){
        Console.WriteLine("meauuuu");
    }
}

class Cow : Cat{
    public new void speak(){
        Console.WriteLine("Moooooooooooooooo.........");
    }

}
class mainclass{
    public static void Main (string [] args){
        Cat c1=new Cat();
        Cow o1 = new Cow();

        o1.speak();
        c1.speak();
    } 
}