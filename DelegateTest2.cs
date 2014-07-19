using System;

public delegate void MethodsAsClass();


public class DelegateTest2 {
	public static MethodsAsClass method;
	
	public static void Main(string[] args) {
		method = new MethodsAsClass(AnotherClass.OutHoge);
		method += new MethodsAsClass(AnotherClass.OutHello);

		method();
	}
}

class AnotherClass {
	public static void OutHoge(){
		Console.WriteLine("Hoge");
	}
	public static void OutHello(){
		Console.WriteLine("Hello");
	}
}
