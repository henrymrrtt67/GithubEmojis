using System.Collections.Generic;
using System.Threading.Tasks;

namespace GithubEmojis
{
    public interface IGitHubEmojiService
    {
        Task<IList<Emoji>> GetEmojis();
        IList<Emoji> GetEmojisFrom(string content);
    }
}