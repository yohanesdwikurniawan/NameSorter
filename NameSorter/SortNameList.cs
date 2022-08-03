using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class SortNameList
    {
        /// <summary>
        /// Sort name list by their last name
        /// </summary>
        /// <param name="unsortedNameList"></param>
        /// <returns> sorted array of names </returns>
        public IEnumerable<string> SortNameListByLastName(string[] unsortedNameList)
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
    }
}
