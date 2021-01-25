using System;
using System.Data.Entity;

namespace citb517_2.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime DateAdded { get; set; }

    }

    public class CommentContext : DbContext
    {
        public CommentContext() : base("Comment") { }

        public DbSet<Comment> Comments { get; set; }
    }
}