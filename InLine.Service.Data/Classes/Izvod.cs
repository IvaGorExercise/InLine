using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InLine.Repository.Data.Helper;

namespace InLine.Service.Data
{
    public partial class Izvod
    {

        # region Konstruktor

        Repository.Data.IIzvodSt _repositoryIzvodSt;

        #endregion


        public Model.Data.Izvod InsertIzvodIzvod2012A(Glava obc, Labela lab)
        {
            return _repository.InsertIzvodIzvod2012A(obc, lab);
        }

        public Model.Data.IzvodSt InsertIzvodStIzvod2012ASt(Stavka obc)
        {
            return _repository.InsertIzvodStIzvod2012ASt(obc);
        }


    }
}

