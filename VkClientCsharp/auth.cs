using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Exception;

namespace VkClientCsharp
{
    public class auth
    {
        public void SignIn(string em, string psswd)
        {
            var vk = new VkApi();
            try
            {
                string email = em;
                string pass = psswd;
                Settings scope = Settings.All;
                ulong appId = 6159996;
                vk.Authorize(new ApiAuthParams
                {
                    ApplicationId = appId,
                    Login = email,
                    Password = pass,
                    Settings = scope
                });
                var setOnline = vk.Account.SetOnline();
            }
            catch (VkApiAuthorizationException)
            {
                LoginError f3 = new LoginError();
                f3.Show();
            }
        }        
    }
}
