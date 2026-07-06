using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Abstracts
{

    public abstract class AbstractHome
    {
        public decimal AdditionalPrice { get; set; }
        public abstract void MakeHome();
    }

}
