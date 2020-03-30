using System.Collections.Generic;

namespace FilteringV10
{
    /// <summary>
    /// Class capable on filtering a List of integers.
    /// Current filtering condition:
    /// Include values larger than 10.
    /// </summary>
    public static class Filter
    {
        public static List<int> FilterValues(List<int> values, IFilterCondition filtercondition)
        {
            List<int> filteredValues = new List<int>();

            foreach (var value in values)
            {
                if (filtercondition.Condition(value))
                {
                    filteredValues.Add(value);
                }
            }

            return filteredValues;
        }
        public static List<int> MultipleFilterValue(List<int> values, List<IFilterCondition> filterConditions)
        {
            List<int> filteredValues = values;
            foreach(IFilterCondition filterCondition in filterConditions)
            {
                filteredValues = FilterValues(filteredValues,filterCondition);
            }
            return filteredValues;
        }
    }
}