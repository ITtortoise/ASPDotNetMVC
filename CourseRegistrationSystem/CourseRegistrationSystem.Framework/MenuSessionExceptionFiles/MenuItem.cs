using System;
using System.Collections.Generic;
using System.Text;

namespace CourseRegistrationSystem.Framework.MenuSessionExceptionFiles
{
    public class MenuItem
    {
        public string Title { get; set; }
        public IList<MenuChildItem> Childs { get; set; }
        public string Title2 { get; set; }
        public IList<MenuChildItem> Childs2 { get; set; }
        public string Title3 { get; set; }
        public IList<MenuChildItem> Childs3 { get; set; }
    }
}
