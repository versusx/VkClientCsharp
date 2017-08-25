using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Exception;
using VkNet.Model.RequestParams;

namespace VkClientCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
                
        }
        VkApi vk = new VkApi();
        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string email = textBox1.Text;
                string pass = textBox2.Text;
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
            authentication.Parent = null;
            Friends.Visible = true;
            var profileInfo = vk.Account.GetProfileInfo();
            label3.Text = profileInfo.FirstName + " " + profileInfo.LastName;
            var photos = vk.Photo.Get(new PhotoGetParams
            {
                OwnerId = vk.UserId.Value,
                AlbumId = VkNet.Enums.SafetyEnums.PhotoAlbumType.Profile
            });
            
            var online = vk.Friends.GetOnline(new FriendsGetOnlineParams
            {
                UserId = vk.UserId.Value
            });
            foreach(var item in online)
            {
                onlineFriends.Text  = item.ToString();
            }
            var wall = vk.Wall.Get(new WallGetParams
            {
                OwnerId = vk.UserId.Value,
                Count = 30
            });
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void allFrinedsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
