using System; 

public class Program {

  public static void Main(string[] args) {
    for (int n = 0; n < 11; n++)
    {
    Console.WriteLine("Input name:");
    string name = Console.ReadLine();
    Console.WriteLine("Input height in inches:");
    double height = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Input weight in pounds:");
    double weight = Convert.ToDouble(Console.ReadLine());
    double bmi = ((703 * weight)/(height * height));
    if (bmi<18.5)
    {
      Console.WriteLine(name + " is underweight.");
    }
    else if (bmi<24.9)
    {
      Console.WriteLine(name + " is healthy weight.");
    }
    else if (bmi<29.9)
    {
      Console.WriteLine(name + " is overweight.");
    }
    else
    {
      Console.WriteLine(name + " is obese.");
    }
    }
  }
}