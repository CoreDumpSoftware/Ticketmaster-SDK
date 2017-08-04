# Ticketmaster.Core

This package contains common components for Ticketmaster SDK's
___
### Description
Such ass common client interfaces:
* __IClientConfig__ - interface for client configuration;
* __IApiRequest__ - interface for api requests classes;
* __IApiGetRequest__ - interface inherited from IApiRequest created for api GET requests classes;
* __IApiRespond__ - interface for Api responses;

Base Implementation for Api Clients __BaseClient__, and for queering  __BaseQuery__, __GetRequest__.

This common models components to serialize response data:
* __NameIdPair__ 
* __IdTypePaire__ 
* __IdTypePairCollectionData__ 
* __CurrencyValuePair__ 

____
### Dependencies

This packages is depended on [RestSharp](http://restsharp.org/) 