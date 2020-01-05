using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InLine.Service.Data.View
{
    public partial interface IHUB2013A
    {
        int HUB_IMPORT(Repository.Data.Helper.HUB_IMPORT item);
        int HUB_IMPORT_TestBrojUgovora(Repository.Data.Helper.HUB_IMPORT item);
        int HUB_IMPORT_Test(Repository.Data.Helper.HUB_IMPORT item);
    }
}
