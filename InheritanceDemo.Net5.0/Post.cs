﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo.Net5._0
{
    internal class Post
    {
        //variable
        private static int currentPostId;

        //properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendByUserName { get; set; }
        protected bool IsPublic { get; set; }

        //Default constructor. If a derived class does not invoke a base-class constructor explicitly
        //the default constructor is called implicitly.
        public Post() 
        {
            ID = 0;
            Title = "My First Post";
            IsPublic = true;
            SendByUserName = "Timothy Axford";
        }

        //Instance constructor that has three parameters
        public Post(string title, bool isPublic, string sendByUserName)
        {
            this.ID= GetNextID();
            this.Title = title;
            this.SendByUserName= sendByUserName;
            this.IsPublic = isPublic;
        }

        //method
        protected int GetNextID()
        {
            return ++currentPostId;
        }

        //method to update
        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        //virtual method overide
        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUserName);
        }

    }
}
