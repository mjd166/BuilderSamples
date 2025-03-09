namespace OrderFoodSample
{
    /// <summary>
    /// Director 
    /// </summary>
    public class MealDirector
    {
        public Meal Construct(IMealBuilder builder)
        {
            builder.BuildMainCourse();
            builder.BuildDrink();
            builder.BuildDesert();
            return builder.Build();
        }
    }
}
