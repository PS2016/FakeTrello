using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT.Data.Enums
{
    public class StateEnum
    {
        public enum State
        {
            New=0x01,
            Planned=0x02,
           In_Progress=0x03,
           In_Testing=0x04,
            Ready_For_Release=0x05
        }
    }
}
