using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalculatorService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CalculatorService" in both code and config file together.
    public class CalculatorService : ICalculatorService
    {
        public int div(int a, int b)
        {
            return a / b;
        }

        public string GetName(string name)
        {
            return "Hello " + name;
        }

        public int mul(int a, int b)
        {
            return a * b;
        }

        public int sum(int a, int b)
        {
            return a + b;
        }
    }
}
