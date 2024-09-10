using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinInheritance
{
    class MuzikAleti
    {
        protected string Hebele;
        public string Renk { get; set; }
        public string Malzeme { get; set; }

        public virtual string SesVer()
        {
            return "Gitar Sesi";
        }
    }
}
