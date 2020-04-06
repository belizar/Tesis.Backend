using System;
using System.Collections.Generic;
using System.Text;
using Tesis.Models;

namespace Tesis.Entities
{
    public class Page<T> where T : EntidadBase
    {
        public IEnumerable<T> Data { get; set; }
        public bool HasNextPage { get; set; }
        public int NextId { get; set; }
        public int PreviousId { get; set; }
        public int Total { get; set; }
    }
}
