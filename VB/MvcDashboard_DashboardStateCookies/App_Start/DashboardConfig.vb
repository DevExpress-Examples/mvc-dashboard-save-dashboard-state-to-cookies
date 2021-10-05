Imports System.Web.Routing
Imports DevExpress.DashboardWeb
Imports DevExpress.DashboardWeb.Mvc

Namespace MvcDashboard_DashboardStateCookies
    Public NotInheritable Class DashboardConfig

        Private Sub New()
        End Sub

        Public Shared Sub RegisterService(ByVal routes As RouteCollection)
            routes.MapDashboardRoute("dashboardControl", "DefaultDashboard")

            Dim dashboardFileStorage As New DashboardFileStorage("~/App_Data/Dashboards")
            DashboardConfigurator.Default.SetDashboardStorage(dashboardFileStorage)

            DashboardConfigurator.Default.SetDashboardStateService(New CustomDashboardStateService())
        End Sub
    End Class
End Namespace