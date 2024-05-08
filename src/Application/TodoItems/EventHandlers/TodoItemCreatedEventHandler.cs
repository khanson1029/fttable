using fttable.Domain.Events;
using Microsoft.Extensions.Logging;

namespace fttable.Application.TodoItems.EventHandlers;

public class TodoItemCreatedEventHandler : INotificationHandler<TodoItemCreatedEvent>
{
    private readonly ILogger<TodoItemCreatedEventHandler> _logger;

    public TodoItemCreatedEventHandler(ILogger<TodoItemCreatedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCreatedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("fttable Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
