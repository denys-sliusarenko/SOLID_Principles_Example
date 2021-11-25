using InterfaceSegregationPrinciple.Classes;
using InterfaceSegregationPrinciple.Interfaces;

IVoiceMessage voice = new VoiceMessage();
voice.Send();

IEmailMessage email  = new EmailMessage();
email.Text = "my message in email";
email.Send();

ITextMessage sms = new SmsMessage();
sms.Text = "my sms message";
sms.Send();