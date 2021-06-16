<!-- default file list -->
*Files to look at*:

* [CustomDashboardStateService.cs](./CS/MvcDashboard_DashboardStateCookies/App_Start/CustomDashboardStateService.cs) (VB: [CustomDashboardStateService.vb](./VB/MvcDashboard_DashboardStateCookies/App_Start/CustomDashboardStateService.vb))
* [DashboardConfig.cs](./CS/MvcDashboard_DashboardStateCookies/App_Start/DashboardConfig.cs) (VB: [DashboardConfig.vb](./VB/MvcDashboard_DashboardStateCookies/App_Start/DashboardConfig.vb))
* [HomeController.cs](./CS/MvcDashboard_DashboardStateCookies/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/MvcDashboard_DashboardStateCookies/Controllers/HomeController.vb))
* [Global.asax.cs](./CS/MvcDashboard_DashboardStateCookies/Global.asax.cs) (VB: [Global.asax.vb](./VB/MvcDashboard_DashboardStateCookies/Global.asax.vb))
* [Index.cshtml](./CS/MvcDashboard_DashboardStateCookies/Views/Home/Index.cshtml)
<!-- default file list end -->
# ASP.NET MVC Dashboard - How to save a dashboard state to cookies


The sample illustrates how to save the current [dashboard state](https://docs.devexpress.com/Dashboard/119765/web-dashboard/aspnet-mvc-dashboard-extension/manage-dashboard-state) (such as master filter or parameter values) to cookies on the client side and restore this state on the server side.
  
The following API is used in this example:

* The [ASPxClientDashboard.DashboardStateChanged](https://docs.devexpress.com/Dashboard/js-ASPxClientDashboard#js_aspxclientdashboard_dashboardstatechanged) event is handled to obtain the current dashboard state.
* The [ASPxClientUtils.SetCookie](https://docs.devexpress.com/AspNet/js-ASPxClientUtils.SetCookie.static(name-value)) client-side method is used to save the dashboard state to cookies.
* The [DashboardConfigurator.SetDashboardStateService](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.DashboardConfigurator.SetDashboardStateService(DevExpress.DashboardWeb.IDashboardStateService)) method applies the dashboard state loaded from the cookies.

## Documentation

- [Manage Dashboard State](https://docs.devexpress.com/Dashboard/119765/web-dashboard/aspnet-mvc-dashboard-extension/manage-dashboard-state)
