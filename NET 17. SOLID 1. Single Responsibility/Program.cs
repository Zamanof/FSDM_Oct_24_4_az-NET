using System.Text.RegularExpressions;
// Single Responsibility

#region Bad example
//class SendMail
//{
//    public bool Send(string mailAddress, string message)
//    {
//        if (IsMailAddressValid(mailAddress))
//        {
//            // send message to valid mailAddress
//            return true;
//        }
//        return false;
//    }

//    private bool IsMailAddressValid(string mailAddress)
//    {
//        Regex mailPattern = new(@"^[\w\.-]+@[\w\.-]+\.\w{2,}$");
//        return mailPattern.Match(mailAddress).Success;
//    }
//}

#endregion

#region Good example
class SendMail
{
    private MailAddressValidation _validation = new();
    public bool Send(string mailAddress, string message)
    {
        if (_validation.IsMailAddressValid(mailAddress))
        {
            // send message to valid mailAddress
            return true;
        }
        return false;
    }   
}

class MailAddressValidation
{
    public bool IsMailAddressValid(string mailAddress)
    {
        Regex mailPattern = new(@"^[\w\.-]+@[\w\.-]+\.\w{2,}$");
        return mailPattern.Match(mailAddress).Success;
    }
}

#endregion