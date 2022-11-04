using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAndObjects
{
    class Post
    {
        private string description;
        private DateTime creationDate;
        private int countLike;
        private string authorName;
        public Post(string description, DateTime creationDate, int countLike, string authorName)
        {
            if (description == "" || description == null)
            {
                description = "no description";
            }
            else
            {
                this.description = description;
            }
            this.creationDate = creationDate;
            if (countLike < 0)
            {
                countLike = 0;
            }
            else
            {
                this.countLike = countLike;
            }
            if (authorName == "" || authorName == null)
            {
                authorName = "no name";
            }
            else
            {
                this.authorName = authorName;
            }
        }
        public Post()
        {

        }
        public string GetInfo()
        {
            string printPost = ($"definition: {description}\n date: {creationDate} \n like: {countLike} \n name: {authorName}");
            return printPost;
        }
        public string GetDescription()
        {
            return description;
        }
        public DateTime GetCreationDate()
        {
            return creationDate;
        }
        public int GetCountLike()
        {
            return countLike;
        }
        public string GetAuthorName()
        {
            return authorName;
        }
        public void SetDescription(string description)
        {
            if (description == "" || description == null)
            {
                return;
            }
            this.description = description;
        }
        public void SetCreationDate(DateTime creationDate)
        {
            this.creationDate = DateTime.Now;
        }
        public void SetCountLike(int countLike)
        {
            if (countLike < 0 )
            {
                return;
            }
            this.countLike = countLike;
        }
        public void SetAuthorName(string authorName)
        {
            if (authorName == "" || authorName == null)
            {
                return;
            }
            this.authorName = authorName;
        }
    }
}
