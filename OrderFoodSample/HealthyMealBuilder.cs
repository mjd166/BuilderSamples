namespace OrderFoodSample
{
    /// <summary>
    /// Concrete class 2
    /// </summary>

    public class HealthyMealBuilder : IMealBuilder
    {
        private readonly Meal _meal = new Meal();

        public Meal Build()=>_meal;

        public void BuildDesert() => _meal.Desert = "Fruit Bowl";
        public void BuildDrink() => _meal.Drink = "Water";

        public void BuildMainCourse() => _meal.MainCourse = "Grilled Chicken Salad";
    }

}
