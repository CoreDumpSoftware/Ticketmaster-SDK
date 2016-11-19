# Ticketmaster API: SDK for .NET
<p>
For more detailed information about the API and to get your API key head <a href="http://developer.ticketmaster.com/">here</a>. 
This SDK supports Discovery <a href="http://developer.ticketmaster.com/products-and-docs/apis/discovery/v2/">v2</a>.
</p>

<h2>Overview</h2>
The <a href="http://restsharp.org/">RestSharp</a> (<a href="https://github.com/restsharp/RestSharp">repo</a>) was added like a dependency to the project. It helps execute requests to the api endpoints.   
This project contains useful interfaces and implementation for them to makes calls to api endpoint more simple and friendly for .net developers. 
The SDK splits all requests for Discovery API between specific interfaces by logical ownership.

* IEventsClient
* IVenuesClient
* IClassificationsClient
* IAttractionsClient

This interfaces contains methods which able to return response from Api in appropriate format, like a <code>IRestResponse</code>  or like an <code>IDiscoveryApiRespond</code>. Also it contains a model classes for responses. 

<h2>Usage</h2>
<h3>Setup IClientConfig</h3>
The implementation of interfaces, the clients, in sdk required to resolve <code>ClientConfig</code> and pass them like a parameter into constructor. It have <code>ConsumerKey</code> property what is the Consumer Key for ticketmaster api. And <code>ApiRootUrl</code> what should be <code>https://app.ticketmaster.com/discovery/</code>.

```C#
    public interface IClientConfig
    {
        string ConsumerKey { get; }
        string ApiRootUrl { get; }
    }
```
<h3>Simple usage of <code>EventsClient</code></h3>

```C#
  var config = Substitute.For<IClientConfig>();
  config.ConsumerKey.Returns("K1uJLzJ5mdt3oBKNSzjcEEEzxHuJJXiX-1");
  config.ApiRootUrl.Returns("https://app.ticketmaster.com/discovery/");
  
  var restClient = new RestClient(config.ApiRootUrl);
  
  var eventsApiClient = new EventsClient(client, config);
  var result = await _sut.SearchEventsAsync(new SearchEventsRequest());
````

<h3>The requests classes and <code>BaseQuery</code> class.</h3>

The <a href="http://developer.ticketmaster.com/products-and-docs/apis/discovery/v2/">Discovery API</a> can accept query parameters
for different endpoints. To allow pass this query parameters was created <code>BaseQuery</code> which have <code>QueryParameters</code> property. 

For adding this parameters you just need create new instance of IDiscoveryApiRequest, IDiscoveryApiGetRequest interface. In this solution have implementations for this interfaces. The <code>SearchAttractionsRequest</code>, <code>SearchClassificationsRequest</code>, <code>SearchEventsRequest</code>, <code>SearchVenuesRequest</code> classes. Use method <code> AddQueryParameter </code> to add query properties, the rules described in Method description for Api. The Example for <a href="http://developer.ticketmaster.com/products-and-docs/apis/discovery/v2/#srch-events-v2">Search Events</a> method is: 

```C#
var request = new SearchAttractionsRequest();
request.AddQueryParameter(new KeyValuePair<SearchEventsQueryParameters, string>(SearchEventsQueryParameters.attractionId, "K8vZ91713eV"));
```

Contact me in skype : serhiivoznyi
 
