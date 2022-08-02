using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class ReadNameList
    {
        public string[] ReadNameListFromFile(string filename)
        {
            //set path for get the list of names
            var sourcePath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\Source\", $"{filename}.txt");
            if (File.Exists(sourcePath))
            {
                //read all list of names into list
                return File.ReadAllLines(sourcePath, Encoding.UTF8);
            }
            
            return new string[0];
        }
    }
}
