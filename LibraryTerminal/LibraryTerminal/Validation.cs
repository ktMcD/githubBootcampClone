using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTerminal
{
    public static class Validation
    {
        public static string ValidatePatronResponse(string theMenuSelection)
        {
            string[] acceptableSelections = {"a", "b", "c", "d", "e", "q", "x"};
            for (int i = 0; i < acceptableSelections.Length; i++)
            {
                if (acceptableSelections[i] == theMenuSelection)
                {
                    return theMenuSelection;
                }
            }

            return "?";
        }
    }
}