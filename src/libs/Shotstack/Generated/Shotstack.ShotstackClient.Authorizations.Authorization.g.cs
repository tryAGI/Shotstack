
#nullable enable

namespace Shotstack
{
    public sealed partial class ShotstackClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingAuthorization(
 )
        {

            Authorizations.Clear();
            Authorizations.Add(new global::Shotstack.EndPointAuthorization
            {
                Type = "",
                Location = "",
                Name = "",
                Value = "",
            });
        }
    }
}