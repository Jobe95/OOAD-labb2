using System;
using System.Collections.Generic;

namespace ooadlabb2
{
    public interface IAstronautRepository
    {
        IEnumerable<Astronauts> GetAstronauts();
    }
}
