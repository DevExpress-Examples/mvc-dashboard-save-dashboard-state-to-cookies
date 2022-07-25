Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb

Namespace MvcDashboard_DashboardStateCookies
    Friend Class CustomDashboardStateService
        Implements IDashboardStateService

        Public Function GetState(ByVal dashboardId As String, ByVal dashboard As XDocument) As DashboardState Implements IDashboardStateService.GetState
            Dim cookie As HttpCookie = HttpContext.Current.Request.Cookies("dashboardState")
            If cookie IsNot Nothing Then
                Dim dashboardState As New DashboardState()
                dashboardState.LoadFromJson(HttpUtility.UrlDecode(cookie.Value))
                Return dashboardState
            Else
                Return Nothing
            End If
        End Function
    End Class
End Namespace