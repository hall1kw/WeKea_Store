using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Category : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string IDCAT = Request.QueryString["IDCAT"];
                if (IDCAT != null)
                {
                    dlCategory.DataSource = DataAccess.selectQuery("SELECT * FROM PRODUCTS WHERE IDCAT=" + IDCAT);
                    dlCategory.DataBind();
                }
            }
            
        }
    }
}