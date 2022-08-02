using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class ReadNameList
    {
        public List<string> ReadNameListFromFile()
        {
            try
            {
                //set path for get the list of names
                var sourcePath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\Source\", "unsorted-names-list.txt");
                if(File.Exists(sourcePath))
                {
                    //read all list of names into list
                    List<string> unsortedNameList = new List<string>(File.ReadAllLines(sourcePath, Encoding.UTF8));

                    if (!unsortedNameList.Any())
                    {
                        return new List<string>();
                    }
                    else
                    {
                        return unsortedNameList;
                    }
                }
                else
                {
                    return new List<string>();
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
