
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using MimeKit;
namespace BookShoppingCartMVC.Services
{
    public class EmailSenderCustom : IEmailSenderCustom
    {

        public EmailSenderCustom()
        {
        }
        public async Task SendEmailConfirmRegister(string emailreceive, string content, string namereceive, string subject)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress("BeTun Store", "beminh22032003@gmail.com"));
            emailMessage.To.Add(new MailboxAddress(namereceive, emailreceive));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart("html")
            {
                Text = content
            };

            using var client = new SmtpClient();
            await client.ConnectAsync("smtp.gmail.com", 587);
            client.Authenticate("beminh22032003@gmail.com", "hyiq gqou aknp qgow");
            await client.SendAsync(emailMessage);
            await client.DisconnectAsync(true);
        }
        
    }
}
