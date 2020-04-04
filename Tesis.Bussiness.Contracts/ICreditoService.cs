using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tesis.Models.Dominio.Credito;

namespace Tesis.Bussiness.Definition
{
    public interface ICreditoService
    {
        Task Save(Credito credito);
    }
}
