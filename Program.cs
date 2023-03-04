using System;

class MainClass {


  static int minus(int a,int b){
    return a-b;
  }


  static int mult(int a, int b)
  {
    return a*b;
  }

    static double div(int a,int b) {
        return a / b;
    }

    static  int Addition(int a, int b) {
	  return a+b;
    }




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
        result = Addition(num1,num2);
        break;
      case '-':
        result = minus(num1,num2);
        break;
      case '*':
        result = mult(num1,num2);
        break;
      case '/':
        result = div(num1, num2);
        break;
      default:
        Console.WriteLine("Invalid operator entered.");
        return;
    }

    // Display the result to the user
    Console.WriteLine("Result: " + result);
  }
}
