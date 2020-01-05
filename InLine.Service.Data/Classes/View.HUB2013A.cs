using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InLine.Service.Data.View
{
    public partial class HUB2013A
    {
        public int HUB_IMPORT(Repository.Data.Helper.HUB_IMPORT item)
        {
            int rezultat = 0;
            rezultat = _repository.HUB_IMPORT(item);
            return rezultat;
        }

        public int HUB_IMPORT_TestBrojUgovora(Repository.Data.Helper.HUB_IMPORT item)
        {
            int rezultat = 0;
            rezultat = _repository.HUB_IMPORT_TestBrojUgovora(item);
            return rezultat;
        }

        public int HUB_IMPORT_Test(Repository.Data.Helper.HUB_IMPORT item)
        {
            int rezultat = 0;
            rezultat = _repository.HUB_IMPORT_Test(item);
            return rezultat;
        }

    }
}
