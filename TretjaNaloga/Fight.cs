using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TretjaNaloga
{
    class Fight
    {
        public string Email { get; set; }
        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj as Fight);
        }
        public bool Equals(Fight obj)
        {
            return obj != null && obj.Email == this.Email;

        }

    }
}
