70-492
======

Study notes on the 70-492 certification


# Links
* [Upgrade your MCPD: Web Developer 4 to MCSD: Web Applications](https://www.microsoft.com/learning/en-us/exam.aspx?id=70-492)
* [Building Web Apps with ASP.NET Jump Start](http://www.microsoftvirtualacademy.com/training-courses/create-web-apps-with-asp-net?prid=USLeX_MktgDR1A2#?fbid=Ydu36-D4uQu)
* [Developing Windows Azure and Web Services Jump Start](http://www.microsoftvirtualacademy.com/training-courses/developing-windows-azure-and-web-services-jump-start)
* [Study notes from @adnanmasood](http://blog.adnanmasood.com/2013/05/20/study-notes-for-70-486-developing-asp-net-mvc-4-web-applications/)

# Books
* [HTML5 and CSS3 (2nd edition)](http://graberj.wordpress.com/2014/03/26/buch-rezension-zu-html5-and-css3-2nd-edition/)
* [Pro ASP.NET MVC 5](http://www.apress.com/9781430265290)


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
  * [plan a localization strategy](http://programmers.stackexchange.com/questions/98358/effective-strategies-for-localization-in-net)
  * [create and apply resources to UI including JavaScript resources](http://msdn.microsoft.com/en-us/library/ms227427(v=vs.90).aspx) (and [here](http://msdn.microsoft.com/en-us/library/bb398868(v=vs.90).aspx) and [here](http://www.hanselman.com/blog/GlobalizationInternationalizationAndLocalizationInASPNETMVC3JavaScriptAndJQueryPart1.aspx))
  * [set cultures](http://msdn.microsoft.com/en-us/library/vstudio/bz9tc508(v=vs.100).aspx)
  * [create satellite resource assemblies](http://msdn.microsoft.com/en-us/library/vstudio/21a15yht(v=vs.100).aspx)
* Design and implement MVC controllers and actions.
  * [apply authorization attributes and global filters](http://www.dotnet-tricks.com/Tutorial/mvc/b11a280114-Understanding-ASP.NET-MVC-Filters-and-Attributes.html)
  * [implement action behaviors](http://www.asp.net/mvc/tutorials/hands-on-labs/aspnet-mvc-4-custom-action-filters)
  * [implement action results](http://msdn.microsoft.com/en-us/library/system.web.mvc.actionresult(v=vs.118).aspx)
  * [implement model binding](http://msdn.microsoft.com/en-us/magazine/hh781022.aspx)
* Control application behavior by using MVC extensibility points.
  * [implement MVC filters](http://msdn.microsoft.com/en-us/library/dd381609(v=vs.100).aspx) and [controller factories](http://www.dotnetcurry.com/showarticle.aspx?ID=878)
  * control application behavior by using [action results](http://brendan.enrick.com/post/types-of-aspnet-mvc-3-action-results.aspx), [viewengines](http://channel9.msdn.com/coding4fun/articles/Developer-Review-Four-ASPNET-MVC-View-Engines), [model binders](http://www.codeproject.com/Articles/605595/ASP-NET-MVC-Custom-Model-Binder), and [route handlers](http://weblogs.asp.net/fredriknormen/archive/2007/11/18/asp-net-mvc-framework-create-your-own-iroutehandler.aspx)
* Reduce network bandwidth.
  * [bundle and minify scripts (CSS and JavaScript)](http://weblogs.asp.net/scottgu/archive/2011/11/27/new-bundling-and-minification-support-asp-net-4-5-series.aspx) (or [here](http://stackoverflow.com/questions/14816151/asp-net-mvc-bundles-and-minification))
  * [compress and decompress data (using gzip/deflate; storage)](http://benfoster.io/blog/aspnet-web-api-compression)
  * [plan a content delivery network (CDN) strategy](http://www.hanselman.com/blog/PennyPinchingVideoMovingMyWebsitesImagesToTheAzureCDNAndUsingACustomDomain.aspx), for example, [Windows Azure CDN](http://msdn.microsoft.com/en-us/library/azure/ff919703.aspx)

  
## Troubleshoot and Debug Web Applications
* Debug a Windows Azure application
  * collect diagnostic information by [using Windows Azure Diagnostics API Implement on demand](http://msdn.microsoft.com/en-us/library/gg433048.aspx) vs. [scheduled](http://msdn.microsoft.com/en-us/library/dn186185.aspx)
  * [choose log types, for example, event logs, performance counters, and crash dumps](http://msdn.microsoft.com/en-us/library/hh694035.aspx)
  * debug a Windows Azure application by using [IntelliTrace](http://msdn.microsoft.com/en-us/library/ff683671.aspx) and [Remote Desktop Protocol (RDP)](http://antirandom.com/2012/09/20/remotely-debugging-a-windows-azure-webrole-via-visual-studio-debugger/)


## Design and Implement Security
* Design and implement claims-based authentication across federated identity stores.
  * [implement federated authentication by using Windows Azure Access Control Service](http://msdn.microsoft.com/en-us/library/hh446535.aspx)
  * [create a custom security token by using Windows Identity Foundation](http://blogs.msdn.com/b/mcsuksoldev/archive/2011/03/25/write-a-custom-security-token-and-handler-in-windows-identity-foundation.aspx)
  * handle token formats (for example, [oAuth, OpenID](http://blogs.msdn.com/b/webdev/archive/2012/08/15/oauth-openid-support-for-webforms-mvc-and-webpages.aspx), [LiveID, and Facebook](http://msdn.microsoft.com/en-us/library/gg185967.aspx)) for [SAML](http://msdn.microsoft.com/en-us/library/ms733083(v=vs.110).aspx) and [SWT tokens](http://msdn.microsoft.com/en-us/library/hh781551.aspx)


## Accessing Data
* Implement data storage in Windows Azure.
  * [access data storage in Windows Azure](http://msdn.microsoft.com/en-us/library/ee405490.aspx)
  * [Choose data storage mechanism in Windows Azure (blobs, tables, queues, SQL Database)](http://azure.microsoft.com/en-us/documentation/articles/storage-introduction/)
  * [Distribute data by using the Content delivery network (CDN)](http://azure.microsoft.com/en-us/documentation/articles/cdn-how-to-use/)
  * [Handle exceptions by using retries (SQL Database)](http://www.asp.net/aspnet/overview/developing-apps-with-windows-azure/building-real-world-cloud-apps-with-windows-azure/transient-fault-handling)
  * [manage Windows Azure Caching](http://azure.microsoft.com/en-us/services/cache/)
* [Create and configure a WCF service on Windows Azure](http://www.claudiobernasconi.ch/2013/08/03/deploying-a-wcf-service-on-windows-azure/):
  * [Address resources](http://blogs.msdn.com/b/nishasingh/archive/2012/12/05/creating-and-deploying-a-wcf-service-on-windows-azure-and-consuming-it-in-windows-8-store-app.aspx)
  * [implement filtering](http://msdn.microsoft.com/en-us/library/ms731081(v=vs.110).aspx)
  * [create a query expression](http://msdn.microsoft.com/en-us/library/dd673933(v=vs.110).aspx)
  * [access payload formats (including JSON)](http://msdn.microsoft.com/en-us/library/dd728282(v=vs.110).aspx)
  * [use data service interceptors](http://msdn.microsoft.com/en-us/library/dd744842(v=vs.110).aspx) and [service operators](http://msdn.microsoft.com/en-us/library/cc668788(v=vs.110).aspx)



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
  * [define HTTP resources with HTTP actions](http://bitoftech.net/2013/11/25/implement-http-actions-post-put-delete-web-api/)
  * [plan appropriate URI space, and map URI space using routing](http://blog.2partsmagic.com/restful-uri-design/)
  * [choose appropriate HTTP method (get, put, post, delete) to meet requirements](http://stackoverflow.com/questions/6203231/which-http-methods-match-up-to-which-crud-methods)
  * [choose appropriate format (Web API formats) for responses to meet requirements](http://www.asp.net/web-api/overview/formats-and-model-binding/media-formatters)
  * [plan when to make HTTP actions asynchronous](http://www.dotnetcurry.com/showarticle.aspx?ID=948)
* Implement a Web API.
  * [accept data in JSON format](http://stackoverflow.com/questions/20226169/how-to-pass-json-post-data-to-web-api-method-as-object) (in JavaScript, in an AJAX callback)
  * [use content negotiation to deliver different data formats to clients](http://www.asp.net/web-api/overview/formats-and-model-binding/content-negotiation)
  * [define actions and parameters to handle data binding](http://www.asp.net/web-api/overview/formats-and-model-binding/parameter-binding-in-aspnet-web-api)
  * [use HttpMessageHandler to process client requests and server responses](http://www.asp.net/web-api/overview/working-with-http/http-message-handlers)
  * [implement dependency injection, along with the dependency resolver, to create more flexible applications](http://www.asp.net/web-api/overview/extensibility/using-the-web-api-dependency-resolver)
  * [implement action filters](http://damienbod.wordpress.com/2014/01/04/web-api-2-using-actionfilterattribute-overrideactionfiltersattribute-and-ioc-injection/) and [exception filters](http://www.asp.net/web-api/overview/web-api-routing-and-actions/exception-handling#exception_filters) to manage controller execution
  * [implement asynchronous and synchronous actions](http://www.c-sharpcorner.com/UploadFile/2b481f/create-asynchronous-action-method-in-web-api/)
  * [implement streaming actions](http://www.strathweb.com/2013/01/asynchronously-streaming-video-with-asp-net-web-api/)
* Secure a Web API.
  * [implement HTTPBasic authentication over SSL](http://www.asp.net/web-api/overview/security/basic-authentication)
  * [implement Windows Auth](http://www.asp.net/web-api/overview/security/integrated-windows-authentication)
  * [enable cross-domain requests](http://www.asp.net/web-api/overview/security/enabling-cross-origin-requests-in-web-api)
  * [prevent cross-site request forgery (XSRF)](http://www.asp.net/web-api/overview/security/preventing-cross-site-request-forgery-(csrf)-attacks)
  * [implement, and extend, authorization filters to control access to the application](http://www.asp.net/web-api/overview/security/authentication-and-authorization-in-aspnet-web-api)
* Host and manage Web API.
  * [host Web API in an ASP.NET app](http://odetocode.com/blogs/scott/archive/2013/07/01/on-the-coexistence-of-asp-net-mvc-and-webapi.aspx)
  * [self-host a Web API in your own process (a Windows service)](http://www.asp.net/web-api/overview/hosting-aspnet-web-api/self-host-a-web-api)
  * [host services in a Windows Azure worker role](http://www.asp.net/web-api/overview/hosting-aspnet-web-api/host-aspnet-web-api-in-an-azure-worker-role)
  * [restricting message size](http://www.strathweb.com/2012/09/dealing-with-large-files-in-asp-net-web-api/)
  * [configure the host server for streaming](http://www.strathweb.com/2012/09/dealing-with-large-files-in-asp-net-web-api/)
* Consume Web API web services.
  * [consume Web API services by using HttpClient synchronously and asynchronously](http://www.asp.net/web-api/overview/web-api-clients/calling-a-web-api-from-a-net-client)
  * [send and receive requests in different formats (JSON/HTML/etc.)](http://www.asp.net/web-api/overview/web-api-clients/calling-a-web-api-from-a-net-client)


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




