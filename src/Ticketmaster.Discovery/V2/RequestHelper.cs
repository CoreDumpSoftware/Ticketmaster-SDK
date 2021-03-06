﻿using RestSharp;
using Ticketmaster.Core;

namespace Ticketmaster.Discovery
{
    public class RequestHelper
    {
        public static IRestRequest CreateGetRequest(IApiRequest request, string relativePath)
        {
            var searchRequest = new RestRequest(relativePath, Method.GET) { RequestFormat = DataFormat.Json };

            if (request is IApiGetRequest)
            {
                searchRequest.AddParameter("id", (request as IApiGetRequest).Id, ParameterType.UrlSegment);
            }

            return searchRequest;
        }
    }
}
