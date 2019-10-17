using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace GithubEmojis.Pages
{
    public class IndexModel : PageModel
    {
        private IGitHubEmojiService _emogiService;

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(IGitHubEmojiService emojiSvc)
        {
            _emogiService = emojiSvc;
        }
        public IList<Emoji> Emojis
        {
            get;
            set;
        }
        public async Task OnGet()
        {
            Emojis = await _emogiService.GetEmojis();

        }
    }
}
