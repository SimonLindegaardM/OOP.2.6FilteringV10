namespace FilteringV10
{
    public class FilterBelow20 : IFilterCondition
    {
        public bool Condition(int value)
        {
            return value <20;
        }
    }
}