70-492
======

Study notes on the 70-492 certification


# Links
* [Upgrade your MCPD: Web Developer 4 to MCSD: Web Applications](https://www.microsoft.com/learning/en-us/exam.aspx?id=70-492)
* [Building Web Apps with ASP.NET Jump Start](http://www.microsoftvirtualacademy.com/training-courses/create-web-apps-with-asp-net?prid=USLeX_MktgDR1A2#?fbid=Ydu36-D4uQu)
* [Developing Windows Azure and Web Services Jump Start](http://www.microsoftvirtualacademy.com/training-courses/developing-windows-azure-and-web-services-jump-start)
* [Study notes from @adnanmasood](http://blog.adnanmasood.com/2013/05/20/study-notes-for-70-486-developing-asp-net-mvc-4-web-applications/)


# Pluralsight
* Azure
  * [Windows Azure: The Big Picture (1.5h)](http://pluralsight.com/training/Courses/TableOfContents/azure-bigpicture)
  * [Applied Windows Azure (5h)](http://pluralsight.com/training/Courses/TableOfContents/applied-windows-azure)
  * [Fundamentals of Azure Cloud Services and Storage (2h)](http://pluralsight.com/training/Courses/TableOfContents/azure-cloud-services-storage-fundamentals)
  * [Building Apps with Azure Mobile Svcs, SignalR, MVC, Win 8 and WP8 (2h)](http://pluralsight.com/training/Courses/TableOfContents/building-mobile-applications-azure-signalr-mvc)
  * [Windows Azure Storage In-Depth (7h)](http://pluralsight.com/training/Courses/TableOfContents/windows-azure-storage-in-depth)
  * [Windows Azure Service Bus (2)](http://pluralsight.com/training/Courses/TableOfContents/azure-sb)
  * [Windows Azure Access Control Service (2h)](http://pluralsight.com/training/Courses/TableOfContents/azure-acs)
  * [Migrating Internet Applications to Azure (2h)](http://pluralsight.com/training/Courses/TableOfContents/migrating-inet-azure)
* ASP.Net MVC
  * [Build Your Own Application Framework with ASP.NET MVC 5 (3.5h)](http://pluralsight.com/training/Courses/TableOfContents/build-application-framework-aspdotnet-mvc-5)
  * [Building ASP.NET MVC Apps with EF Code First, HTML5, and jQuery (5h)](http://pluralsight.com/training/Courses/TableOfContents/web-development)
  * [Identity and Access Control in ASP.NET 4.5 (3.5h)](http://pluralsight.com/training/Courses/TableOfContents/iac-aspnet)
  * [Introducing ASP.NET SignalR - Push Services with Hubs (3.5h)](http://pluralsight.com/training/Courses/TableOfContents/signalr-introduction)
  * [Hack-proofing Your ASP.NET Web Applications (5h)](http://pluralsight.com/training/Courses/TableOfContents/hack-proofing-dotnet-app)
* Web API
  * [Introduction to the ASP.NET Web API (3h)](http://pluralsight.com/training/Courses/TableOfContents/aspnetwebapi)
  * [Web API v2 Security (6h)](http://pluralsight.com/training/Courses/TableOfContents/webapi-v2-security)
  * [Implementing an API in ASP.NET Web API (6h)](http://pluralsight.com/training/Courses/TableOfContents/implementing-restful-aspdotnet-web-api)
  * [Building ASP.NET Web API OData Services (4h)](http://pluralsight.com/training/Courses/TableOfContents/aspnetwebapi-odata)



# Skills Being Measured

## Design the Application Architecture
* Design and implement the [Windows Azure role life cycle](http://msdn.microsoft.com/en-us/library/hh180152.aspx)
  * [identify and implement Start, Run, and Stop events](http://msdn.microsoft.com/en-us/library/gg456327.aspx)
  * identify startup tasks ([IIS configuration (app pool)](http://msdn.microsoft.com/en-us/library/gg433059.aspx), [registry configuration](http://blogs.msdn.com/b/sriharsha/archive/2012/08/26/changing-registry-settings-using-a-startup-task-in-azure.aspx), [third-party tools](https://www.simple-talk.com/cloud/platform-as-a-service/installing-third-party-software-on-windows-azure-%E2%80%93-what-are-the-options/))


## Design the User Experience
* Design and implement UI behavior:
  * [implement client validation](https://github.com/jgraber/70-480/blob/master/README.md)
  * [use JavaScript and the DOM to control application behavior](https://github.com/jgraber/70-480/blob/master/README.md)
  * [extend objects by using prototypal inheritance](https://github.com/jgraber/70-480/blob/master/README.md)
  * [use AJAX to make partial page updates](https://github.com/jgraber/70-480/blob/master/README.md)
  * [implement the UI by using JQuery](https://github.com/jgraber/70-480/blob/master/README.md)
 

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
  * Implement [one way](http://msdn.microsoft.com/en-us/library/ms733035(v=vs.110).aspx), [request/reply](http://msdn.microsoft.com/en-us/library/ms730913(v=vs.110).aspx), [streaming](http://msdn.microsoft.com/en-us/library/ms789010(v=vs.110).aspx), and [duplex communication](http://msdn.microsoft.com/en-us/library/ms731184(v=vs.110).aspx)
  * implement [Windows Azure Service Bus](http://blogs.technet.com/b/meamcs/archive/2011/12/23/my-hello-azure-service-bus-wcf-service-step-by-step-guide.aspx) and [Windows Azure Queues](http://azure.microsoft.com/en-us/documentation/articles/storage-dotnet-how-to-use-queues-20/)
* Host and manage services.
  * [Manage services concurrency (single, multiple, reentrant)](http://msdn.microsoft.com/en-us/library/orm-9780596521301-02-08.aspx)
  * [Create service hosts](http://msdn.microsoft.com/en-us/library/ms730158(v=vs.110).aspx)
  * [Choose a hosting mechanism](http://msdn.microsoft.com/en-us/library/ms730158(v=vs.110).aspx)
  * [choose an instancing mode (per call, per session, singleton)](http://www.c-sharpcorner.com/UploadFile/875c4c/instance-modes-in-wcf/)
  * [activate and manage a service by using AppFabric](http://msdn.microsoft.com/en-us/library/ee677312(v=azure.10).aspx)
  * [implement transactional services](http://msdn.microsoft.com/en-us/library/ff384250.aspx)
  * [host services in an Windows Azure worker role](http://blogs.msdn.com/b/fkaduk/archive/2013/12/09/implementing-rest-service-in-wcf-hosted-workerrole.aspx)


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
  * [Create and configure a NuGet package](http://docs.nuget.org/docs/creating-packages/creating-and-publishing-a-package)
  * [install and update an existing NuGet package](http://www.hanselman.com/blog/UpdatingAndPublishingANuGetPackagePlusMakingNuGetPackagesSmarterAndAvoidingSourceEditsWithWebActivator.aspx)
  * [connect to a local repository cache for NuGet](http://satalketo.com/2013/11/local-nuget-repository/)
  * [set up your own package repository](http://docs.nuget.org/docs/creating-packages/hosting-your-own-nuget-feeds)
* Share assemblies between multiple applications and servers.
  * [Prepare the environment for use of assemblies across multiple servers (interning)](http://blogs.technet.com/b/sateesh-arveti/archive/2011/11/30/look-at-sharing-common-assemblies-in-asp-net-4-5.aspx)
  * [sign assemblies by using a strong name](http://msdn.microsoft.com/en-us/library/xc31ft41(v=vs.110).aspx)
  * [deploy assemblies to the global assembly cache](http://msdn.microsoft.com/en-us/library/dkkx7f79(v=vs.110).aspx)
  * [implement assembly versioning](http://msdn.microsoft.com/en-us/library/gg608149.aspx)
  * [create an assembly manifest](http://msdn.microsoft.com/en-us/library/1w45z383(v=vs.110).aspx)
  * [configure assembly binding redirects (for example, from MVC2 to MVC3 or MVC4)](http://msdn.microsoft.com/en-us/library/vstudio/2fc472t2(v=vs.100).aspx)




