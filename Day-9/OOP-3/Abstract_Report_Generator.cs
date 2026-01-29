using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{

    public abstract class ReportGenerator
    {
        public abstract void GenerateReport();

    }

    public class PDFReport : ReportGenerator
    {
        public override void GenerateReport()
        {
            Console.WriteLine("Generating Report Through PDF");
        }
    }

    public class ExcelReport : ReportGenerator
    {
        public override void GenerateReport()
        {
            Console.WriteLine("GEnerating Report Through Excel");
        }
        internal class Abstract_Report_Generator
        {
            static void Main()
            {
                PDFReport pdf = new PDFReport();
                pdf.GenerateReport();

                ExcelReport excel = new ExcelReport();
                excel.GenerateReport();
            }
        }
    }
}
