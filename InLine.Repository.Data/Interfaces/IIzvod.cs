using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InLine.Repository.Data.Helper;

namespace InLine.Repository.Data
{
    public partial interface IIzvod
    {
        Model.Data.Izvod InsertIzvodIzvod2012A(Glava obc, Labela lab);
        Model.Data.IzvodSt InsertIzvodStIzvod2012ASt(Stavka obc);
    }
}
