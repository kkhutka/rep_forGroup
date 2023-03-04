using System;

class MainClass {
  static void Main(string[] args) {
    // Read the first integer from the user
    Console.Write("Enter the first integer: ");
    int num1 = int.Parse(Console.ReadLine());

    // Read the second integer from the user
    Console.Write("Enter the second integer: ");
    int num2 = int.Parse(Console.ReadLine());

    // Read the operator from the user
    Console.Write("Enter an operator (+, -, *, /): ");
    char op = char.Parse(Console.ReadLine());

    // Perform the requested operation
    int result = 0;
    switch (op) {
      case '+':
        //result = call_your_funtion;
        break;
      case '-':
        //result = call_your_funtion;
        break;
      case '*':
        //result = call_your_funtion;
        break;
      case '/':
        //result = call_your_funtion;
        break;
      default:
        Console.WriteLine("Invalid operator entered.");
        return;
    }

    // Display the result to the user
    Console.WriteLine("Result: " + result);
  }
}