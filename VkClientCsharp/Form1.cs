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
using VkNet.Enums;
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
                authentication.Parent = null;
                Friends.Visible = true;
            }
            catch (VkApiAuthorizationException)
            {
                LoginError f3 = new LoginError();
                f3.Show();
            }
            var profileInfo = vk.Account.GetProfileInfo();
            nameLabel.Text = profileInfo.FirstName + " " + profileInfo.LastName;
            var photos = vk.Photo.Get(new PhotoGetParams
            {
                OwnerId = vk.UserId.Value,
                AlbumId = VkNet.Enums.SafetyEnums.PhotoAlbumType.Profile
            });
            var friends = vk.Friends.Get(vk.UserId.Value,order: VkNet.Enums.SafetyEnums.FriendsOrder.Hints,fields: ProfileFields.FirstName | ProfileFields.LastName);
            foreach (var fCount in friends)
            {
                FriendsList.Items.Add(fCount.FirstName + fCount.LastName);
            }
            
            int friendsCount = friends.Count;            
            friendsCnt.Text = "Всего друзей " + Convert.ToString(friendsCount);            
            var online = vk.Friends.GetOnline(new FriendsGetOnlineParams
            {
                UserId = vk.UserId.Value
            });
            int friendsOnlineCount = online.Count;
            friendsOnlineCnt.Text = Convert.ToString(friendsOnlineCount) + "/" + Convert.ToString(friendsCount);
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
