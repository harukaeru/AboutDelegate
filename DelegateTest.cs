using System;

public delegate void MethodsAsClass();


public class DelegateTest {
	public static MethodsAsClass method;
	
	public static void Main(string[] args) {
		method = new MethodsAsClass(AnotherClass.OutHoge);

		method();
	}
}

class AnotherClass {
	public static void OutHoge(){
		Console.WriteLine("Hoge");
	}
}
