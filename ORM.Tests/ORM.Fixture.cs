using NUnit.Framework;

namespace ORM.Tests
{
    [TestFixture]
    public class ORMFixture
    {
        [Test]
        public void BasicTest()
        {
            var target = new ORM("Library.mdb");

            target.Get<Books>( book => book.Author == "Asimov" );

        }
    }
}
