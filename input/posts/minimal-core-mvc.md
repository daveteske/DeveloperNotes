Title: Minimal ASP.Net Core MVC setup
Published: 1/8/2019
Tags: ASP.Net, MVC
---

Sometimes I want a very minimal setup, when trying out new things.
Below will creates such a project (Built with ASP.Net Core 2.1). 

Source Repo [https://github.com/daveteske/CoreMVCMinimal](https://github.com/daveteske/CoreMVCMinimal)

## Steps

1. Create a new *Empty* ASP.NET Core Web Application

![Empty Project ](EmptyMVCProject.png)


### Install MVC nuget package
1. ```Microsoft.AspNetCore.Mvc``` *Note: make sure the version major.minor match the project version. In this case*

```
project --> 2.1
nuget package --> 2.1.3
```

### Modify Startup.cs
1. add `services.AddMvc();` to `ConfigureServices`
1. optionally add this to `Configure`
    ```csharp 
    else
    {
        app.UseExceptionHandler("/Home/Error");
        app.UseHsts();
    }
    
    app.UseHttpsRedirection();
    app.UseStaticFiles();
    app.UseCookiePolicy();
    ```
1. Replace 
    ```csharp
    app.Run(async (context) =>
    {
     await context.Response.WriteAsync("Hello World!");
    });
    ```
    
with the following.
    
```csharp
	app.UseMvc(routes =>
	{
    	routes.MapRoute(
    	    name: "default",
    	    template: "{controller=Home}/{action=Index}/{id?}");
	});
```


### Add Controllers 
1. Create new folder **Controllers**
1. Create a new `HomeController`

### Add View
1. Click on `Add View...` on the controller action. Uncheck the `Use layout page`.

### Run and verify


