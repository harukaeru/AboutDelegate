using System;

public class GenericTest {
	public static void Main(string[] args){
		//１つクラスを定義しただけなのに、
		//様々な型に対してタイプセーフに使うことができる
		Gen<string> stringGen = new Gen<string>("hoge");
		Gen<int> intGen = new Gen<int>(2);

		//型名が表示される。普通はprivateにする。
		Console.WriteLine(stringGen);
		Console.WriteLine(intGen);
		Console.WriteLine("---------------");
		//それぞれ代入した値を取り出している。
		Console.WriteLine(stringGen.GetObj());
		Console.WriteLine(intGen.GetObj());
	}
}

class Gen<T> {
	//普通はここはprivateにする。
	public T tObj;

	public Gen(T tObj){
		this.tObj = tObj;
	}

	public T GetObj(){
		return tObj;
	}
}
