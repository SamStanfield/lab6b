using System;
using System.Linq;
class MainClass {
  public static void Main (string[] args) {
    int len = 10;
    int[] height = new int[len];
    int[] weight = new int[len];
    double[] BMI = new double[len];

    for(int counter = 0; counter < len; counter++)
    {
      Console.WriteLine("Input your Height in inches.");
      height[counter] = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Input your weight in lbs.");
      weight[counter] = Convert.ToInt32(Console.ReadLine());
     BMI[counter] = (weight[counter] * 703)/(height[counter] * height[counter]);
    }
    for(int counter=0; counter < len; counter++)
    {
      Console.WriteLine("BMI for person " + (counter + 1) + " = " + BMI[counter]);

      if(BMI[counter] <= 18.5)
      {
        Console.WriteLine("Person " + (counter + 1) + " is underweight.");
      }
      if(BMI[counter] > 18.5 || BMI[counter] <= 24.9)
      {
        Console.WriteLine("Person " + (counter + 1) + " is normal.");
      }
      if(BMI[counter] > 25.0 || BMI[counter] <= 29.9)
      {
        Console.WriteLine("Person " + (counter + 1) + " is overweight.");
      }
      if(BMI[counter] > 30)
      {
        Console.WriteLine("Person " + (counter + 1) + " is obese");
      }
    }
    


   
  }
}