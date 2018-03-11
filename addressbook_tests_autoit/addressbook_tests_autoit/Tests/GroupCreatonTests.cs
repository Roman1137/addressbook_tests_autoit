using System;
using NUnit.Framework;
using System.Collections.Generic;


namespace addressbook_tests_autoit
{
    [TestFixture]
    public class GroupCreatonTests : TestBase
    {
        [Test]
        public void TestGroupCreation()
        {
            var oldGroups = app.Groups.GetGroupList();
            GroupData newGroup = new GroupData()
            {
                Name = "test"
            };

            app.Groups.Add(newGroup);
            var newGroups = app.Groups.GetGroupList();
            oldGroups.Add(newGroup);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}