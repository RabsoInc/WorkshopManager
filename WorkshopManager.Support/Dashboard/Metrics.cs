using WorkshopManager.Models.System.InternalModels;

namespace WorkshopManager.Support.Dashboard
{
    public static class Metrics
    {
        public static IEnumerable<DashboardMetric> ReturnMetrics()
        {
            DashboardMetric A = new DashboardMetric
            {
                Text = "Open Jobs",
                Value = "7"
            };
            DashboardMetric B = new DashboardMetric
            {
                Text = "Outstanding Revenue",
                Value = "£1327.99"
            };
            DashboardMetric C = new DashboardMetric
            {
                Text = "Forecasted Revenue",
                Value = "£12764.98"
            };
            DashboardMetric D = new DashboardMetric
            {
                Text = "Vendor Payments Due",
                Value = "£287.87"
            };
            var list = new List<DashboardMetric>();
            list.Add(A);
            list.Add(B);
            list.Add(C);
            list.Add(D);
            return list;

        }
    }
}
