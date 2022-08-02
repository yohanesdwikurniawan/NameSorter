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
            try
            {
                if (!sortedNameList.Any())
                    return false;
                else
                {
                    //set path for save the list of names
                    var destinationPath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\Destination\", "sorted-names-list.txt");

                    //write the sorted list of names to text file
                    File.WriteAllLines(destinationPath, sortedNameList);

                    return true;
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
