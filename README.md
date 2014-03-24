70-492
======

Study notes on the 70-492 certification


# Links
* [Upgrade your MCPD: Web Developer 4 to MCSD: Web Applications](https://www.microsoft.com/learning/en-us/exam.aspx?id=70-492)


# Skills Being Measured

## Design the Application Architecture
* Design and implement the Windows Azure role life cycle
  * This objective may include but is not limited to: identify and implement Start, Run, and Stop events; identify startup tasks (IIS configuration [app pool], registry configuration, third-party tools)


## Design the User Experience
* Design and implement UI behavior.
  * This objective may include but is not limited to: implement client validation; use JavaScript and the DOM to control application behavior; extend objects by using prototypal inheritance; use AJAX to make partial page updates; implement the UI by using JQuery
 

## Develop the User Experience
* Plan and implement globalization and localization.
  * This objective may include but is not limited to: plan a localization strategy; create and apply resources to UI including JavaScript resources; set cultures; create satellite resource assemblies
* Design and implement MVC controllers and actions.
  * This objective may include but is not limited to: apply authorization attributes and global filters; implement action behaviors; implement action results; implement model binding
* Control application behavior by using MVC extensibility points.
  * This objective may include but is not limited to: implement MVC filters and controller factories; control application behavior by using action results, viewengines, model binders, and route handlers
* Reduce network bandwidth.
  * This objective may include but is not limited to: bundle and minify scripts (CSS and JavaScript); compress and decompress data (using gzip/deflate; storage); plan a content delivery network (CDN) strategy, for example, Windows Azure CDN

  
## Troubleshoot and Debug Web Applications
* Debug a Windows Azure application
  * This objective may include but is not limited to: collect diagnostic information by using Windows Azure Diagnostics API Implement on demand vs. scheduled; choose log types, for example, event logs, performance counters, and crash dumps; debug a Windows Azure application by using IntelliTrace and Remote Desktop Protocol (RDP)


## Design and Implement Security
* Design and implement claims-based authentication across federated identity stores.
  * This objective may include but is not limited to: implement federated authentication by using Windows Azure Access Control Service; create a custom security token by using Windows Identity Foundation; handle token formats (for example, oAuth, OpenID, LiveID, and Facebook) for SAML and SWT tokens


## Accessing Data
* Implement data storage in Windows Azure.
  * This objective may include but is not limited to: access data storage in Windows Azure; Choose data storage mechanism in Windows Azure (blobs, tables, queues, SQL Database); Distribute data by using the Content delivery network (CDN); Handle exceptions by using retries (SQL Database); manage Windows Azure Caching
* Create and configure a WCF service on Windows Azure.
  * This objective may include but is not limited to: Address resources; implement filtering; create a query expression; access payload formats (including JSON); use data service interceptors and service operators


## Designing and Implementing WCF Services
* Implement messaging patterns.
  * This objective may include but is not limited to: Implement one way, request/reply, streaming, and duplex communication; implement Windows Azure Service Bus and Windows Azure Queues
* Host and manage services.
  * This objective may include but is not limited to: Manage services concurrency (single, multiple, reentrant); Create service hosts; Choose a hosting mechanism; choose an instancing mode (per call, per session, singleton); activate and manage a service by using AppFabric; implement transactional services; host services in an Windows Azure worker role


## Deploying Web Applications and Services
* Design a Web API.
  * This objective may include but is not limited to: define HTTP resources with HTTP actions; plan appropriate URI space, and map URI space using routing; choose appropriate HTTP method (get, put, post, delete) to meet requirements; choose appropriate format (Web API formats) for responses to meet requirements; plan when to make HTTP actions asynchronous
* Implement a Web API.
  * This objective may include but is not limited to: accept data in JSON format (in JavaScript, in an AJAX callback); use content negotiation to deliver different data formats to clients; define actions and parameters to handle data binding; use HttpMessageHandler to process client requests and server responses; implement dependency injection, along with the dependency resolver, to create more flexible applications; implement action filters and exception filters to manage controller execution; implement asynchronous and synchronous actions; implement streaming actions
* Secure a Web API.
  * This objective may include but is not limited to: implement HTTPBasic authentication over SSL; implement Windows Auth; enable cross-domain requests; prevent cross-site request forgery (XSRF); implement, and extend, authorization filters to control access to the application
* Host and manage Web API.
  * This objective may include but is not limited to: host Web API in an ASP.NET app; self-host a Web API in your own process (a Windows service); host services in a Windows Azure worker role; restricting message size; configure the host server for streaming
* Consume Web API web services.
  * This objective may include but is not limited to: consume Web API services by using HttpClient synchronously and asynchronously; send and receive requests in different formats (JSON/HTML/etc.)


## Deploying Web Applications and Services
* Manage packages by using NuGet.
  * This objective may include but is not limited to: Create and configure a NuGet package; install and update an existing NuGet package; connect to a local repository cache for NuGet, set up your own package repository
* Share assemblies between multiple applications and servers.
  * This objective may include but is not limited to: Prepare the environment for use of assemblies across multiple servers (interning); sign assemblies by using a strong name; deploy assemblies to the global assembly cache; implement assembly versioning; create an assembly manifest; configure assembly binding redirects (for example, from MVC2 to MVC3 or MVC4)




