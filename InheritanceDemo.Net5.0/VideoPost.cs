﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace InheritanceDemo.Net5._0
{
    internal class VideoPost : Post
    {
        //member fields
        protected bool isPlaying = false;
        protected int currDuration = 0;
        Timer timer;
        //property
        protected string VideoURL { get; set; }
        protected int Length { get; set; }


        //constructor
        public VideoPost() { }

        public VideoPost(string title, string sendByUsername, string videoURL, bool isPublic, int length)
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

        //Additional Methods
        public void Play()
        {
            if (!isPlaying)
            {
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
            }            
            
        }        

        private void TimerCallback(object o) 
        {
            if(currDuration < Length)
            {
                currDuration++;
                Console.WriteLine("Video at {0}s", currDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
        }

        public void Stop()
        {
            if(isPlaying)
            {
                Console.WriteLine("Stopped at {0}", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
            
        }

        //To.String Method
        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3} by {4}",
                this.ID, this.Title, this.VideoURL, this.Length, this.SendByUserName);
        }
    }
}
