using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NameParser
{
    public class Parser
    {
        public Name ParseName(string nameToParse)
        { 
            var splitNames = nameToParse.Split(" ");

            var name = new Name
            {
                FirstName = splitNames.First(),
                LastName = splitNames.Last()
            };

            return name;
        }


        /*Refactored from:
        var splitNames = nameToParse.Split(" ");
        var name = new Name();
        name.FirstName = splitNames[0];
        name.LastName = splitNames[1];

        return name;*/
        
    }

    public class Name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
