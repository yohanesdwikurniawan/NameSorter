namespace NameSorter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var getNameList = new ReadNameList();
            var sortNameList = new SortNameList();
            var writeNameList = new WriteNameList();

            writeNameList.WriteSortedNameList(sortNameList.SortNameListByLastName(getNameList.ReadNameListFromFile()));

            ////set path for get the list of names
            //var sourcePath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\Source\", "unsorted-names-list.txt");

            //Console.WriteLine(File.Exists(sourcePath) ? "File exists." : "File doesn't exist.");

            ////read all list of names into list
            //List<string> unsortedNameList = new List<string>(File.ReadAllLines(sourcePath, Encoding.UTF8));

            ////sort list of names by the last name
            //var sortedNameList = from name in unsortedNameList
            //                     let count = name.Split(" ").Length - 1
            //                     let lastName = name.Split(" ")[count]
            //                     orderby lastName ascending
            //                     select name;

            ////print sorted list of names
            //foreach (string name in sortedNameList)
            //{
            //    Console.WriteLine(name);
            //}

            ////set path for save the list of names
            //var destinationPath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\..\Destination\", "sorted-names-list.txt");

            ////write the sorted list of names to text file
            //File.WriteAllLines(destinationPath, sortedNameList);
        }
    }
}