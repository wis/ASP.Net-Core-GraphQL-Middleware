using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.Middleware
{
    internal sealed class GraphQLRequest
    {
        public string OperationName { get; set; }

        public string Query { get; set; }

        public string Variables { get; set; }
    }
}
