using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Guna.Charts.WinForms;

namespace EntityProj
{
    internal class Chart
    {
        /*
        private ImageDAO imageDAO = new ImageDAO();
        private Account account = new Account();
        private AccountDAO accountDAO = new AccountDAO();
        private ProductDAO productDAO = new ProductDAO();
        private Product product;
        public static void SplineYear(Guna.Charts.WinForms.GunaChart chart, int SellerID, string YearToFilter)
        {
            Chart obj = new Chart();
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            //Chart configuration 
            chart.YAxes.GridLines.Display = false;

            //Create a new dataset 
            var dataset = new Guna.Charts.WinForms.GunaSplineDataset();
            dataset.PointRadius = 3;
            dataset.PointStyle = PointStyle.Circle;
            for (int i = 0; i < months.Length; i++)
            {
                double data = (double)obj.FillDataYear(i + 1, SellerID, YearToFilter);
                dataset.DataPoints.Add(months[i], data);
            }

            //Add a new dataset to a chart.Datasets
            chart.Datasets.Add(dataset);

            //An update was made to re-render the chart
            chart.Update();
        }

        public static void BarYear(GunaChart chart, int SellerID, string YearToFilter)
        {
            Chart obj = new Chart();
            //Chart configuration 
            chart.YAxes.GridLines.Display = false;
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            //Create a new dataset 
            var dataset = new GunaBarDataset();
            for (int i = 0; i < months.Length; i++)
            {
                double data = (double)obj.FillDataYear(i + 1, SellerID, YearToFilter);
                dataset.DataPoints.Add(months[i], data);
            }
            chart.Datasets.Add(dataset);
            chart.Update();
        }



        public decimal FillDataYear(int month, int sellerID, string YearToFilter)
        {
            DataTable dt = new DataTable();
            dt = productDAO.ProfitEveryMonths(sellerID, YearToFilter);
            foreach (DataRow row in dt.Rows)
            {
                int rowMonth = row.Field<int>("MonthNumber");
                decimal earnings = row.Field<decimal>("TotalEarnings");

                if (rowMonth == month)
                {
                    return earnings;
                }
            }
            return 0;
        }

        public static void SplineMonth(Guna.Charts.WinForms.GunaChart chart, int SellerID, string YearToFilter, string MonthToFilter, int NoDayinMonth)
        {
            Chart obj = new Chart();
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            // Get the number of days in the specified month and year
            int year = Convert.ToInt32(YearToFilter);
            int monthIndex = int.Parse(MonthToFilter); // Get 1-based month index

            // Chart configuration
            chart.YAxes.GridLines.Display = false;

            // Create a new dataset
            var dataset = new Guna.Charts.WinForms.GunaSplineDataset();
            dataset.PointRadius = 3;
            dataset.PointStyle = PointStyle.Circle;

            // Loop through each day of the month
            for (int day = 1; day <= NoDayinMonth; day++)
            {
                double data = (double)obj.FillDataMonth(day, monthIndex, year, SellerID, NoDayinMonth);
                dataset.DataPoints.Add(day.ToString(), data);
            }

            // Add dataset to the chart
            chart.Datasets.Add(dataset);

            // Update the chart to re-render
            chart.Update();
        }

        public decimal FillDataMonth(int day, int month, int year, int sellerID, int noDaysInMonth)
        {
            DataTable dt = productDAO.ProfitEveryDay(sellerID, year, month, noDaysInMonth); // Retrieve daily profits for the specified month

            foreach (DataRow row in dt.Rows)
            {
                DateTime saleDate = row.Field<DateTime>("SaleDate");
                int rowDay = saleDate.Day; // Extract the day of the month from the SaleDate

                decimal earnings = row.Field<decimal>("TotalEarnings");

                if (rowDay == day)
                {
                    return earnings;
                }
            }

            return 0; // Return 0 if no data is found for the specified day
        }




        public static void BarHour(GunaChart chart, int SellerID, DateTime targetDate)
        {
            Chart obj = new Chart(); // Tạo một thể hiện của lớp Chart
                                     // Chart configuration
            chart.YAxes.GridLines.Display = false;

            // Create a new dataset 
            var dataset = new GunaBarDataset();

            // Loop through each hour of the day
            for (int hour = 0; hour < 24; hour++)
            {
                // Get data for the specific hour
                decimal data = obj.FillDataHour(hour, SellerID, targetDate);

                // Add data point for the hour
                dataset.DataPoints.Add($"{hour}:00", (double)data);
            }

            chart.Datasets.Add(dataset);
            chart.Update();
        }

        public decimal FillDataHour(int hour, int sellerID, DateTime targetDate)
        {
            DataTable dt = new DataTable();
            dt = productDAO.ProfitEveryHour(sellerID, targetDate);
            foreach (DataRow row in dt.Rows)
            {
                int rowHour = row.Field<int>("HourNumber");
                decimal earnings = row.Field<decimal>("TotalEarnings");

                if (rowHour == hour)
                {
                    return earnings;
                }
            }
            return 0;
        }

        public static void LineDay(Guna.Charts.WinForms.GunaChart chart, int SellerID, DateTime target, int daysAgo)
        {
            Chart obj = new Chart();
            chart.YAxes.GridLines.Display = false;

            DateTime[] daysBefore = new DateTime[daysAgo];
            for (int i = 0; i < daysAgo; i++)
            {
                daysBefore[i] = target.AddDays(-i - 1);
            }
            Array.Reverse(daysBefore);
            List<Tuple<DateTime, decimal>> list = new List<Tuple<DateTime, decimal>>();
            list = obj.FillDataDay(SellerID, daysBefore);
            var dataset = new Guna.Charts.WinForms.GunaLineDataset();
            dataset.PointRadius = 10;
            dataset.PointStyle = PointStyle.Circle;
            for (int i = 0; i < daysBefore.Length; i++)
            {
                dataset.DataPoints.Add((list[i].Item1).ToString("yyyy/MM/dd"), (double)list[i].Item2);
            }
            chart.Datasets.Add(dataset);
            chart.Update();
        }
        public List<Tuple<DateTime, decimal>> FillDataDay(int id, DateTime[] daysBefore)
        {
            List<Tuple<DateTime, decimal>> list = new List<Tuple<DateTime, decimal>>();
            foreach (DateTime day in daysBefore)
            {
                list.Add(new Tuple<DateTime, decimal>(day, 0));
            }
            List<Product> pd = productDAO.LoadListWithCondition("", id);
            foreach (Product product in pd)
            {
                DateTime completeDay = product.CompleteTime;
                string completeDayString = completeDay.ToShortDateString();
                Tuple<DateTime, decimal> dayTuple = list.Find(t => t.Item1.ToShortDateString() == completeDayString);
                if (dayTuple != null)
                {
                    int index = list.IndexOf(dayTuple);
                    list[index] = new Tuple<DateTime, decimal>(dayTuple.Item1, (dayTuple.Item2 + (decimal)product.SalePrice));
                }
            }
            return list;
        }
        */
    }
}
