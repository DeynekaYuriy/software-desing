using Business.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    //Interface Segregation Principle, A client should never be forced to implement an interface that it doesn't use
    public interface IReportProfit
    {
        public List<ReportProfit> GetProfits();
    }
    public interface IReportSubmissions
    {
        public List<ReportSubmission> GetSubmissions();
    }
    public interface IReportInventory
    {
        public List <ReportInventory> GetInventory();
    }
}
