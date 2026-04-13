using VSTemplate.Abstractions;
using VSTemplate.Constants;
using VSTemplate.Extensions;
namespace VSTemplate.Features.BookFeature.GetAllBooks;

internal sealed class GetAllBooksEndpoint : IApiEndpoint
{
    public void MapEndpoint(WebApplication app)
    {
        app.MapGet("books", async (
            IHandler<GetAllBooksRequest, Result<GetAllBooksResponse>> handler,
            CancellationToken cancellationToken) =>
        {
            var result = await handler.HandleAsync(new GetAllBooksRequest(), cancellationToken);
            return result.ToHttpResult(Results.Ok);
        })
        .WithTags(ApiTags.Books)
        .Produces<GetAllBooksResponse>(StatusCodes.Status200OK);
    }
}
