using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tesis.Bussiness.Definition
{
    public interface IMovimientosService
    {
        Task Debe(decimal cantidad, string description);
        Task Haber(decimal cantidad, string description);
    }
}
