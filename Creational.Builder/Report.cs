using System;

namespace Creational.Builder
{
    public class Report
    {
        public string ReportType { get; set; }
        public string ReportHeader { get; set; }
        public string ReportContent { get; set; }
        public string ReportFooter { get; set; }
        public void DisplayReport()
        {
            Console.WriteLine(nameof(ReportType) + ": " + ReportType);
            Console.WriteLine(nameof(ReportHeader) + ": " + ReportHeader);
            Console.WriteLine(nameof(ReportContent) + ": " + ReportContent);
            Console.WriteLine(nameof(ReportFooter) + ": " + ReportFooter);
        }
    }
}
