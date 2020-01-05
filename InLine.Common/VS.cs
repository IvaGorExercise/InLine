using EnvDTE;
using EnvDTE100;
using System.IO;

namespace InLine.Common
{
    public static class VS
    {
        public static string SolutionPath()
        {
            string s = ((EnvDTE.DTE)System.Runtime.InteropServices.Marshal.GetActiveObject("VisualStudio.DTE.10.0")).Solution.FullName;
            s = Path.GetDirectoryName(s);
            return s;
        }
    }
}
