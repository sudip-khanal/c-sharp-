using System;
 interface Calc {
      
   int calculator(int a, int b);
   float calculation(float x,float y);
   
}

class Sum : Calc{
    public int calculator(int a, int b){
    int sum = a+b;
      return sum;
      }

 public  float calculation(float x,float y){
      float s = x+y;
         return s;
      }

}

class Diff : Calc{
   public int calculator(int a, int b){
    int diff = a-b;
     return diff;
      }


   public  float calculation(float x, float y){
      float d = x-y;
         return d;
 }
    
}

class Mull : Calc{
      public int calculator(int a, int b){
         int mul = a*b;
          return mul;
          }


      public  float calculation(float x,float y){
         float m = x*y;
          return m;
 }
}


class div : Calc{
      public int calculator(int a, int b){
         int div = a/b;
          return div;
          }


      public  float calculation(float x,float y){
         float z = x/y;
            return z;
 }
}


 class mainclass {
    public static void Main (string [] args){
      
    Sum s1 = new Sum();
    Diff d1 = new Diff();
    Mull m1 = new Mull();
    div dv = new div();

   
   // int return type

     Console.WriteLine("Sum class result =" + s1.calculator(2,3)); 
     Console.WriteLine("Diff class result =" + d1.calculator(5,3));
     Console.WriteLine("Mul class result =" + m1.calculator(2,3));
     Console.WriteLine("div class result =" + dv.calculator(6,3));



    // float retutn type 

     Console.WriteLine("Sum class result =" + s1.calculation(2,3)); 
     Console.WriteLine("Diff class result =" + d1.calculation(3,5));
     Console.WriteLine("Mul class result =" + m1.calculation(2,3));
     Console.WriteLine("div class result =" + dv.calculation(2,3));
      
    }
 }