
using System;

public class Student {

	
	private string name = "BCA";

	// Declare name property
	public string Name
	{

	get{return name;}

	set{name = value;}
	}
}

class Test{

	public static void Main(string[] args)
	{
		Student s1 = new Student();
		s1.Name = "Roshan";
		Console.WriteLine("Name: " + s1.Name);
	}
}
