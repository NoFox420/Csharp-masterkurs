using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_masterkurs
{
    internal class Person
    {
        private ILogger logger = new ConsoleLogger();

        private string name;
        
        public string Name
        {
            get
            {
                logger.Log("Getter von Name wurde aufgerufen!");
                return name;
            }
            set
            {
                logger.Log("Setter von Name wurde aufgerufen!");
                name = value;
            }
        }

    }
}
