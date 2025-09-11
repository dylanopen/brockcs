namespace Program {
    public class Program {
	public static void Main(String[] args) {
	   String rocket = """
      ***
     *****
    *******
    *******
    *******
    *******
    *******
    *******
    *******
    *******
      ***
     *****
""";

	   for (int i=8; i>0; i--) {
		System.Threading.Thread.Sleep(1000);
		Console.Clear();
		for (int j=0; j<i; j++)
		   Console.WriteLine();
		Console.WriteLine(rocket);
	   }
	}
    }
}
