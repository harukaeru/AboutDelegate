using System;

public class Inttest
{
	public static void Main(string[] args)
	{
		3.Times(() => Console.WriteLine("hoge"))();
	}
}

static class Extensions
{
	public static Action Times(this int count, Action method)
	{
		return delegate() { for(int i = 0; i < count; i++)
			{
				method();
			}
		};
	}
}

