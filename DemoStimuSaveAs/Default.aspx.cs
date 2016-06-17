using System;
using System.Web.UI;
using Stimulsoft.Report;
using Stimulsoft.Report.MobileDesign;

namespace DemoStimuSaveAs
{
  public partial class _Default : Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
      {
        //TemplateDTO oTemplate = (TemplateDTO)Session["Template"];

        //if (oTemplate != null)
        {
          StiReport oReport = new StiReport();

          //if (!string.IsNullOrEmpty(oTemplate.Content))
          //{
          //  oReport.LoadFromString(oTemplate.Content);
          //}

          StiMobileDesigner1.Report = oReport;
          //}
          //else
          //{
          //  Response.Redirect("~/Templates");
          //}
        }
      }
    }
  }
}