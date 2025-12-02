using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueueForThelma
{
    public class Client
    {
        private string name;
        private bool isVip;
        public Client(string name, bool isVip)
        { 
        this.name = name;
            this.isVip = isVip;
        }
        public bool GetIsVip()
        {
            return isVip;
        }
        public string GetName()
            {
            return name; 
            }

    }
}
