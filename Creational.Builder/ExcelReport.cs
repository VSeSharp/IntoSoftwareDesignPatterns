namespace Creational.Builder
{
    public class ExcelReport : ReportBuilder
    {
        public override void SetReportType()
        {
            ReportObject.ReportType = GetType().Name;
        }
        public override void SetReportHeader()
        {
            ReportObject.ReportHeader = GetType().Name + " Header";
        }
        public override void SetReportContent()
        {
            ReportObject.ReportContent = GetType().Name + " Content";
        }
        public override void SetReportFooter()
        {
            ReportObject.ReportFooter = GetType().Name + " Footer";
        }
    }
}
