using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;

namespace addressbook_tests_autoit
{
    public class ApplicationManager
    {
        public static string WINTITLE = "Free Address Book";
        private AutoItX3 aux;
        private GroupHelper groupHelper;
        private HelperBase helperBase;
        public ApplicationManager()
        {
            aux = new AutoItX3();
            aux.Run(@"x:\book\AddressBook.exe","",aux.SW_SHOW);
            groupHelper = new GroupHelper(this);
            helperBase= new HelperBase(this);
            helperBase.WaitUntilPageIsReadyForUsage(WINTITLE);
        }

        public void Stop()
        {
            aux.ControlClick(WINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d510");
        }

        public GroupHelper Groups => groupHelper;
        public AutoItX3 Aux => aux;
    }
}
