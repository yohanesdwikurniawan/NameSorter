namespace NameSorter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var getNameList = new ReadNameList();
            var sortNameList = new SortNameList();
            var writeNameList = new WriteNameList();

            writeNameList.WriteSortedNameList(sortNameList.SortNameListByLastName(getNameList.ReadNameListFromFile("unsorted-names-list")));
        }
    }
}