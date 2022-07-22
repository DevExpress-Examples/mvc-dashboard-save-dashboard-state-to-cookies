<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579175/22.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T589151)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Dashboard for MVC - How to save a dashboard state to cookies

The example shows how to save the current dashboard state (such as master filter or parameter values) to cookies on the client side and restore this state on the server side.

![](web-dashboard-cookies.png)

## Client

The [DashboardControlOptions.onDashboardStateChanged](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DashboardControlOptions?p=netframework#js_devexpress_dashboard_dashboardcontroloptions_ondashboardstatechanged) event occurs every time the dashboard state changes. In the event handler, the [DashboardControl.getDashboardState](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DashboardControl?p=netframework#js_devexpress_dashboard_dashboardcontrol_getdashboardstate) method call gets the current dashboard state. The [document.cookie](https://www.w3schools.com/js/js_cookies.asp) property is used to save the dashboard state to cookies every time the state changes.

## Server

The [DashboardConfigurator.SetDashboardStateService](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.DashboardConfigurator.SetDashboardStateService(DevExpress.DashboardWeb.IDashboardStateService)) method
specifies a service that allows you to manage a dashboard state. In this service, the [HttpRequest.Cookies](https://docs.microsoft.com/en-us/dotnet/api/system.web.httprequest.cookies) property gets a collection of cookies sent by the client.

## Files to Look At

* [CustomDashboardStateService.cs](./CS/MvcDashboard_DashboardStateCookies/App_Start/CustomDashboardStateService.cs) (VB: [CustomDashboardStateService.vb](./VB/MvcDashboard_DashboardStateCookies/App_Start/CustomDashboardStateService.vb))
* [DashboardConfig.cs](./CS/MvcDashboard_DashboardStateCookies/App_Start/DashboardConfig.cs#L13) (VB: [DashboardConfig.vb](./VB/MvcDashboard_DashboardStateCookies/App_Start/DashboardConfig.vb))
* [Index.cshtml](./CS/MvcDashboard_DashboardStateCookies/Views/Home/Index.cshtml)
* [_rootLayout.cshtml](./CS/MvcDashboard_DashboardStateCookies/Views/Shared/_rootLayout.cshtml#L16)
* [Script.js](./CS/MvcDashboard_DashboardStateCookies/Script/Script.js)

## Documentation

- [Manage Dashboard State](https://docs.devexpress.com/Dashboard/119765/web-dashboard/aspnet-mvc-dashboard-extension/manage-dashboard-state)

## More Examples

- [Dashboard for MVC - How to specify a default dashboard state in code](https://github.com/DevExpress-Examples/asp-net-mvc-dashboard-specify-default-state-in-code)
- [Dashboard for Web Forms - How to Save a Dashboard State to Cookies](https://github.com/DevExpress-Examples/asp-net-web-forms-dashboard-save-dashboard-state-to-cookies)
