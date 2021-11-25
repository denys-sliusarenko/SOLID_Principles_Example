
using SingleResponsibilityPrinciple.Classes;

MobileStore store = new MobileStore(
    new ConsolePhoneReader(), new GeneralPhoneBinder(),
    new GeneralPhoneValidator(), new TextPhoneSaver());
store.Process();