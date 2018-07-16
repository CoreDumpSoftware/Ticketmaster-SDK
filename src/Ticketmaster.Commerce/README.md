# Ticketmaster.Commerce


This project contains client for Second version **V2** of **Ticketmaster
[Commerce](https://developer.ticketmaster.com/products-and-docs/apis/commerce/v2/)
API** with base models for response.

Use the Ticketmaster Commerce API to look up available offers and 
products on various Ticketmaster platforms for North America markets. 
For formal partnerships and relationships, selected offers and products 
can be carted and transacted on through the cart, delivery, payment 
and purchase APIs – These APIs require approved access 
from Ticketmaster.

## Installetion

[![NuGet](https://img.shields.io/badge/NuGet-v2.0.0-blue.svg)](https://www.nuget.org/packages/Ticketmaster.Commerce/)

You can install the last stable version of Ticketmaster.Commerce SDK using nuget.

```
PM> Install-Package Ticketmaster.Commerce
```

For more details about package please visit [this]().

## Usage
#### Configuration
Usage of any client require **<code>IClientConfig</code>** to be implemented.

```CSharp
public interface IClientConfig
{
    // Your API Key like : 'K1uJLzJ5mdt3oBKNSzjcEEEzxHuJJXiX'
    string ConsumerKey { get; }
    // The 'https://app.ticketmaster.com/commerce/' url to ticketmaster discovery api.
    string ApiRootUrl { get; }
}
```

This interface common for implementation for all clients in SDK.

#### Event Offers Client

The **IEventOffersClient** interface contains methods for Get Event Offers and obtaining information about them.
It has default implementation in **EventOffersClient**. The EventClient class has only one public constructor with 
two parameters

```C#
public EventOffersClient(IRestClient client, IClientConfig config)
```

All direct calls to API goings via IRestClient, that mean we have to set base URL for it from  IClientConfig.

#### Basic creation of Event Offers Client

```CSharp
var client = new EventOffersClient(new RestClient(config.ApiRootUrl), config);
var request = new GetRequest("vv17FZfyGknaheGB");
var response = await client.GetEventOffersAsync(request);
```

#### The response structure

```CSharp
public class EventOffers : IApiResponse
{
    public EventOffers()
    {
        Offers = new List<Offer>();
    }

    public Limits Limits { get; set; }
    public Prices Prices { get; set; }
    public MetaDataClass MetaData { get; set; }
    public List<Offer> Offers { get; set; }
    public EmbeddedDataClass _embedded { get; set; }

    public class MetaDataClass
    {
        public EventMapping EventMapping { get; set; }
    }

    public class EmbeddedDataClass
    {
        public DataCollection<Price> PriceZones { get; set; }
        public DataCollection<EmbeddedData> Areas { get; set; }
        public DataCollection<AttributesClass> AttributesRefs { get; set; }
        public DataCollection<EmbeddedData> Passwords { get; set; }
    }
}
```


### With any questions please contact [Me](https://www.linkedin.com/in/serhii-voznyi/)

