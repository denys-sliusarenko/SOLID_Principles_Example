using InterfaceSegregationPrinciple.Classes;

Console.WriteLine("Example 1");
Console.WriteLine();

VoiceMessage voice = new();
voice.Send();

EmailMessage email = new();
email.Text = "my message in email";
email.Send();

SmsMessage sms = new();
sms.Text = "my sms message";
sms.Send();

Console.WriteLine();
Console.WriteLine("Example 2");
Console.WriteLine();

Photograph photograph = new();
Phone lumia950 = new();
Camera camera = new();
photograph.TakePhoto(lumia950);
photograph.TakePhoto(camera);