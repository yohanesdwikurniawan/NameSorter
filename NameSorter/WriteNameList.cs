using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class WriteNameList
    {
        public bool WriteSortedNameList(IEnumerable<string> sortedNameList)
        {
            if (sortedNameList.Any())
            {
                //set path for save the list of names
                var destinationPath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\Destination\", "sorted-names-list.txt");

                //write the sorted list of names to text file
                File.WriteAllLines(destinationPath, sortedNameList);

                if (File.Exists(destinationPath))
                {
                    //write all list of names into list
                    return true;
                }
            }

            return false;
        }
    }
}
