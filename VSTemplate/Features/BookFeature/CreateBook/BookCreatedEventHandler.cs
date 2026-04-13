using Microsoft.Extensions.Logging;
using VSTemplate.Abstractions;

namespace VSTemplate.Features.BookFeature.CreateBook;

public sealed class BookCreatedEventHandler(ILogger<BookCreatedEventHandler> logger) : IEventHandler<BookCreatedEvent>
{
    public Task HandleAsync(BookCreatedEvent @event, CancellationToken cancellationToken)
    {
        logger.LogInformation("Book created: {BookId} - '{Title}' by {Author}", @event.BookId, @event.Title, @event.Author);
        return Task.CompletedTask;
    }
}
