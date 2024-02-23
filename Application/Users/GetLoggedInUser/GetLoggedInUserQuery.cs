using CLRL.Application.Abstractions.Messaging;

namespace CLRL.Application.Users.GetLoggedInUser;

public sealed record GetLoggedInUserQuery : IQuery<UserResponse>;
