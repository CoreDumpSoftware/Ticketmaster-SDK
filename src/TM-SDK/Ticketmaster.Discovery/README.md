# Ticketmaster.Discovery


This project contains clients for Second version **V2** of **Ticketmaster 
[Discovery](http://developer.ticketmaster.com/products-and-docs/apis/discovery-api/v2/) 
API** with base models for response.

## Installetion

You can install the last stable version of Ticketmaster.Discovery SDK using nuget.

```
PM> Install-Package Ticketmaster.Discovery
```

For more details about package please visit [this](https://www.nuget.org/packages/Ticketmaster.Discovery/).

## Usage
#### Configuration
Usage of any client require **<code>IClientConfig</code>** to be implemented.

```C#
    public interface IClientConfig
    {
        // Your API Key like : 'K1uJLzJ5mdt3oBKNSzjcEEEzxHuJJXiX' 
        string ConsumerKey { get; } 
        
        // The 'https://app.ticketmaster.com/discovery/' url to ticketmaster discovery api.
        string ApiRootUrl { get; }   
    }
```

This interface common for implementation for all clients in SDK.  

#### Events Client 

The **IEventsClient** interface contains methods for Searching events and obtaining information about them.
It has default implementation in **EventsClient**. The EventClient class has only one public constructor with 
two parameters 

```C#
public EventsClient(IRestClient client, IClientConfig config)
```

All direct calls to API goings via IRestClient, that mean we have to set base URL for it from  IClientConfig.

#### Basic creation of EventsClient 
```C#
var client = new EventsClient(new RestClient(config.ApiRootUrl), config);
```

#### SearchEventsAsync Method

There are few methods what call "Event Search" endpoint in API. With different level of abstraction.
- public Task<SearchEventsResponse> SearchEventsAsync(SearchEventsRequest request)
- public Task<SearchEventsResponse> SearchEventsAsync(IApiRequest request)
- public Task<IRestResponse> CallSearchEventsAsync(SearchEventsRequest request)
- public Task<IRestResponse> CallSearchEventsAsync(IApiRequest request)

Preferable the first one.

For using **SearchEventsAsync** method you will need to create **SearchEventsRequest**.
Which inherited from BaseQuery abstract class.
```C#
namespace Ticketmaster.Core
{
    public abstract class BaseQuery<TK, T> : IApiRequest
    {
        /// <summary>
        /// The parameters dictionary.
        /// </summary>
        protected Dictionary<string, string> ParametersDictionary;

        protected BaseQuery()
        {
            ParametersDictionary = new Dictionary<string, string>();
        }

        /// <summary>
        /// Gets the query parameters.
        /// </summary>
        /// <value>
        /// The query parameters.
        /// </value>
        public IEnumerable<KeyValuePair<string, string>> QueryParameters => ParametersDictionary;

        /// <summary>
        /// Adds the query parameter.
        /// </summary>
        /// <param name="parameterName">Name of the parameter.</param>
        /// <param name="value">The value of the parameter.</param>
        /// <returns>Instance.</returns>
        public abstract TK AddQueryParameter(T parameterName, string value);
    }
}
}
```
Because of this it's possible to add query parameters to request like described in
[Event Search](http://developer.ticketmaster.com/products-and-docs/apis/discovery-api/v2/#search-events-v2).

All **QueryParameters** stored in enum:
```C#
namespace Ticketmaster.Discovery.V2.Models
{
    public enum SearchEventsQueryParameters
    {
        keyword = 1,
        attractionId = 2,
        venueId = 3,
        postalCode = 4,
        latlong = 5,
        radius = 6,
        unit = 7,
        source = 8,
        locale = 9,
        marketId = 10,
        startDateTime = 11,
        endDateTime = 12,
        includeTBA = 13,
        includeTBD = 14,
        includeTest = 15,
        size = 16,
        page = 17,
        sort = 18,
        onsaleStartDateTime = 19,
        onsaleEndDateTime = 20,
        city = 21,
        countryCode = 22,
        stateCode = 23,
        classificationName = 24,
        classificationId = 25,
        dmaId = 26,
        onsaleOnStartDate = 27,
        onsaleOnAfterStartDate = 28,
        segmentId = 29,
        segmentName = 30,
        promoterId = 31,
        clientVisibility = 32,
        nlp = 33,
        geoPoint = 34,
        includeLicensedContent = 35
    }
}
```

**How to use search event?**

```C#
 var request = new SearchEventsRequest();
 request.AddQueryParameter(SearchEventsQueryParameters.source, "ticketmaster");
 var result = await client.SearchEventsAsync(request);

```

#### GetEventDetailsAsync Method
There are few methods what call "Get Event Details" endpoint in API. With different level of abstraction.

- public Task<Event> GetEventDetailsAsync(GetRequest request)
- public Task<Event> GetEventDetailsAsync(IApiGetRequest request)
- public Task<IRestResponse> CallGetEventDetailsAsync(GetRequest request)
- public Task<IRestResponse> CallGetEventDetailsAsync(IApiGetRequest request)

Basic usage
```C#
var eventId = "G5diZfkn0B-bh";
var response = await cliet.CallGetEventDetailsAsync(new GetRequest(eventId));
```

For all another classes a methods please check source code : [here](https://github.com/SerhiiVoznyi/ticketmaster-api-sdk-dot-net) 
___

### With any questions please contact [Me](https://www.linkedin.com/in/serhii-voznyi/)

