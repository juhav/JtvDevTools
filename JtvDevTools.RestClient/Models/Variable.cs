using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JtvDevTools.RestClient.Models
{
    public class Variable
    {
        private string name = "";
        private string value = "";
        
        public Variable()
            : base()
        {
        }

        public Variable(string name, string value) 
            : base()
        {
            this.name = name;
            this.value = value;
        }

        public string Name 
        {
            get => name;
            set => name = (value ?? "").Trim();
        }
        
        public string Value 
        {
            get => value;
            set => this.value = (value ?? "").Trim();
        }
    }
}
