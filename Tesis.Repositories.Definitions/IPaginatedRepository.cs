using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tesis.Entities;
using Tesis.Models;

namespace Tesis.Repositories.Definition
{
    public interface IPaginatedRepository<T, TCursor> where T : EntidadBase 
    {
        Task<Page<T>> GetPage(int limit, TCursor cursor);
    }
}
