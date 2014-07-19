using System;

public delegate void MyEventHandler(object sender, EventArgs e);


public class DelegateTest4 {
	public static event MyEventHandler realEvent;
	
	public static void Main(string[] args) {
		object sender = null;
		EventArgs e = null;

		realEvent = AnotherClass.OutHoge;
		realEvent = AnotherClass.OutHello;

		realEvent(sender, e);
	}
}

class AnotherClass {
	public static void OutHoge(object sender, EventArgs e){
		Console.WriteLine("Hoge");
	}
	public static void OutHello(object sender, EventArgs e){
		Console.WriteLine("Hello");
	}
}
