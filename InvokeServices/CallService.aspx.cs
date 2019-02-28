using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InvokeServices
{
    public partial class CallService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtWCFId.Text);
            PostServiceReference.PostServiceClient postWcfService = new PostServiceReference.PostServiceClient();
            if (id == 1)
            {
                var post = postWcfService.GetPosts().FirstOrDefault(p=>p.Id==id);
                txtWCFTitle.Text = post.Title;
                txtWCFDescription.Text = post.Description;
            }
            else if (id == 2)
            {
                var post= postWcfService.GetPosts().FirstOrDefault(p => p.Id == id);
                txtWCFTitle.Text = post.Title;
                txtWCFDescription.Text = post.Description;
            }
            else
            {
                txtWCFTitle.Text = "Yanlış değer girdiniz";
                txtWCFDescription.Text = "Yanlış değer girdiniz";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtXMLId.Text);
            PostXMLServiceReference.PostXmlServiceSoapClient postXmlService = new PostXMLServiceReference.PostXmlServiceSoapClient();
            if (id == 1)
            {
                var postArray = postXmlService.GetPosts();
                txtXMLTitle.Text = postArray[0].Title;
                txtXMLDescription.Text = postArray[0].Description;
            }
            else if (id == 2)
            {
                var postArray = postXmlService.GetPosts();
                txtXMLTitle.Text = postArray[1].Title;
                txtXMLDescription.Text = postArray[1].Description;
            }
            else
            {
                txtXMLTitle.Text = "Yanlış değer girdiniz";
                txtXMLDescription.Text = "Yanlış değer girdiniz";
            }

        }
    }
}