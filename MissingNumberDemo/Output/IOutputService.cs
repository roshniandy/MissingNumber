using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMissingNumber.Output
{
    public interface IOutputService
    {
        public void PrintResult(string message);
        public void PrintError(string message);
    }
}
