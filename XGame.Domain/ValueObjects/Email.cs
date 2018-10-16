using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XGame.Domain.ValueObjects
{
    public class Email
    {
        public String Endereco { get; private set; }

        public Email(string endereco)
        {
            Endereco = endereco;
        }

    }
}
