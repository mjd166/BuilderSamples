using OrderFoodSample;

var director = new MealDirector();

Console.WriteLine("--Fast Food Meal--");
var fastfoodbuilder = new FastFoodMealBuilder();
var fastfoodmeal=director.Construct(fastfoodbuilder);
fastfoodmeal.ShowMeal();

Console.WriteLine("\n -- healthy Meal--");
var healthymealbuilder= new HealthyMealBuilder();   
var healthymeal=director.Construct(healthymealbuilder);
healthymeal.ShowMeal();


