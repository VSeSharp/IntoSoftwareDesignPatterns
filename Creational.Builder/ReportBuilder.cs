namespace Creational.Builder
{
    public abstract class ReportBuilder
    {
        protected Report ReportObject;
        public abstract void SetReportType();
        public abstract void SetReportHeader();
        public abstract void SetReportContent();
        public abstract void SetReportFooter();
        public void CreateNewReport()
        {
            ReportObject = new Report();
        }
        public Report GetReport()
        {
            return ReportObject;
        }
    }
}
