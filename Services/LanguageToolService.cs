using System.Text.Json;
using Microsoft.Extensions.Options;
using EduScriptAI.Models;
using EduScriptAI.Options;

namespace EduScriptAI.Services;

public class LanguageToolService : ILanguageToolService
{
    private readonly HttpClient _httpClient;
    private readonly LanguageToolOptions _options;

    public LanguageToolService(HttpClient httpClient, IOptions<LanguageToolOptions> options)
    {
        _httpClient = httpClient;
        _options = options.Value;
    }

    public async Task<GrammarCheckResult> CheckGrammarAsync(string text)
    {
        try
        {
            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("text", text),
                new KeyValuePair<string, string>("language", "en-US")
            });

            var response = await _httpClient.PostAsync(_options.Endpoint, content);
            response.EnsureSuccessStatusCode();

            var result = await response.Content.ReadAsStringAsync();
            var grammarResult = JsonSerializer.Deserialize<GrammarCheckResult>(result);

            return grammarResult ?? new GrammarCheckResult { Matches = new List<GrammarMatch>() };
        }
        catch (Exception ex)
        {
            return new GrammarCheckResult 
            { 
                Matches = new List<GrammarMatch>(),
                Error = ex.Message
            };
        }
    }
} 