using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using System.Web;
using System.Xml.Linq;

namespace MvcDashboard_DashboardStateCookies {
    internal class CustomDashboardStateService : IDashboardStateService {
        public DashboardState GetState(string dashboardId, XDocument dashboard) {
            HttpCookie cookie = HttpContext.Current.Request.Cookies["dashboardState"];
            if (cookie != null) {
                DashboardState dashboardState = new DashboardState();
                dashboardState.LoadFromJson(HttpUtility.UrlDecode(cookie.Value));
                return dashboardState;
            }
            else
                return null;
        }
    }
}