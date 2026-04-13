using VSTemplate.Abstractions;

namespace VSTemplate.Features.BookFeature.CreateBook;

public sealed record BookCreatedEvent(Guid BookId, string Title, string Author) : IDomainEvent;
