
using System;
using System.Net;
using System.Net.Mail;

public class EmailVerifier
{
    public bool VerifyEmailExists(string email)
    {
        try
        {
            var host = "smtp.example.com"; // Replace with your SMTP server
            var port = 587; // Replace with the appropriate port number
            var fromAddress = "your-email@example.com"; // Replace with your email address
            var fromPassword = "your-password"; // Replace with your email password

            using (var smtpClient = new SmtpClient(host, port))
            {
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential(fromAddress, fromPassword);

                using (var message = new MailMessage(fromAddress, email))
                {
                    message.Subject = "Email verification test";
                    message.Body = "This is a test email to verify email existence.";

                    smtpClient.Send(message);
                }
            }

            return true; // Email was sent successfully
        }
        catch (Exception)
        {
            return false; // Failed to send email or email address does not exist
        }
    }
}
