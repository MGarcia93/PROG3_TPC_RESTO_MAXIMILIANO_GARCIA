using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Configuration;
using System.Net;
using System.Net.Mail;
using Dominio;
using Negocio;

namespace PresentacionWebForm
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        [WebMethod]
        public static List<DetalleMenu> listarMenu()
        {
            return InsumoNegocio.Menu();

        }

        [WebMethod]
        public static string enviarMail(string name,string email,string consult)
        {
            var fromAddress = new MailAddress("pruebacorreomg@gmail.com", "TPWEB");
            var toAddress = new MailAddress(email, name);
            const string fromPassword = "prueba1234";
            const string subject = "Consulta";
            string body =  consult.ToString();
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                smtp.Send(message);
            }
            return "{ \"Error\" :0 }";
        }
    }
}