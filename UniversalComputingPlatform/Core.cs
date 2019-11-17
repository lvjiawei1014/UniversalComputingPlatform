using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalComputingPlatform
{
    public class Core
    {

    }

    public class UniversalObject
    {
        private string name;

        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            return name;
        }
    }


    public abstract class UniversalTool:UniversalObject
    {
        public abstract void Run();

    }

    public class UniversalData : UniversalObject
    {

    }
}
