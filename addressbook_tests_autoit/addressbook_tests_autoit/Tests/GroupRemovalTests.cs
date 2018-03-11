using System;
using NUnit.Framework;
using System.Collections.Generic;


namespace addressbook_tests_autoit
{

    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        GroupData newGroup = new GroupData{Name = "test"};

        [Test]
        public void TestGroupRemoval()
        {
            const int indexOfGroupToDelete = 10;
            var oldGroups = app.Groups.VerifyTheGroupExists(indexOfGroupToDelete, newGroup);

            app.Groups.Remove(indexOfGroupToDelete);
            var newGroups = app.Groups.GetGroupList();
            oldGroups.RemoveAt(indexOfGroupToDelete);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups,newGroups);
        }
    }
}
