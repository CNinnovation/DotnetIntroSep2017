using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms1
{
    public partial class FirstForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnSelectionChanged(object sender, EventArgs e)
        {
            string selection = this.DropDownList1.SelectedItem.Value;
            this.TextBox1.Text = $"selected: {selection}";
        }
    }
}