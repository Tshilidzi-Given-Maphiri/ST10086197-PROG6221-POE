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
        //adds the user input into a new array of a different name in order to hold the steps for the ingredients.
        ingredientNames = new string[numIngredients];
        ingredientQuantities = new double[numIngredients];
        ingredientUnits = new string[numIngredients];

        // a for loop, that runs depending on the number of ingredients stated by the user.
        for (int i = 0; i < numIngredients; i++)
        {
            //user prompt
            Console.WriteLine("Enter ingredient name:");
            //stores imnput into the array
            ingredientNames[i] = Console.ReadLine();

            Console.WriteLine("Enter ingredient quantity:");
            ingredientQuantities[i] = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter ingredient unit of measurement:");
            ingredientUnits[i] = Console.ReadLine();
        }
    }

    public void SetSteps(int numSteps)
    {
        this.numSteps = numSteps;
        steps = new string[numSteps];

        for (int i = 0; i < numSteps; i++)
        {
            Console.WriteLine($"Enter step {i + 1}:");
            steps[i] = Console.ReadLine();
        }

        
    }

    static void Main(string[] args)
    {
        Program recipe = new Program();

        Console.WriteLine("Enter the number of ingredients:");
        int numIngredients = int.Parse(Console.ReadLine());
        recipe.SetIngredients(numIngredients);

        Console.WriteLine("Enter the number of steps:");
        int numSteps = int.Parse(Console.ReadLine());
        recipe.SetSteps(numSteps);


    }
}

