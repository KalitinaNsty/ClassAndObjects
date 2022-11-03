using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndObjects
{
    class Post
    {
        private string defenition;
        private DateTime date;
        private int like;
        private string name;
        public Post(string defenition, DateTime date, int like, string name)
        {
            if (defenition == "" || defenition == null)
            {
                return;
            }
            else
            {
                this.defenition = defenition;
            }
            this.date = date;
            if (like < 0)
            {
                return;
            }
            else
            {
                this.like = like;
            }
            if (name == "" || name == null)
            {
                return;
            }
            else
            {
                this.name = name;
            }
        }
        public Post()
        {

        }
        public string Print()
        {
            string printPost = ($"definition: {defenition}\n date: {date} \n like: {like} \n name: {name}");
            return printPost;
        }
        public string GetDefenition()
        {
            return defenition;
        }
        public DateTime GetDate()
        {
            return date;
        }
        public int getLike()
        {
            return like;
        }
        public string GetName()
        {
            return name;
        }
        public void setDefenation(string defenition)
        {
            if (defenition == "" || defenition == null)
            {
                return;
            }
            this.defenition = defenition;
        }
        public void setDate(DateTime date)
        {
            this.date = DateTime.Now;
        }
        public void setLike(int like)
        {
            if (like < 0 )
            {
                return;
            }
            this.like = like;
        }
        public void setName(string name)
        {
            if (name == "" || name == null)
            {
                return;
            }
            this.name = name;
        }
    }
}
