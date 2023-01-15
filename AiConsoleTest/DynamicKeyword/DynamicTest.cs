using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace AiConsoleTest
{
    class DynamicTest
    {
        public dynamic Calulate(int totalInches)
        {
            int feet = totalInches / 12;
            int inches = totalInches % 12;

            dynamic returnObject = new ExpandoObject();
            returnObject.feet = feet;
            returnObject.inches = inches;

            return returnObject;
        }
    }
}
