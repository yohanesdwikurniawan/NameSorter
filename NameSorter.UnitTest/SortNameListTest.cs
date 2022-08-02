namespace NameSorter.UnitTest
{
    [TestFixture]
    public class SortNameListTest
    {
        private SortNameList _sortNameList;

        [SetUp]
        public void Setup()
        {
            _sortNameList = new SortNameList();

        }

        [TestCase(new object[0])]
        public void SortNameListByLastName_ListIsEmpty_ReturnEmptyListOfNames(params string[] nameList)
        {
            var result = _sortNameList.SortNameListByLastName(nameList);
            Assert.That(result, Is.Empty);
        }

        [TestCase(new object[] { "Orson Milka Iddins", "Erna Dorey Battelle", "Flori Chaunce Franzel", "Odetta Sue Kaspar", "Roy Ketti Kopfen",
                "Madel Bordie Mapplebeck", "Selle Bellison", "Leonerd Adda Mitchell Monaghan", "Debra Micheli", "Hailey Avie Annakin"})]
        public void SortNameListByLastName_ListIsNotEmpty_ReturnSortedListOfNames(params string[] nameList)
        {
            string[] expected = new string[] { "Hailey Avie Annakin", "Erna Dorey Battelle", "Selle Bellison", "Flori Chaunce Franzel", "Orson Milka Iddins", 
                "Odetta Sue Kaspar", "Roy Ketti Kopfen", "Madel Bordie Mapplebeck", "Debra Micheli", "Leonerd Adda Mitchell Monaghan"};
            var result = _sortNameList.SortNameListByLastName(nameList);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
