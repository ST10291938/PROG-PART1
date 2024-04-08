using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1v1
{
     class MyCookingMethod
    {
        private string description;

        public string GetDescription()
        {
            return description;
        }

        public void SetDescription(string value)
        {
            description = value;
        }

        public MyCookingMethod(string description) {

            SetDescription(description);
        }
    }
}
