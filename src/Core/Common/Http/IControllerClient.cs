﻿using System.Threading.Tasks;

namespace Atomiv.Core.Common.Http
{
    // TODO: VC: Sub-resources for all operations, enabling additional uri, also enabling fully custom uri in case no patterns match

    public interface IControllerClient : IObjectClient, IClient
    {
        Task<ObjectClientResponse<TResponse>> GetAsync<TRequest, TResponse>(TRequest request, HeaderDictionary headers = null);

        Task<ObjectClientResponse<TResponse>> GetAsync<TRequest, TResponse>(string uri, TRequest request, HeaderDictionary headers = null);

        Task<ObjectClientResponse<TResponse>> GetAsync<TResponse>(HeaderDictionary headers = null);

        Task<ClientResponse> GetNoResponseAsync(HeaderDictionary headers = null);

        Task<ObjectClientResponse<TResponse>> GetByIdAsync<TId, TResponse>(TId id, HeaderDictionary headers = null);

        Task<ClientResponse> GetByIdNoResponseAsync<TId>(TId id, HeaderDictionary headers = null);

        Task<ObjectClientResponse<TResponse>> PostAsync<TRequest, TResponse>(TRequest request, HeaderDictionary headers = null);

        Task<ClientResponse> PostNoResponseAsync<TRequest>(TRequest request, HeaderDictionary headers = null);

        Task<ObjectClientResponse<TResponse>> PostSubAsync<TRequest, TResponse>(string uri, TRequest request, HeaderDictionary headers = null);

        Task<ObjectClientResponse<TResponse>> PutByIdAsync<TId, TRequest, TResponse>(TId id, TRequest request, HeaderDictionary headers = null);

        Task<ClientResponse> PutByIdNoResponseAsync<TId, TRequest>(TId id, TRequest request, HeaderDictionary headers = null);

        Task<ObjectClientResponse<TResponse>> DeleteByIdAsync<TId, TResponse>(TId id, HeaderDictionary headers = null);

        Task<ClientResponse> DeleteByIdNoResponseAsync<TId>(TId id, HeaderDictionary headers = null);
    }
}