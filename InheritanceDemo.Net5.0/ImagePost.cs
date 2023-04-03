using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo.Net5._0
{
    //ImagePost derives from Post and adds a property (ImageURL) and two constructors
    internal class ImagePost : Post
    {
        //property
        protected string ImageURL { get; set; }

        //constructor
        public ImagePost() { }

        public ImagePost(string title, string sendByUsername, string imageURL, bool isPublic)
        {
            //The following properties and the GetNextID method are inherited from Post.
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName= sendByUsername;
            this.IsPublic= isPublic;

            //Property ImageURL is a member of the VideoPost, but not of Post.
            this.ImageURL = imageURL;
        }

        //virtual method overide
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - by {3}", this.ID, this.Title, this.ImageURL, this.SendByUserName);
        }

    }
}
