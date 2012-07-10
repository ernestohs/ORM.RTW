using System.Collections.Generic;
using NUnit.Framework;
using ORM.Commands;

namespace ORM.Tests
{
    [TestFixture]
    public class CommandsFixture
    {
        [Test]
        public void TestSelectCommand()
        {
            const string expected = "SELECT Id,Author,Title,Year FROM UnitTestTable WHERE Id=@Id";

            var target = new SelectCommand(new MetaData
                                               {
                                                   Name = "UnitTestTable",
                                                   Properties = new[] { "Author", "Title", "Year" }
                                               });
            
            var actual = target.Execute(666);
            
            Assert.That(actual.CommandText, Is.EqualTo(expected));
        }

        [Test]
        public void TestDeleteCommand()
        {
            const string expected = "DELETE FROM UnitTestTable WHERE Id=@Id";

            var target = new DeleteCommand(new MetaData {
                                                Name = "UnitTestTable",
                                                Properties = new[] { "Author", "Title", "Year" }
                                            });
            
            var actual = target.Execute(666);
            
            Assert.That(actual.CommandText, Is.EqualTo(expected));
        }
    }
}
