using System.Net.Mail;
using System.Net;


//hotmail

var smtpClient = new SmtpClient("smtp.office365.com")
{
    Port = 587,
    Credentials = new NetworkCredential("YOUR MAIL ADRESS", "PASSWORD"),
    EnableSsl = true,
};

smtpClient.Send("YOUR MAIL ADRESS", "OTHER MAIL", "SUBJECT MESSAGE", "BODY MESSAGE");


// gmail

var smtpClient1 = new SmtpClient("smtp.gmail.com")
{
    Port = 587,
    Credentials = new NetworkCredential("YOUR MAIL ADRESS", "PASSWORD"),
    EnableSsl = true,
};

smtpClient1.Send("YOUR MAIL ADRESS", "OTHER MAIL", "SUBJECT MESSAGE", "BODY MESSAGE");