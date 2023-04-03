using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo.Net5._0
{
    internal class VideoPost : Post
    {
        //property
        public string VideoURL { get; set; }
        public int Length { get; set; }

        //constructor
        public VideoPost() { }

        public VideoPost(string title, string sendByUsername, string videoURL, int length, bool isPublic)
        {
            //The following properties and the GetNextID method are inherited from Post.
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUsername;
            this.IsPublic = isPublic;

            //Property ImageURL is a member of the ImagePost, but not of Post.
            this.VideoURL = videoURL;
            this.Length = length;
        }
    }
}
