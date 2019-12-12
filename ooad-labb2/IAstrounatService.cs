using System;
using System.Collections.Generic;

namespace ooadlabb2
{
    public interface IAstronautService
    {
        IEnumerable<Astronauts> GetAstronauts();
    }
}
