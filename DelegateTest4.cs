using System;

public delegate void ImitationOfEvent(object sender, EventArgs e);


public class DelegateTest4 {
	public static ImitationOfEvent likeEvent;
	
	public static void Main(string[] args) {
		object sender = null;
		EventArgs e = null;

		likeEvent = AnotherClass.OutHoge;
		likeEvent += AnotherClass.OutHello;

		likeEvent(sender, e);
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
