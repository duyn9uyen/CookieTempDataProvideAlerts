CookieTempDataProvideAlerts
===========================

A sample MVC Project using the CookieTempDataProvider and Bootstrap alerts. 
This project will illustrate how to add notifications on the serverside and client side via javascript.

1. Add the CookieTempDataProvider code
We used the CookieTempDataProvider from
https://github.com/KunleSmart/MvcExtensions/blob/master/src/CookieTempDataProvider.cs

2. Add a basecontroller that uses the CookieTempDataProvider
3. Added Bootstrap to project using NuGet for styling
	-(Added the reference to bootstrap.js and bootstrap.css in the _Layout.cshtml file.
4. Added notification icons (used http://www.famfamfam.com/lab/icons/silk/)
5. In _Layout.cshtml, moved the scripts into the <head> tag (so that jquery will work)
	@Scripts.Render("~/bundles/jquery")
    @RenderSection("scripts", required: false)
