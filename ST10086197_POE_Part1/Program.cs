using System;

class Program
{
    private int numIngredients;
    private string[] ingredientNames;
    private double[] ingredientQuantities;
    private string[] ingredientUnits;
    private int numSteps;
    private string[] steps;

    public Program()
    {
        numIngredients = 0;
        numSteps = 0;
    }

    public void SetIngredients(int numIngredients)
    {
        this.numIngredients = numIngredients;
        ingredientNames = new string[numIngredients];
        ingredientQuantities = new double[numIngredients];
        ingredientUnits = new string[numIngredients];

        for (int i = 0; i < numIngredients; i++)
        {
            Console.WriteLine("Enter ingredient name:");
            ingredientNames[i] = Console.ReadLine();

            Console.WriteLine("Enter ingredient quantity:");
            ingredientQuantities[i] = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter ingredient unit of measurement:");
            ingredientUnits[i] = Console.ReadLine();
        }
    }

    static void Main(string[] args)
    {
        Program recipe = new Program();

        Console.WriteLine("Enter the number of ingredients:");
        int numIngredients = int.Parse(Console.ReadLine());
        recipe.SetIngredients(numIngredients);

        

   
    }
}

