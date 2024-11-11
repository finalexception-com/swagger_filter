using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Infrastructure;

public class RemovePostOperationsFilter : IDocumentFilter
{
    public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
    {
        // Go through each path and remove DELETE operations
        foreach (var path in swaggerDoc.Paths)
        {
            path.Value.Operations.Remove(OperationType.Post);
        }
    }
}