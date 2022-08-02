using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class SortNameList
    {
        public IEnumerable<string> SortNameListByLastName(List<string> unsortedNameList)
        {
            try
            {
                if (!unsortedNameList.Any())
                {
                    return unsortedNameList;
                }
                else
                {
                    //sort list of names by the last name
                    var sortedNameList = from name in unsortedNameList
                                         let count = name.Split(" ").Length - 1
                                         let lastName = name.Split(" ")[count]
                                         orderby lastName ascending
                                         select name;

                    //print sorted list of names
                    foreach (string name in sortedNameList)
                    {
                        Console.WriteLine(name);
                    }

                    return sortedNameList;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
