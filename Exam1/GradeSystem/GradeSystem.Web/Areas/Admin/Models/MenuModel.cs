﻿using GradeSystem.Framework.MenuFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GradeSystem.Web.Areas.Admin.Models
{
    public class MenuModel
    {
       public IList<MenuItem> MenuItems { get; set; }
    }
}
