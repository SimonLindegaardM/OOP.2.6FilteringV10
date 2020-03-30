using System;
using System.Collections.Generic;

namespace FilteringV10
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            List<int> values = new List<int>() {12, 24, 9, 10, 6, 3, 45};
            List<int> filteredValues = Filter.FilterValues(values, new FilterBelow20());

            foreach (var value in filteredValues)
            {
                Console.Write($" {value} ");
            }
            Console.WriteLine();

            List<IFilterCondition> filterConditions = new List<IFilterCondition>();
            filterConditions.Add(new FilterOdd());
            // filterConditions.Add(new FilterBelow20());
            filterConditions.Add(new FilterOver10());

            filteredValues = Filter.MultipleFilterValue(values,filterConditions);
            System.Console.WriteLine("Alle mine filtre");
            foreach(var value in filteredValues)
            {
                Console.Write($" {value}");
            }
            System.Console.WriteLine();


            // The LAST line of code should be ABOVE this line
        }
    }
}