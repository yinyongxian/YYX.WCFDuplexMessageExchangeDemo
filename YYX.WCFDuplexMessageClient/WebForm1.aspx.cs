using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.Hosting;
using System.Web.UI;
using System.Web.UI.WebControls;
using YYX.WCFDuplexMessageClient.ServiceReference1;

namespace YYX.WCFDuplexMessageClient
{
    public partial class WebForm1 : System.Web.UI.Page, IService1Callback
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            InstanceContext context = new InstanceContext(this);
            Service1Client service = new Service1Client(context);
            string result = service.GetData(100);
            Label1.Text = result;
        }

        public void TaskProcess(int number)
        {
            //this is invoked
        }
    }
}