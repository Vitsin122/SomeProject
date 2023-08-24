using System;


namespace SomeProject.Model.Functions
{
    public class LinearFunc : IFunction
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public double Result { get; set; }
        public double Execute(ref FuncArgs args) => args.Result = Result = A * args.X + B + C;
        public LinearFunc() { }
    }
}
