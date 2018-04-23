# ASP.NET MVC Dashboard - How to save a dashboard state to cookies


<p>The sample illustrates how to save the current <a href="https://documentation.devexpress.com/Dashboard/119765/Building-the-Designer-and-Viewer-Applications/Web-Dashboard/ASP-NET-MVC-Dashboard-Extension/Manage-Dashboard-State">ASP.NET MVC Dashboard state</a> (such as master filter or parameter values) to cookies on the client side and restore this state on the server side. The following API is used in this example

* The <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebScriptsASPxClientDashboard_DashboardStateChangedtopic">ASPxClientDashboard.DashboardStateChanged</a> event is handled to obtain the current dashboard state.
* The <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebScriptsASPxClientUtils_SetCookietopic">ASPxClientUtils.SetCookie</a> client-side method is used to save the dashboard state to cookies.<br>- The <a href="https://documentation.devexpress.com/Dashboard/DevExpress.DashboardWeb.DashboardConfigurator.SetDashboardStateService.method">DashboardConfigurator.SetDashboardStateService</a> method is used to apply the dashboard state loaded from the cookies.</p>

<br/>


