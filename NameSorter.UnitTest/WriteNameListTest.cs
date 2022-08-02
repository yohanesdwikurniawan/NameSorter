namespace NameSorter.UnitTest
{
    [TestFixture]
    public class WriteNameListTest
    {
        private WriteNameList _writeNameList;
        [SetUp]
        public void Setup()
        {
            _writeNameList = new WriteNameList();
        }

        [TestCase(new object[0])]
        public void SortNameListByLastName_ListIsEmpty_ReturnEmptyListOfNames(params string[] nameList)
        {
            var result = _writeNameList.WriteSortedNameList(nameList);
            Assert.IsFalse(result);
        }

        [TestCase(new object[] { "Hailey Avie Annakin", "Erna Dorey Battelle", "Selle Bellison", "Flori Chaunce Franzel", "Orson Milka Iddins",
                "Odetta Sue Kaspar", "Roy Ketti Kopfen", "Madel Bordie Mapplebeck", "Debra Micheli", "Leonerd Adda Mitchell Monaghan"})]
        public void SortNameListByLastName_ListIsNotEmpty_ReturnSortedListOfNames(params string[] nameList)
        {
            var result = _writeNameList.WriteSortedNameList(nameList);
            Assert.IsTrue(result);
        }
    }
}
