using DotNetOpenAuth.OAuth2;
using Google.Apis.Analytics.v3;
using Google.Apis.Analytics.v3.Data;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Authentication.OAuth2;
using Google.Apis.Authentication.OAuth2.DotNetOpenAuth;
using Google.Apis.Services;
using Google.Apis.Util;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace TechCipher.Plugins.Planetics
{
    public class GEOPosition
    {
        public int Lattidute;
        public int Longitude;
    }

    public static class TechCipherExtension
    {
        const string APIKEYPATH = "TechCipher.Google.Planetics.APIKeyPath";
        const string APIKEYPASSWORD = "TechCipher.Google.Planetics.APIKeyPassword";
        const string APICLIENTID = "TechCipher.Google.Planetics.APIClientId";
        const string GAID = "TechCipher.Google.Planetics.GAId";
        const string STARTDAYS = "TechCipher.Google.Planetics.StartDays";
        const string STARTDATE = "TechCipher.Google.Planetics.StartDate";
        const string ENDDAYS = "TechCipher.Google.Planetics.EndDays";
        const string ENDDATE = "TechCipher.Google.Planetics.EndDate";

        private static bool UpdateSettings(string startDays, string startDate, string endDays, string endDate, out string GAStartDate, out string GAEndDate)
        {
            bool bValid = false;
            int iStartDays = -1;
            int iEndDays = -1;
            DateTime dtStartDate = DateTime.Now;
            DateTime dtEndDate = DateTime.Now;
            GAStartDate = string.Empty;
            GAEndDate = string.Empty;

            if (startDays != null)
            {
                iStartDays = Convert.ToInt32(startDays);
                bValid = iStartDays >= 0;
            }
            else
            {
                iStartDays = -1;
                if (startDate != null)
                {
                    dtStartDate = Convert.ToDateTime(startDate);
                }
                else
                {
                    dtStartDate = DateTime.Now.AddDays(-7);
                }
                bValid = true;
            }

            if (bValid)
            {
                //https://developers.google.com/analytics/devguides/reporting/core/v3/reference
                //Start date for fetching Analytics data. Requests can specify a start date formatted as YYYY-MM-DD, or as a relative date (e.g., today, yesterday, or NdaysAgo where N is a positive integer).
                if (iStartDays > 0)
                {
                    GAStartDate = string.Format("{0}daysAgo", iStartDays);
                }
                else
                {
                    if (iStartDays == 0)
                    {
                        GAStartDate = "today";
                    }
                    else
                    {
                        GAStartDate = dtStartDate.ToString("yyyy-MM-dd");
                    }
                }
            }
            else
            {
                return bValid;
            }

            if (endDays != null)
            {
                iEndDays = Convert.ToInt32(endDays);
                bValid = iEndDays >= 0;
            }
            else
            {
                iEndDays = -1;
                if (endDate != null)
                {
                    dtEndDate = Convert.ToDateTime(endDate);
                }
                else
                {
                    dtEndDate = DateTime.Now.AddDays(-7);
                }
                bValid = true;
            }

            if (bValid)
            {
                //https://developers.google.com/analytics/devguides/reporting/core/v3/reference
                //End date for fetching Analytics data. Request can specify an end date formatted as YYYY-MM-DD, or as a relative date (e.g., today, yesterday, or NdaysAgo where N is a positive integer).
                if (iEndDays > 0)
                {
                    GAEndDate = string.Format("{0}daysAgo", iEndDays);
                }
                else
                {
                    if (iEndDays == 0)
                    {
                        GAEndDate = "today";
                    }
                    else
                    {
                        GAEndDate = dtEndDate.ToString("yyyy-MM-dd");
                    }
                }
            }

            return bValid;
        }

        private static List<GEOPosition> GetJsonPositions(GaData data)
        {
            List<GEOPosition> positions = new List<GEOPosition>();
            for (int row = 0; row < data.Rows.Count; row++)
            {
                int lattidute = (int)Convert.ToDouble(data.Rows[row][0].ToString());
                int longitude = (int)Convert.ToDouble(data.Rows[row][1].ToString());

                var foundPosition = positions.Find(p => p.Lattidute == lattidute && p.Longitude == longitude);
                if (foundPosition == null)
                {
                    positions.Add(new GEOPosition()
                    {
                        Lattidute = lattidute,
                        Longitude = longitude
                    });

                }
            }

            return positions;
        }

        private static string GetPlanetaryJS(string ID, string topoJson, List<GEOPosition> Positions)
        {
            string javascript = string.Empty;
            string globe = string.Format("globe{0}", ID);
            javascript = string.Format("var {0} = planetaryjs.planet();", globe);
            javascript += Environment.NewLine;
            javascript += "// Load our custom 'autorotate' plugin; see below.";
            javascript += Environment.NewLine;
            javascript += string.Format("{0}.loadPlugin(autorotate(10));", globe);
            javascript += Environment.NewLine;
            javascript += "// The 'earth' plugin draws the oceans and the land; it's actually";
            javascript += Environment.NewLine;
            javascript += "// a combination of several separate built-in plugins.";
            javascript += Environment.NewLine;
            javascript += "//";
            javascript += Environment.NewLine;
            javascript += "// Note that we're loading a special TopoJSON file";
            javascript += Environment.NewLine;
            javascript += "// (world-110m-withlakes.json) so we can render lakes.";
            javascript += Environment.NewLine;
            javascript += string.Format("{0}.loadPlugin(planetaryjs.plugins.earth(", globe) + "{";
            javascript += Environment.NewLine;
            javascript += "topojson: { file: '" + topoJson + "' },"; ///world-110m-withlakes.json
            javascript += Environment.NewLine;
            javascript += "oceans:   { fill:   '#000080' },";
            javascript += Environment.NewLine;
            javascript += "land:     { fill:   '#339966' },";
            javascript += Environment.NewLine;
            javascript += "borders:  { stroke: '#008000' }";
            javascript += Environment.NewLine;
            javascript += "}));";
            javascript += Environment.NewLine;
            javascript += "// Load our custom 'lakes' plugin to draw lakes; see below.";
            javascript += Environment.NewLine;
            javascript += string.Format("{0}.loadPlugin(lakes(", globe) + "{";
            javascript += Environment.NewLine;
            javascript += "fill: '#000080'";
            javascript += Environment.NewLine;
            javascript += "}));";
            javascript += Environment.NewLine;
            javascript += "// The 'pings' plugin draws animated pings on the globe.";
            javascript += Environment.NewLine;
            javascript += string.Format("{0}.loadPlugin(planetaryjs.plugins.pings());", globe);
            javascript += Environment.NewLine;
            javascript += "// The 'zoom' and 'drag' plugins enable";
            javascript += Environment.NewLine;
            javascript += "// manipulating the globe with the mouse.";
            javascript += Environment.NewLine;
            javascript += string.Format("{0}.loadPlugin(planetaryjs.plugins.zoom(", globe) + "{";
            javascript += Environment.NewLine;
            javascript += "scaleExtent: [100, 300]";
            javascript += Environment.NewLine;
            javascript += "}));";
            javascript += Environment.NewLine;
            javascript += string.Format("{0}.loadPlugin(planetaryjs.plugins.drag(", globe) + "{";
            javascript += Environment.NewLine;
            javascript += "// Dragging the globe should pause the";
            javascript += Environment.NewLine;
            javascript += "// automatic rotation until we release the mouse.";
            javascript += Environment.NewLine;
            javascript += "onDragStart: function() {";
            javascript += Environment.NewLine;
            javascript += "    this.plugins.autorotate.pause();";
            javascript += Environment.NewLine;
            javascript += "},";
            javascript += Environment.NewLine;
            javascript += "onDragEnd: function() {";
            javascript += Environment.NewLine;
            javascript += "    this.plugins.autorotate.resume();";
            javascript += Environment.NewLine;
            javascript += "}";
            javascript += Environment.NewLine;
            javascript += "}));";
            javascript += Environment.NewLine;
            javascript += "// Set up the globe's initial scale, offset, and rotation.";
            javascript += Environment.NewLine;
            javascript += string.Format("{0}.projection.scale(175).translate([175, 175]).rotate([0, -10, 0]);", globe);
            javascript += Environment.NewLine;

            javascript += "// Every few hundred milliseconds, we'll draw another random ping.";
            javascript += Environment.NewLine;
            string colors = string.Format("colors{0}", ID);
            javascript += Environment.NewLine;
            javascript += string.Format("var {0} = ['red', 'yellow', 'white', 'orange', 'green', 'cyan', 'pink'];", colors);
            javascript += Environment.NewLine;
            javascript += "setInterval(function() {";
            javascript += Environment.NewLine;
            foreach (GEOPosition position in Positions)
            {
                //javascript += "var lat = " + position.Lattidute; //Math.random() * 170 - 85;";
                //javascript += Environment.NewLine;
                //javascript += "var lng = " + position.Longitude; //Math.random() * 360 - 180;";
                //javascript += Environment.NewLine;
                //javascript += string.Format("var color = {0}[Math.floor(Math.random() * {0}.length)];", colors);
                //javascript += Environment.NewLine;
                //javascript += globe + ".plugins.pings.add(lng, lat, { color: color, ttl: 2000, angle: Math.random() * 10 });";

                javascript += globe + ".plugins.pings.add(" + position.Longitude + ", " + position.Lattidute + ", { color: "
                    + string.Format("{0}[Math.floor(Math.random() * {0}.length)]", colors)
                + ", ttl: 2000, angle: Math.random() * 10 });";
                javascript += Environment.NewLine;
            }
            javascript += "}, 150);";
            javascript += Environment.NewLine;

            string canvas = string.Format("canvas{0}", ID);
            javascript += string.Format("var {0} = document.getElementById('rotatingGlobe{1}');", canvas, ID);
            javascript += Environment.NewLine;
            javascript += "// Special code to handle high-density displays (e.g. retina, some phones)";
            javascript += Environment.NewLine;
            javascript += "// In the future, Planetary.js will handle this by itself (or via a plugin).";
            javascript += Environment.NewLine;
            javascript += "if (window.devicePixelRatio == 2) {";
            javascript += Environment.NewLine;
            javascript += string.Format("{0}.width = 800;", canvas);
            javascript += Environment.NewLine;
            javascript += string.Format("{0}.height = 800;", canvas);
            javascript += Environment.NewLine;
            string context = string.Format("context{0}", ID);
            javascript += string.Format("{0} = {1}.getContext('2d');", context, canvas);
            javascript += Environment.NewLine;
            javascript += string.Format("{0}.scale(2, 2);", canvas);
            javascript += Environment.NewLine;
            javascript += "}";
            javascript += Environment.NewLine;
            javascript += "// Draw that globe!";
            javascript += Environment.NewLine;
            javascript += string.Format("{0}.draw({1});", globe, canvas);
            javascript += Environment.NewLine;

            return javascript;
        }

        private static string GetErrors(string apiClientId, string apiKeyPath, string apiKeyPassword, string gaAnalyticsId, string startDays, string startDate, string endDays, string endDate)
        {
            string errMessage = string.Empty;

            if (apiClientId.StartsWith("999999999999999999999999999999999999999999999"))
            {
                errMessage += string.Format("Invalid '{0}' - '{1}'<br/>", APICLIENTID, apiClientId);
            }

            if (apiKeyPath.StartsWith("9999999999999999999999999999999999999999"))
            {
                errMessage += string.Format("Invalid '{0}' - '{1}'<br/>", APIKEYPATH, apiKeyPath);
            }

            if (apiKeyPassword.StartsWith("9999999999"))
            {
                errMessage += string.Format("Invalid '{0}' - '{1}'<br/>", APIKEYPASSWORD, apiKeyPassword);
            }

            if (gaAnalyticsId.StartsWith("99999999"))
            {
                errMessage += string.Format("Invalid '{0}' - '{1}'<br/>", GAID, gaAnalyticsId);
            }

            if (startDays != null && startDays.StartsWith("n1"))
            {
                errMessage += string.Format("Invalid '{0}' - '{1}'<br/>", STARTDAYS, startDays);
            }

            if (startDate != null && startDate.StartsWith("dd/mm/yyyy"))
            {
                errMessage += string.Format("Invalid '{0}' - '{1}'<br/>", STARTDATE, startDate);
            }

            if (endDays != null && endDays.StartsWith("n2"))
            {
                errMessage += string.Format("Invalid '{0}' - '{1}'<br/>", ENDDAYS, endDays);
            }

            if (endDate != null && endDate.StartsWith("dd/mm/yyyy"))
            {
                errMessage += string.Format("Invalid '{0}' - '{1}'<br/>", ENDDATE, endDate);
            }

            return errMessage;
        }

        public static MvcHtmlString GooglePings(this HtmlHelper helper, string ID, string topoJson)
        {
            string html = string.Empty;
            string errorHtml = "<table border='1' style='background-color:#B33030; color: white;' width='100%'>";
            errorHtml += "<tbody>";
            errorHtml += "<tr>";
            errorHtml += "<td style=' padding: 10px'><b>GooglePings</b><br/>{0}</td>";
            errorHtml += "</tr>";
            errorHtml += "</tbody>";
            errorHtml += "</table>";

            try
            {
                string apiKeyPath;
                string apiKeyPassword;
                string apiClientId;
                string gaAnalyticsId;
                string startDays;
                string startDate;
                string endDays;
                string endDate;

                string dimensions;
                string GAStartDate;
                string GAEndDate;

                apiKeyPath = ConfigurationManager.AppSettings[APIKEYPATH];
                apiKeyPassword = ConfigurationManager.AppSettings[APIKEYPASSWORD];
                apiClientId = ConfigurationManager.AppSettings[APICLIENTID];
                gaAnalyticsId = ConfigurationManager.AppSettings[GAID];
                startDays = ConfigurationManager.AppSettings[STARTDAYS];
                startDate = ConfigurationManager.AppSettings[STARTDATE];
                endDays = ConfigurationManager.AppSettings[ENDDAYS];
                endDate = ConfigurationManager.AppSettings[ENDDATE];

                apiKeyPath = Path.GetFullPath(System.Web.HttpContext.Current.Server.MapPath("~") + apiKeyPath);
                string errMessage = GetErrors(apiClientId, apiKeyPath, apiKeyPassword, gaAnalyticsId, startDays, startDate, endDays, endDate);
                if (errMessage == string.Empty)
                {
                    #region Setup

                    GAStartDate = string.Empty;
                    GAEndDate = string.Empty;
                    bool bValid = UpdateSettings(startDays, startDate, endDays, endDate, out GAStartDate, out GAEndDate);

                    #endregion Setup

                    #region Google API Calls

                    if (bValid)
                    {
                        dimensions = "ga:latitude,ga:longitude";
                        var certificate = new X509Certificate2(apiKeyPath, apiKeyPassword, X509KeyStorageFlags.MachineKeySet | X509KeyStorageFlags.Exportable);
                        ServiceAccountCredential credential = new ServiceAccountCredential(
                          new ServiceAccountCredential.Initializer(apiClientId)
                          {
                              Scopes = new[] { AnalyticsService.Scope.Analytics }
                          }.FromCertificate(certificate));

                        AnalyticsService analyticsService = new AnalyticsService(new BaseClientService.Initializer() { HttpClientInitializer = credential });
                        //DataResource.GaResource.GetRequest request = analyticsService.Data.Ga.Get("ga:79951341", "2014-01-08", "2014-01-08", "ga:visitors");

                        //https://developers.google.com/analytics/devguides/reporting/core/v3/reference
                        //Start date for fetching Analytics data. Requests can specify a start date formatted as YYYY-MM-DD, or as a relative date (e.g., today, yesterday, or NdaysAgo where N is a positive integer).
                        //End date for fetching Analytics data. Request can specify an end date formatted as YYYY-MM-DD, or as a relative date (e.g., today, yesterday, or NdaysAgo where N is a positive integer).

                        DataResource.GaResource.GetRequest request = analyticsService.Data.Ga.Get(string.Format("ga:{0}", gaAnalyticsId), GAStartDate, GAEndDate, "ga:visitors");
                        request.Dimensions = dimensions; //"ga:pagePath,ga:latitude,ga:longitude,ga:city,";
                        request.Sort = "-ga:visitors";
                        request.MaxResults = 50;
                        GaData data = request.Execute();
                        List<GEOPosition> Positions = GetJsonPositions(data);

                        html = string.Format(@"<canvas id='rotatingGlobe{0}' width='400' height='400' style='width: 400px; height: 400px; cursor: move;'></canvas><br/>", ID);
                        html += Environment.NewLine;
                        string planetaryjs = GetPlanetaryJS(ID, topoJson, Positions);
                        html += string.Format("<script>{0}</script>", planetaryjs);

                    #endregion Google API Calls
                    }
                    else
                    {
                        html = string.Format(errorHtml, @"Configuration not set properly for either of the following APIKeyPath, APIKeyPassword, APIClientId, GAId, Please refer to readme for further information");
                    }
                }
                else
                {
                    html = string.Format(errorHtml, errMessage);
                }
            }
            catch (Exception ex)
            {
                string error = ex.Message + "</br>" + "</br>" + ex.StackTrace;
                html = string.Format(errorHtml, error);
            }
            return MvcHtmlString.Create(html);

        }
    }
}
