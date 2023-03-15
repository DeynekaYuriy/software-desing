using Business.Interfaces;
using Business.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    //Single Responsibility Principle. Each object has one responsibility and this responsibility is completely encapsulated in a class
    public class Reporting : IReportInventory, IReportProfit, IReportSubmissions
    {
        private List<Warehouse> _warehouses { get; set; }

        public Reporting(List<Warehouse> warehouses)
        {
            _warehouses = warehouses;
        }

        public List<ReportInventory> GetInventory()
        {
            List<ReportInventory> reportList = new List<ReportInventory>();
            foreach (var item in _warehouses)
            {
                var reportInventory = new ReportInventory();
                reportInventory.Name = item.Name;
                reportInventory.Unit = item.Unit;
                reportInventory.Quantity = item.Quantity;
                reportList.Add(reportInventory);
            }
            return reportList;
        }

        public List<ReportProfit> GetProfits()
        {
            List<ReportProfit> reportList = new List<ReportProfit>();
            foreach (var item in _warehouses)
            {
                var reportProfit = new ReportProfit();
                reportProfit.Name = item.Name;
                reportProfit.Price = new Money(item.Currency, item.GetAmount());
                reportProfit.Quantity = item.Quantity;
                reportProfit.ProfitAmount = new Money(item.Currency, item.GetAmount()*item.Quantity);
                reportList.Add(reportProfit);
            }
            return reportList;
        }

        public List<ReportSubmission> GetSubmissions()
        {
            List<ReportSubmission> reportList = new List<ReportSubmission>();
            foreach (var item in _warehouses)
            {
                var reportSubmission = new ReportSubmission();
                reportSubmission.Name = item.Name;
                reportSubmission.Quantity = item.Quantity;
                reportSubmission.Unit = item.Unit;
                reportSubmission.Date = item.LastAdmissionDate;
                reportList.Add(reportSubmission);
            }
            return reportList;
        }
    }
}
