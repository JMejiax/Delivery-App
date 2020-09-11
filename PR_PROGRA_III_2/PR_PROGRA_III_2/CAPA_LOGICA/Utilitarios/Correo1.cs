using CAPA_ENTIDADES.Clases;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CAPA_ENTIDADES.Utilitarios
{
    public class Correo1
    {
        /// <summary>
        /// Se encarga de enviar un correo
        /// </summary>
        /// <param name="Destinatario">Mail al cual se enviara</param>
        /// <param name="Mensaje">Mensaje del mail</param>
        /// <param name="Asunto">Asunto del mail</param>
        /// <param name="Archivos">Archivo a adjuntar, no es obligatorio</param>
        public static void EnviarCorreo(string Destinatario, string Mensaje, string Asunto, List<string> Archivos)
        {
            try
            {
                MailMessage mail = new MailMessage("deliverasa@gmail.com", Destinatario);
                SmtpClient smtpclient = new SmtpClient();
                smtpclient.Port = 587;
                smtpclient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpclient.UseDefaultCredentials = false;
                smtpclient.Host = "smtp.gmail.com";
                smtpclient.UseDefaultCredentials = false;
                mail.Subject = Asunto;
                mail.Body = Mensaje;
                smtpclient.EnableSsl = true;
                smtpclient.Credentials = new System.Net.NetworkCredential()
                {
                    UserName = "deliverasa@gmail.com",
                    Password = "123$$Jm7"
                };

                if (Archivos != null)
                {
                    foreach (var archivo in Archivos)
                    {
                        Attachment attachment = new Attachment(archivo);
                        mail.Attachments.Add(attachment);
                    }
                }
                smtpclient.Send(mail);
                smtpclient.Dispose();
            }catch (Exception)
            {
                throw new Exception("No se pudo enviar el correo");
            }
        }

        /// <summary>
        /// Valida si el correo es válido
        /// </summary>
        /// <param name="correo"></param>
        /// <returns>Retorna un boolean de acuerdo a si es valido el correo</returns>
        public static bool ValidarCorreo(string correo)
        {
            try
            {
                MailAddress m = new MailAddress(correo);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
