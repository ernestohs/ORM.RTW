using System.Collections.Generic;
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

            var expected = new List<Book>
                {
                    new Book { Author = "Asimov", Title = "Pebble In The Sky", Pages = 235},
                    new Book { Author = "Asimov", Title = "Foundation and Empire", Pages = 325},
                    new Book { Author = "Asimov", Title = "Foundation", Pages = 466},
                    new Book { Author = "Asimov", Title = "Second Foundation", Pages = 388},
                    new Book { Author = "Asimov", Title = "The Caves of Steel ", Pages = 989},
                    new Book { Author = "Asimov", Title = "The End of Eternity", Pages = 234},
                };

            var actual = target.Get<Book>( book => book.Author == "Asimov" );

            Assert.That(actual, Is.EqualTo(expected));
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
    }
}
