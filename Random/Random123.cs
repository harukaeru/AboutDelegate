using System;
public class Random123 {
	public static void Main(string[] args) {
		Random random1 = new Random(1);
		int firstNumber = random1.Next(0, 10);

		Random random2 = new Random(1);
		int secoundNumber = random2.Next(0, 10);
		
		Random random3 = new Random(1);
		int thirdNumber = random3.Next(0, 10);

		Console.WriteLine(string.Format("{0}:{1}:{2}",firstNumber,secoundNumber,thirdNumber));
	}
}
