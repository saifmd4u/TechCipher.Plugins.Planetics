TechCipher.Plugins.Planetics
============================

Using Google Analytics API and PlanetaryJS to show various pings around the world for a website.

Uses following dependencies

- Google APIs Client Library 1.7.0-beta (https://www.nuget.org/packages/Google.Apis/)
- planetaryjs (http://planetaryjs.com/)


Look at the following articles for more details of implementation
- http://www.saifikram.com/2014/01/using-google-analytics-api-and-planataryjs-to-show-traffic-accross-the-globe-part-1
- http://www.saifikram.com/2014/01/using-google-analytics-api-and-planataryjs-to-show-traffic-accross-the-globe-part-2

!/images/plantics.png!

Notes
=====
Install using Nuget Package (https://www.nuget.org/packages/TechCipher.Plugins.Planetics/)

Issues
======

Make sure youe web.config have following entries

	assemblyIdentity name="System.Web.WebPages" publicKeyToken="31bf3856ad364e35"
	bindingRedirect oldVersion="1.0.0.0-3.0.0.0" newVersion="3.0.0.0"

	assemblyIdentity name="System.Web.WebPages.Razor" publicKeyToken="31bf3856ad364e35"
	bindingRedirect oldVersion="1.0.0.0-3.0.0.0" newVersion="3.0.0.0"
=======

