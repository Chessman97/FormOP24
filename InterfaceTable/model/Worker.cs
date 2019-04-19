using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTable
{
    public class Worker
    {
        private String fullName;
        private String post;

        public Worker(String fullName, String post)
        {
            this.fullName = fullName;
            this.post = post;
        }

        public String FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public String Post
        {
            get { return post; }
            set { post = value; }
        }
    }
}
