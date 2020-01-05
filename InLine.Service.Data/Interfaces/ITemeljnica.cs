using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InLine;
using System.Data.Objects;

namespace InLine.Service.Data
{
    public partial interface ITemeljnica
    {
        IDictionary<string, decimal> TemeljnicaSaldoStavki(long Id);
        bool IsSaldoStavkiNula(long Id);
    }
}
