using System;
using System.Collections.Generic;
using System.Text;

namespace binui
{
    public class MainPage_ViewModel
    {
        public User User { get; }
        public MainPage_ViewModel()
        {
            User = new User
            {
                Username = "davidortinau",
                Email = "daortin@microsoft.com",
                TopFollowers = new string[]
                {
                    "https://avatars0.githubusercontent.com/u/36863?s=400&v=4",
                    "https://avatars2.githubusercontent.com/u/7827070?s=460&v=4",
                    "https://avatars0.githubusercontent.com/u/313003?s=400&v=4",
                    "https://avatars0.githubusercontent.com/u/538025?s=400&v=4",
                    "https://avatars2.githubusercontent.com/u/5375137?s=400&v=4",
                    "https://avatars3.githubusercontent.com/u/1235097?s=400&v=4",
                },
                FavoriteTech = new string[]
                {
                    ".NET", "C#", "Xamarin.Forms", "XAML", "SkiaSharp", "Azure"
                },
                Achievements = new string[]
                {
                    "\uf2d2", "\uf2ba", "\uf30c"
                }
            };
        }
    }
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public IEnumerable<string> TopFollowers { get; set; }
        public IEnumerable<string> FavoriteTech { get; set; }
        public IEnumerable<string> Achievements { get; set; }
    }
}
