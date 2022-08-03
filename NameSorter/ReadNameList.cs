using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class ReadNameList
    {
        /// <summary>
        /// Read text file and insert all the content to array of string
        /// </summary>
        /// <param name="filename"></param>
        /// <returns> array of string contains names </returns>
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
