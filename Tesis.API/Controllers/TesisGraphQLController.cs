using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Conversion;
using GraphQL.Types;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Tesis.API.GraphQL;

namespace Tesis.API.Controllers
{
    [Route("graphql")]
    [ApiController]
    [Produces("application/json")]
    [Consumes("application/json")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class TesisGraphQLController : Controller
    {
        private readonly ISchema _schema;
        private readonly IDocumentExecuter _documentExecuter;

        public TesisGraphQLController(ISchema schema, IDocumentExecuter documentExecuter)
        {
            _schema = schema;
            _documentExecuter = documentExecuter;
        }

        public async Task<IActionResult> Post([FromBody] GraphQLQuery query)
        {
            if(query == null) { throw new ArgumentNullException(nameof(query)); }
            var inputs = query.Variables.ToInputs();
            var executionOptions = new ExecutionOptions
            {
                Schema = _schema,
                Query = query.Query,
                Inputs = inputs,
                
                ExposeExceptions = true,
                FieldNameConverter = new PascalCaseFieldNameConverter()
            };

            var result = await _documentExecuter.ExecuteAsync(executionOptions).ConfigureAwait(false);
            if(result.Errors?.Count > 0)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }
    }
}