using System;

namespace Store
{
    public class Proj
    {
        public int Id { get; }

        public string Title { get; }

        public Proj(int id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}
