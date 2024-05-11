using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PrShip
{
    public partial class Leyout : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // GitHub ile giriş yapma işlevselliğini buraya ekleyin
                // GitHubApiClient sınıfını kullanarak GitHub'dan kullanıcı profili ve projelerini alabilirsiniz.
            }
        }
    }
}