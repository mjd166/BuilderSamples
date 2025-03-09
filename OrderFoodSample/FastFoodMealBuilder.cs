namespace OrderFoodSample
{
    /// <summary>
    /// Concrete class
    /// </summary>
    public class FastFoodMealBuilder : IMealBuilder
    {
        private readonly Meal _meal = new Meal();
        public Meal Build() => _meal;

        public void BuildDesert() => _meal.MainCourse = "Burgur";

        public void BuildDrink() => _meal.Drink = "Cola";

        public void BuildMainCourse() => _meal.Desert = "Ice Cream";

    }

}
