using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using PDFGenerator.DAL;

namespace PDFGenerator.Utility
{
    public static class TemplateGenerator
    {
        public static String GetHtmlString(IDbRepository dbRepository)
        {
            var clients = dbRepository.GetClients().Result;

            var sb = new StringBuilder();
            sb.Append(@"
                        <html>
                            <head>
                            </head>
                            <body>
                                <div class='header'><h1> This is the generated PDF report.</h1></div>
                                <table align='center'>
                                    <tr>
                                        <th>ID</th>
                                        <th>Name</th>
                                        <th>EmailAddress</th>
                                        <th>OfficePhone</th>
                                    </tr>");
            foreach(var client in clients)
            {
                sb.AppendFormat(@"<tr>
                                    <td>{0}</td>
                                    <td>{1}</td>
                                    <td>{2}</td>
                                    <td>{3}</td>
                                </tr>", client.ID, client.Name, client.EmailAddress, client.OfficePhone);
            }

            sb.Append(@"    </table>
                        </body>
                    </html>");

            return sb.ToString();
        }
    }
}
