@Html.DevExpress().Dashboard(Sub(settings)
    settings.Name = "Dashboard"
    settings.ControllerName = "DefaultDashboard"
    settings.WorkingMode = DevExpress.DashboardWeb.WorkingMode.ViewerOnly
    settings.Width = Unit.Percentage(100)
    settings.Height = Unit.Percentage(100)
    settings.ClientSideEvents.BeforeRender = "onBeforeRender"
End Sub).GetHtml()
