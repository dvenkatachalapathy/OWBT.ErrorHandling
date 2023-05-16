using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace OWBT.ErrorHandlingHelper
{
    [Serializable]
    public class Helper
    {
        public string BuildMsgTbl(XmlDocument InMsg)
        {
            StringBuilder sb = new StringBuilder();
            
            XmlElement root = InMsg.DocumentElement;
            XmlNodeList nEvents = root.SelectNodes("//ErrorHandling/Events/Event");
            string msgtbl = string.Empty;
            int nInformation = 0;
            int nWarning = 0;
            int nError = 0;
            foreach (XmlNode nEvent in nEvents)
            {
               string msgtblTemp = "<tr>   <td style='width:10%;border-collapse:collapse;border:solid'>##Level##</td>   <td style='width:10%;border-collapse:collapse;border:solid'>##DateTime##</td>   <td style='width:10%;border-collapse:collapse;border:solid'>##Source##</td>   <td style='width:10%;border-collapse:collapse;border:solid'>##Category##</td>   <td style='width:60%;border-collapse:collapse;border:solid'>##Message##</td>  </tr>";
                switch(nEvent.SelectSingleNode("./Level").InnerText)
                {
                    case "Information" : nInformation++; break;
                    case "Warning": nWarning++; break;
                    case "Error": nError++; break;
                        
                }
                msgtblTemp = msgtblTemp.Replace("##Level##", nEvent.SelectSingleNode("./Level").InnerText);
                msgtblTemp = msgtblTemp.Replace("##DateTime##", nEvent.SelectSingleNode("./DateTime").InnerText);
                msgtblTemp = msgtblTemp.Replace("##Source##", nEvent.SelectSingleNode("./Source").InnerText);
                msgtblTemp = msgtblTemp.Replace("##Category##", nEvent.SelectSingleNode("./Category").InnerText);
                msgtblTemp = msgtblTemp.Replace("##Message##", nEvent.SelectSingleNode("./Message").InnerText);

                msgtbl = msgtbl + msgtblTemp;
            }
            string str = "<html>  <head> <meta http-equiv=Content-Type content='text/html; charset=windows-1252'> <meta name=Generator content='Microsoft Word 15 (filtered)'> <style> <!--  /* Font Definitions */  @font-face 	{font-family:'Cambria Math'; 	panose-1:2 4 5 3 5 4 6 3 2 4;} @font-face 	{font-family:Calibri; 	panose-1:2 15 5 2 2 2 4 3 2 4;}  /* Style Definitions */  p.MsoNormal, li.MsoNormal, div.MsoNormal 	{margin-top:0in; 	margin-right:0in; 	margin-bottom:8.0pt; 	margin-left:0in; 	line-height:107%; 	font-size:11.0pt; 	font-family:'Calibri',sans-serif;} .MsoChpDefault 	{font-family:'Calibri',sans-serif;} .MsoPapDefault 	{margin-bottom:8.0pt; 	line-height:107%;} @page WordSection1 	{size:8.5in 11.0in; 	margin:1.0in 1.0in 1.0in 1.0in;} div.WordSection1 	{page:WordSection1;} --> </style>  </head>  <body lang=EN-US style='word-wrap:break-word'>  <div class=WordSection1>  <p class=MsoNormal><span lang=EN-CA>Please find the list of events for the last ##NumberHours## hour(s)</span></p>  <p class=MsoNormal><span lang=EN-CA>&nbsp;</span></p>  <p class=MsoNormal><b><span lang=EN-CA>Event Viewer Summary</span></b></p>  <table class=MsoTableGrid border=1 cellspacing=0 cellpadding=0  style='border-collapse:collapse;border:solid'>  <tr>   <td style='width:33%;border-collapse:collapse;border:solid'>Information</td>   <td style='width:33%;border-collapse:collapse;border:solid'>Warning</td>   <td style='width:33%;border-collapse:collapse;border:solid'>Error</td>  </tr>  <tr>   <td style='border-collapse:collapse;border:solid'>##Information##</td>   <td style='border-collapse:collapse;border:solid'>##Warning##</td>   <td style='border-collapse:collapse;border:solid'>##Error##</td>  </tr> </table>  <p class=MsoNormal><span lang=EN-CA>&nbsp;</span></p>  <p class=MsoNormal><b><span lang=EN-CA>Event Viewer Details</span></b></p>  <table class=MsoTableGrid border=1 cellspacing=0 cellpadding=0  style='border-collapse:collapse;border:none'>  <tr>  <td style='width:10%;border-collapse:collapse;border:solid'>Level</td>   <td style='width:10%;border-collapse:collapse;border:solid'>Date Time</td>   <td style='width:10%;border-collapse:collapse;border:solid'>Source</td>   <td style='width:10%;border-collapse:collapse;border:solid'>Category</td>   <td style='width:60%;border-collapse:collapse;border:solid'>Message</td>    </tr>";
            str = str.Replace("##Information##", nInformation.ToString());
            str = str.Replace("##Warning##", nWarning.ToString());
            str = str.Replace("##Error##", nError.ToString());
            sb.Append(str);
            sb.Append(msgtbl);

            sb.Append("</table>  <p class=MsoNormal><b><span lang=EN-CA>&nbsp;</span></b></p>  </div>  </body>  </html>");

            System.Diagnostics.EventLog.WriteEntry("msg", sb.ToString());

            return sb.ToString();
        }

        
    }
}
