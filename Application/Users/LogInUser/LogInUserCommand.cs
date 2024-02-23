using CLRL.Application.Abstractions.Messaging;

namespace CLRL.Application.Users.LogInUser;

public sealed record LogInUserCommand(string Email, string Password)
    : ICommand<AccessTokenResponse>;
