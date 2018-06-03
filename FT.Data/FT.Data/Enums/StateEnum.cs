using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT.Data
{
    public enum State
    {
        New = 0x01,
        Planned = 0x02,
        InProgress = 0x03,
        InTesting = 0x04,
        Ready_For_Release = 0x05
    }
}
