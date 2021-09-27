using System;
using System.Linq;
using System.Collections.Generic;

namespace BDSA2021.Assignment3
{
    public class Queries
    {
        public static IEnumerable<string> getRowlingWizards(Lazy<IReadOnlyCollection<Wizard>> wizards)
        {
            var sorted = wizards.Value.Where(w => w.Creator.Contains("Rowling")).Select(w => w.Name);
            return sorted;
        }

        public static IEnumerable<string> getRowlingWizardsLINQ(Lazy<IReadOnlyCollection<Wizard>> wizards)
        {
            var sorted = from w in wizards.Value
                         where w.Creator.Contains("Rowling")
                         select w.Name;

            return sorted;
        }

        public static int? getFirstSithLordYear(Lazy<IReadOnlyCollection<Wizard>> wizards)
        {
            var year = wizards.Value.Where(w => w.Name.Contains("Darth")).OrderBy(w => w.Year).Select(w => w.Year).First();
            return year;
        }

        public static int? getFirstSithLordYearLINQ(Lazy<IReadOnlyCollection<Wizard>> wizards)
        {
            var year = (from w in wizards.Value
                       where w.Name.Contains("Darth")
                       orderby w.Year ascending
                       select w.Year).First();
            
            return year;
        }

        public static IEnumerable<(string, int?)> getHarryPotterWizards(Lazy<IReadOnlyCollection<Wizard>> wizards)
        {
            var sorted = wizards.Value.Where(w => w.Medium == "Harry Potter").Select(w => (w.Name, w.Year)).Distinct();
            return sorted;
        }

        public static IEnumerable<(string, int?)> getHarryPotterWizardsLINQ(Lazy<IReadOnlyCollection<Wizard>> wizards)
        {
            var sorted = (from w in wizards.Value
                         where w.Medium == "Harry Potter"
                         select
                         (
                             w.Name,
                             w.Year
                         )).Distinct();
            
            return sorted;
        }

        public static IEnumerable<string> getSortedWizards(Lazy<IReadOnlyCollection<Wizard>> wizards)
        {
            var sorted = wizards.Value.GroupBy(w => w.Creator)
                                      .OrderByDescending(g => g.Key)
                                      .Select(g => g.OrderBy(w => w.Name).Select(w => w.Name))
                                      .SelectMany(x => x);
                                      
            return sorted;
        }

        public static IEnumerable<string> getSortedWizardsLINQ(Lazy<IReadOnlyCollection<Wizard>> wizards)
        {
            var sorted = (from w in wizards.Value
                         group w by w.Creator into g
                         orderby g.Key descending
                         select
                         (
                            from w in g
                            orderby w.Name ascending
                            select w.Name
                         )).SelectMany(x => x);
                         
            return sorted;
        }
    }
}
