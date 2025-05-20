using EduScriptAI.Models;

namespace EduScriptAI.Services
{
    public interface ILanguageToolService
    {
        Task<GrammarCheckResult> CheckGrammarAsync(string text);
    }
} 