using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public class author
    {
        public string Name { set; get; }

        public List<string> my_publishers;

        public author(string name)
        {
            Name = name;
            my_publishers = new List<string>();
        }

        public void AddpublisherToMyMap(string a)
        {
            my_publishers.Add(a);
        }

    }
}
