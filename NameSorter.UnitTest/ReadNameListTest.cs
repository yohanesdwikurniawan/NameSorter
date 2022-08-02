namespace NameSorter.UnitTest
{
    [TestFixture]
    public class ReadNameListTest
    {
        private ReadNameList _readNameList;
        [SetUp]
        public void Setup()
        {
            _readNameList = new ReadNameList();
        }

        [TestCase("empty-names-list")]
        public void ReadNameListFromFile_FileIsNotExists_ReturnEmptyListOfNames(string fileName)
        {
            var result = _readNameList.ReadNameListFromFile(fileName);
            Assert.That(result, Is.Empty);
        }

        [TestCase("unsorted-names-list")]
        public void ReadNameListFromFile_FileIsExists_ReturnListOfNames(string fileName)
        {
            string[] expected = new string[] { "Orson Milka Iddins", "Erna Dorey Battelle", "Flori Chaunce Franzel", "Odetta Sue Kaspar", "Roy Ketti Kopfen", 
                "Madel Bordie Mapplebeck", "Selle Bellison", "Leonerd Adda Mitchell Monaghan", "Debra Micheli", "Hailey Avie Annakin"};
            var result = _readNameList.ReadNameListFromFile(fileName);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}