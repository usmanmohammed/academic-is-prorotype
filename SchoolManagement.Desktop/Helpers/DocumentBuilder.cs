using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Desktop.Helpers
{
    public class DocumentBuilder
    {
        public static string ApplicationDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Baze University\\Shared";
        public static string FileName = "PrintPreview.html";
        public static string FileUrl = string.Format("{0}\\{1}", ApplicationDirectory, FileName);
        public static string DocumentHeader()
        {
            if (!Directory.Exists(ApplicationDirectory))
                Directory.CreateDirectory(ApplicationDirectory);
            
            StringBuilder headerContent = new StringBuilder();
            headerContent.Append("<!DOCTYPE html>");
            headerContent.Append("<head>");
            headerContent.Append("<link rel=\"stylesheet\" href=\"..//Content/bootstrap.css\" type=\"text/css\" media=\"print,screen\">");
            headerContent.Append("<meta http-equiv=\"X-UA-Compatible\" content = \"IE=edge,chrome=1\">");
            headerContent.Append("</head>");
            headerContent.Append("<body>");
            headerContent.Append("<p class=\"watermark\">BAZE UNIVERSITY</p>");
            headerContent.Append("<div class=\"row\">");
            headerContent.Append("<div class=\"col-md-12\">");
            headerContent.Append("<div class=\"row grey-div\">");
            headerContent.Append("<div class=\"col-md-12\">");
            headerContent.Append("<div class=\"col-md-offset-3 col-md-6\" style=\"padding-top: 10px; padding-bottom: 10px;\">");
            headerContent.Append("<img src=\"../Content/logo.png\" width=\"70\" height=\"70\" class=\"baze-logo\" alt=\"Baze University Logo\" />");
            headerContent.Append("<div align=\"center\" style=\"position: center\">");
            headerContent.Append("<h4><strong>BAZE UNIVERSITY, ABUJA</strong></h4>");
            headerContent.Append("<p class=\"reduce-top-margin\">Plot 686 Cadastral Zone C00, Kuchigoro, Abuja</p>");
            headerContent.Append(string.Format("<p class=\"reduce-top-margin\">Date: {0} {1}</p>", DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString()));
            headerContent.Append("</div>");
            headerContent.Append("</div>");
            headerContent.Append("<div class=\"col-md-3\">");
            headerContent.Append("</div>");
            headerContent.Append("</div>");
            headerContent.Append("</div>");
            headerContent.Append("<br />");
            return headerContent.ToString();
        }

        public static string DocumentHeaderNoWatermark()
        {
            if (!Directory.Exists(ApplicationDirectory))
                Directory.CreateDirectory(ApplicationDirectory);

            StringBuilder headerContent = new StringBuilder();
            headerContent.Append("<!DOCTYPE html>");
            headerContent.Append("<head>");
            headerContent.Append("<link rel=\"stylesheet\" href=\"..//Content/bootstrap.css\" type=\"text/css\" media=\"print,screen\">");
            headerContent.Append("<meta http-equiv=\"X-UA-Compatible\" content = \"IE=edge,chrome=1\">");
            headerContent.Append("</head>");
            headerContent.Append("<body>");
            headerContent.Append("<div class=\"row\">");
            headerContent.Append("<div class=\"col-md-12\">");
            headerContent.Append("<div class=\"row grey-div\">");
            headerContent.Append("<div class=\"col-md-12\">");
            headerContent.Append("<div class=\"col-md-offset-3 col-md-6\" style=\"padding-top: 10px; padding-bottom: 10px;\">");
            headerContent.Append("<img src=\"../Content/logo.png\" width=\"70\" height=\"70\" class=\"baze-logo\" alt=\"Baze University Logo\" />");
            headerContent.Append("<div align=\"center\" style=\"position: center\">");
            headerContent.Append("<h4><strong>BAZE UNIVERSITY, ABUJA</strong></h4>");
            headerContent.Append("<p class=\"reduce-top-margin\">Plot 686 Cadastral Zone C00, Kuchigoro, Abuja</p>");
            headerContent.Append(string.Format("<p class=\"reduce-top-margin\">Date: {0} {1}</p>", DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString()));
            headerContent.Append("</div>");
            headerContent.Append("</div>");
            headerContent.Append("<div class=\"col-md-3\">");
            headerContent.Append("</div>");
            headerContent.Append("</div>");
            headerContent.Append("</div>");
            headerContent.Append("<br />");
            return headerContent.ToString();
        }
        public static string DocumentTitle(string title, string month, string year)
        {
            StringBuilder titleContent = new StringBuilder();
            titleContent.Append("<div>");
            titleContent.Append("<h4 class=\"\">" + title + "</h4>");
            titleContent.Append("<p class=\"reduce-top-margin\">");
            titleContent.Append(string.Format("Populated {0} for Month of {1}, {2}", title, month, year));
            titleContent.Append("</p>");
            titleContent.Append("<p class=\"reduce-top-margin\"><strong>");
            titleContent.Append(string.Format("{0}, {1}", month, year));
            titleContent.Append("</strong></p>");
            titleContent.Append("</div>");
            return titleContent.ToString();
        }
        public static string DocumentSignatories()
        {
            StringBuilder signatoriesContent = new StringBuilder();
            signatoriesContent.Append("<hr />");
            signatoriesContent.Append("<br />");
            signatoriesContent.Append("<br />");
            signatoriesContent.Append("<div class=\"row\">");
            signatoriesContent.Append("<div class=\"col-md-12\">");
            signatoriesContent.Append("<div class=\"col-sm-5\">");
            signatoriesContent.Append("<p><strong>PREPARED BY: ____________________________________</strong></p>");
            signatoriesContent.Append("<br />");
            signatoriesContent.Append("<br />");
            signatoriesContent.Append("</div>");
            signatoriesContent.Append("<div class=\"col-sm-2\"><p></p></div>");
            signatoriesContent.Append("<div class=\"col-sm-5\">");
            signatoriesContent.Append("<p><strong>SIGNATURE AND DATE: _________________________________</strong></p>");
            signatoriesContent.Append("<br />");
            signatoriesContent.Append("<br />");
            signatoriesContent.Append("</div>");
            signatoriesContent.Append("<div class=\"col-sm-5\">");
            signatoriesContent.Append("<p><strong>CHECKED BY: _____________________________________</strong></p>");
            signatoriesContent.Append("<br />");
            signatoriesContent.Append("<br />");
            signatoriesContent.Append("</div>"); signatoriesContent.Append("<div class=\"col-sm-2\"><p></p></div>");

            signatoriesContent.Append("<div class=\"col-sm-5\">");
            signatoriesContent.Append("<p><strong>SIGNATURE AND DATE: _________________________________</strong></p>");
            signatoriesContent.Append("<br />");
            signatoriesContent.Append("<br />");
            signatoriesContent.Append("</div>");
            signatoriesContent.Append("<div class=\"col-sm-5\">");
            signatoriesContent.Append("<p><strong>APPROVED BY: ____________________________________</strong></p>");
            signatoriesContent.Append("<br />");
            signatoriesContent.Append("<br />");
            signatoriesContent.Append("</div>"); signatoriesContent.Append("<div class=\"col-sm-2\"><p></p></div>");

            signatoriesContent.Append("<div class=\"col-sm-5\">");
            signatoriesContent.Append("<p><strong>SIGNATURE AND DATE: _________________________________</strong></p>");
            signatoriesContent.Append("</div>");
            signatoriesContent.Append("</div>");
            signatoriesContent.Append("</div>");
            return signatoriesContent.ToString();
        }

        public static string DocumentSignatories2()
        {
            StringBuilder signatoriesContent = new StringBuilder();
            signatoriesContent.Append("<hr />");
            signatoriesContent.Append("<br />");
            signatoriesContent.Append("<br />");
            signatoriesContent.Append("<div class=\"row\">");
            signatoriesContent.Append("<div class=\"col-md-12\">");
            signatoriesContent.Append("<div class=\"col-sm-5\">");

            signatoriesContent.Append("<p><strong>APPROVED BY: ____________________________________</strong></p>");
            signatoriesContent.Append("<br />");
            signatoriesContent.Append("<br />");
            signatoriesContent.Append("</div>");
            signatoriesContent.Append("<div class=\"col-sm-2\"><p></p></div>");

            signatoriesContent.Append("<div class=\"col-sm-5\">");
            signatoriesContent.Append("<p><strong>SIGNATURE AND DATE: _________________________________</strong></p>");
            signatoriesContent.Append("</div>");
            signatoriesContent.Append("</div>");
            signatoriesContent.Append("</div>");
            return signatoriesContent.ToString();
        }

        public static string DocumentTitle(string title, TIMETABLE_TBL selectedTrimester, AMModule selectedModule, SMPreModuleResultEntry resultInformation)
        {
            StringBuilder titleContent = new StringBuilder();
            titleContent.Append("<div>");
            titleContent.Append($"<h4 class=\"\">{title} ({selectedTrimester.TT_CODE.Trim()})</h4>");
            titleContent.Append("<p class=\"\"><strong>");
            titleContent.Append($"{selectedModule.ModuleCode} ({selectedModule.ModuleDescription})");
            titleContent.Append("</strong></p>");
            titleContent.Append("<p class=\"reduce-top-margin\">");
            titleContent.Append($"C.A: {resultInformation.CAOnePerCon}%");
            titleContent.Append("</p>");
            titleContent.Append("<p class=\"reduce-top-margin\">");
            titleContent.Append($"Examination: {resultInformation.ExamPerCon}%");
            titleContent.Append("</p>");
            titleContent.Append("<p class=\"reduce-top-margin\">");
            titleContent.Append($"{resultInformation.TransactionID} - {resultInformation.TransactionIDTwo}");
            titleContent.Append("</p>");
            titleContent.Append("</div>");
            return titleContent.ToString();
        }

        public static string DocumentFooter()
        {
            StringBuilder footerContent = new StringBuilder();
            footerContent.Append("</div>");
            footerContent.Append("</div>");
            footerContent.Append("</body>");
            footerContent.Append("</html>");
            return footerContent.ToString();
        }
        public static void InsertToTextFile(HRStaff staff, HRStaffDetail staffdetails, HRStaffFinance staffFinance, decimal staffNetPay, string bankUrl)
        {
            using (StreamWriter writer = new StreamWriter(bankUrl, true))
            {
                writer.WriteLine(string.Format("{0},{1},{2},{3}",
                   staff.StaffID.Trim(), StaffHelper.GetStaffFullName(staffdetails).Replace(",", string.Empty), staffFinance.AccountNumber, staffNetPay));
                writer.Close();
            }
        }
    }
}
