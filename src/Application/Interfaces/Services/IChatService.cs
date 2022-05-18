using Bible.Application.Interfaces.Chat;
using Bible.Application.Models.Chat;
using Bible.Application.Responses.Identity;

using Shared.Wrapper;

namespace Bible.Application.Interfaces.Services;

public interface IChatService
{
    Task<Result<IEnumerable<ChatUserResponse>>> GetChatUsersAsync(string userId);

    Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> message);

    Task<Result<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string userId, string contactId);
}