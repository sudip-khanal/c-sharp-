using System;
public class calculate
{

public int  add( int a,int b){
    int sum=a+b;
    return sum;


}

public int  add( int a, int b, int c){
    int sum = a+b+c;
    return sum;
}
   
public static void Main(string [] args){

calculate cal = new calculate();
int sum1 = cal.add(1, 2);
Console.WriteLine("sum of the two :"  + sum1);
int sum2 = cal.add(1, 2, 3);
Console.WriteLine("sum of the three  : " + sum2);

}


}