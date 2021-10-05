<script type="text/javascript">
    function onDashboardStateChanged(s, e) {
        var cookies = e.DashboardState;
        ASPxClientUtils.SetCookie('MVCxDashboardState', cookies);
    }
</script>

@Html.DevExpress().Dashboard(Sub(settings)
                                      settings.Name = "Dashboard"
                                      settings.ControllerName = "DefaultDashboard"
                                      settings.WorkingMode = DevExpress.DashboardWeb.WorkingMode.ViewerOnly
                                      settings.Width = Unit.Percentage(100)
                                      settings.Height = Unit.Percentage(100)
                                      settings.ClientSideEvents.DashboardStateChanged = "onDashboardStateChanged"
                                  End Sub).GetHtml()