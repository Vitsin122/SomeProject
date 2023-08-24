using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeProject.Model
{
    /// <summary>
    /// Interface from which all kinds of functions are implemented
    /// </summary>
    public interface IFunction
    {
        int A { get; set; }   
        int B { get; set; }   
        int C { get; set; }
        double Result { get; set; }
        double Execute(ref FuncArgs args);
    }
}
