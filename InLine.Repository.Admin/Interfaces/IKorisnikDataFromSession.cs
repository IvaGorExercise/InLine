using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InLine;

namespace InLine.Repository.Admin
{
    public interface IKorisnikDataFromSession
    {
        Model.Admin.KorisnikData GetKorisnikDataFromSession();
    }
}
