﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;

namespace addressbook_tests_autoit
{
    public class HelperBase
    {
        protected ApplicationManager manager;
        public static string WINTITLE;
        protected AutoItX3 aux;

        public HelperBase(ApplicationManager manager)
        {
            this.manager = manager;
            WINTITLE = ApplicationManager.WINTITLE;
            this.aux = manager.Aux;
        }

        public void WaitUntilPageIsReadyForUsage(string title)
        {
            aux.WinWait(title);
            aux.WinActivate(title);
            aux.WinWaitActive(title);
        }
    }
}
