##CdnJs Helper
An ASP.net MVC3 web helper for loading scripts from http://cdnjs.com.  
To use the helper, 

1. Create a MVC project in Visual Studio  
2. Open the Tools->Package Manager->Package Manager Console
3. Run, "Install-Package CdnJs"  

Then you can use the helper by...

    
    @using CdnJs.Helpers
    @CdnJsHelper.LoadScript("jquery")
    @CdnJsHelper.LoadScript("underscore.js")
    @CdnJsHelper.LoadScript("backbone.js")
    
You can also place modify the Views/Web.Config file by...

    <namespaces>
        <add namespace="System.Web.Mvc" />
        <add namespace="System.Web.Mvc.Ajax" />
        <add namespace="System.Web.Mvc.Html" />
        <add namespace="System.Web.Routing" />
        <add namespace="CdnJs.Helpers" />
    </namespaces>  
    
This will allow you to not need the @using at the top of the view.

This is my first go round at a NuGet package, so please give feedback!

The list of packages available are located at... http://www.cdnjs.com/packages.json