namespace Telephony.Models
{
    using System.Linq;

    using Interfaces;
    using Telephony.Exceptions;

    public class Smartphone : ISmartphone
    {
        public Smartphone()
        {

        }

        public string Call(string phoneNumber)
        {
            if (!this.ValidatePhoneNumber(phoneNumber))
            {
                throw new InvalidPhoneNumberException();
            }

            return $"Calling... {phoneNumber}";
        }

        public string BrowseURL(string url)
        {
            if (!this.ValidateURL(url))
            {
                throw new InvalidURLException();
            }

            return $"Browsing: {url}!";
        }

        private bool ValidatePhoneNumber(string phoneNumber)
            => phoneNumber.All(ch => char.IsDigit(ch));

        private bool ValidateURL(string url)
            => url.All(ch => !char.IsDigit(ch));
    }
}