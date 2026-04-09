
#nullable enable

namespace Shotstack
{
    public sealed partial class ShotstackClient
    {

        /// <inheritdoc/>
        public void AuthorizeUsingAuthorization(
 )
        {

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "")
                {
                    Authorizations.RemoveAt(i);
                }
            }

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