using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Data.Objects.DataClasses;
using System.Data.Objects;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Reflection;

namespace InLine.Model.Data
{
   public static class Functions
    {
       [EdmFunction("InLineDataModel.Store", "FNS_Subjekt_Naziv")]
       public static string FNS_Subjekt_Naziv(long? iD_Subjekt)
       {
           throw new NotSupportedException();
       }
    }
}
