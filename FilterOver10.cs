namespace FilteringV10
{
    public class FilterOver10 : IFilterCondition
    {
        public bool Condition(int value)
        {
            return value >10;
        }
    }
}