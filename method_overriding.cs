
using System;

class Appple {

	// show() is 'virtual' here
	public virtual void show()
	{
		Console.WriteLine("Appple class");
	}
}


// class 'baseClass' inherit
// class 'derived'
class Mango : Appple
{
	
	//'show()' is 'override' here
	public override void show()
	{
		Console.WriteLine("Mango class");
	}
}

class fruits {
	
	// Main Method
	public static void Main(string [] args)
	{
		
		Appple obj;

	
		obj = new Appple();
		

		obj.show();
		

		obj = new Mango();
		
		obj.show();
		
	}
}
