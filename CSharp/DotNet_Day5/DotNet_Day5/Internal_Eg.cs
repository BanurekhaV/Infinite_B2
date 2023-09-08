using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Day5
{
    class Internal_Eg
    {
        public void Access_InternalMembers()
        {
            AccessSpecifier_Eg ag2 = new AccessSpecifier_Eg();
            ag2.SName = "Rama";
            ag2.Marks = 96;            
        }
    }
}
