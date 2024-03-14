using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JtvDevTools.WinForms.Models
{
    public class Lines
    {
        private List<string> lines = new List<string>(1024);

        public string this[int i]
        {
            get
            {
                return lines[i];
            }
            set
            {
                lines[i] = value;
            }
        }

        public Lines() 
        {
        }

        public string[] Get()
        {
            return lines.ToArray();
        }

        public void Set(string[] lines)
        {
            this.lines.Clear();
            this.lines.AddRange(lines);
        }

        public void Add(string s)
        { 
            this.lines.Add(s); 
        }

    }
}
