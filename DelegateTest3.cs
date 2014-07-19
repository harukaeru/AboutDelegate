using System;

public delegate void MethodsAsClass();


public class DelegateTest3 {
	public static MethodsAsClass method;
	
	public static void Main(string[] args) {
		method = AnotherClass.OutHoge;
		method += AnotherClass.OutHello;

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
