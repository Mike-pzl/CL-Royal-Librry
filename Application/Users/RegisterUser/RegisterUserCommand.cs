using CLRL.Application.Abstractions.Messaging;

namespace CLRL.Application.Users.RegisterUser;

public sealed record RegisterUserCommand(
        string Email,
        string FirstName,
        string LastName,
        string Password) : ICommand<Guid>;
