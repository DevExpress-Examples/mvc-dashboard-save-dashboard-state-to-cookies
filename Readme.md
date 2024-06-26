<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579175/21.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T589151)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Dashboard for MVC - How to save a dashboard state to cookies

The sample illustrates how to save the current [dashboard state](https://docs.devexpress.com/Dashboard/119765/web-dashboard/aspnet-mvc-dashboard-extension/manage-dashboard-state) (such as master filter or parameter values) to cookies on the client side and restore this state on the server side:

* The [DashboardControlOptions.onDashboardStateChanged](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DashboardControlOptions?p=netframework#js_devexpress_dashboard_dashboardcontroloptions_ondashboardstatechanged) event  is handled to obtain the current dashboard state.
* The [ASPxClientUtils.SetCookie](https://docs.devexpress.com/AspNet/js-ASPxClientUtils.SetCookie.static(name-value)) client-side method is used to save the dashboard state to cookies.
* The [DashboardConfigurator.SetDashboardStateService](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWeb.DashboardConfigurator.SetDashboardStateService(DevExpress.DashboardWeb.IDashboardStateService)) method applies the dashboard state loaded from the cookies.

<!-- default file list -->
## Files to Look At

* [CustomDashboardStateService.cs](./CS/MvcDashboard_DashboardStateCookies/App_Start/CustomDashboardStateService.cs) (VB: [CustomDashboardStateService.vb](./VB/MvcDashboard_DashboardStateCookies/App_Start/CustomDashboardStateService.vb))
* [DashboardConfig.cs](./CS/MvcDashboard_DashboardStateCookies/App_Start/DashboardConfig.cs) (VB: [DashboardConfig.vb](./VB/MvcDashboard_DashboardStateCookies/App_Start/DashboardConfig.vb))
* [Global.asax.cs](./CS/MvcDashboard_DashboardStateCookies/Global.asax.cs) (VB: [Global.asax.vb](./VB/MvcDashboard_DashboardStateCookies/Global.asax.vb))
* [Index.cshtml](./CS/MvcDashboard_DashboardStateCookies/Views/Home/Index.cshtml)
<!-- default file list end -->

## Documentation

- [Manage Dashboard State](https://docs.devexpress.com/Dashboard/119765/web-dashboard/aspnet-mvc-dashboard-extension/manage-dashboard-state)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=mvc-dashboard-save-dashboard-state-to-cookies&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=mvc-dashboard-save-dashboard-state-to-cookies&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
