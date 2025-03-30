using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Fiken.Api;
using Fiken.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Fiken;

/// <summary>
/// Utility service to get api implementations for PowerOfficeGoV2 apis.
/// </summary>
public interface IFikenApiService
{
    /// <summary>
    /// Gets the api implementation specified with type parameter T, configured with a bearer token which will be obtained
    /// using the included parameters.
    /// 
    /// <example>
    /// <c>
    /// var vouchersApi = powerOfficeGoApiService.GetApiAsync&lt;JournalEntryVouchersApi&gt;(...);
    /// var vouchers = await vouchersApi.JournalEntryVouchersGetAsync();
    /// </c>
    /// </example>
    /// </summary>
    /// <param name="bearerToken">Already obtained bearer token (optional)</param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="T">The type of the api, e.g. JournalEntryVouchersApi</typeparam>
    /// <returns>The api implementation or null if it could not be resolved</returns>
    Task<T?> GetApiAsync<T>(string? bearerToken, CancellationToken cancellationToken = default) where T: class;
}

/// <see cref="IFikenApiService"/>
public class FikenApiService : IFikenApiService
{
    private readonly IServiceProvider _serviceProvider;
    
    /// <summary>
    /// Initializes a new instance of <see cref="FikenGoApiService"/>.
    /// </summary>
    /// <param name="serviceProvider"></param>
    public FikenApiService(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }
    
    /// <inheritdoc />
    public Task<T?> GetApiAsync<T>(string? bearerToken, CancellationToken cancellationToken = default) where T: class
    {
        var type = typeof(T);
        var eventsType = Type.GetType(type.AssemblyQualifiedName?.Replace(type.FullName!, type.FullName + "Events") ?? string.Empty);
        if (eventsType == null)
        {
            return Task.FromResult<T?>(null);
        }

        var httpClient = new HttpClient
        {
            BaseAddress = new Uri(ClientUtils.BASE_ADDRESS),
        };
        // if (bearerToken is not null)
        // {
        //     httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);
        // }

        var tokenProvider = new OAuthTokenProvider(new OAuthToken(bearerToken ?? string.Empty));
        
        var args = new[]
        {
            _serviceProvider.GetRequiredService<ILogger<T>>(),
            _serviceProvider.GetRequiredService<ILoggerFactory>(),
            httpClient,
            _serviceProvider.GetRequiredService<JsonSerializerOptionsProvider>(),
            _serviceProvider.GetRequiredService(eventsType),
            tokenProvider,
        };
        
        return Task.FromResult((T?) Activator.CreateInstance(type, args));
    }

    private class OAuthTokenProvider : TokenProvider<OAuthToken>
    {
        public OAuthTokenProvider(OAuthToken token) : base([token])
        {
        }

        internal override ValueTask<OAuthToken> GetAsync(string header = "", CancellationToken cancellation = default)
        {
            return new ValueTask<OAuthToken>(base._tokens.First());
        }
    }
}