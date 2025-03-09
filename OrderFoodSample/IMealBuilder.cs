namespace OrderFoodSample
{
    public interface IMealBuilder
    {
        void BuildMainCourse();
        void BuildDrink();
        void BuildDesert();
        Meal Build();
    }
}
