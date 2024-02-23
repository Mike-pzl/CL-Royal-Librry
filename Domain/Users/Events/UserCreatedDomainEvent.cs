using CLRL.Domain.Abstractions;

namespace CLRL.Domain.Users.Events;

public sealed record UserCreatedDomainEvent(Guid UserId) : IDomainEvent;
