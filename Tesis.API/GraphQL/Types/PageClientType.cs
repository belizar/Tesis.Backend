using GraphQL.Types;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tesis.Entities;
using Tesis.Models.Dominio.Cliente;

namespace Tesis.API.GraphQL.Types
{
    public class PageClientType : PageType<Cliente, ClienteType>
    {
        public PageClientType() : base()
        {
            Name = "PageCliente";
            
        }
    }
}
