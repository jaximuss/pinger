using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround
{
    public class PostModels
    {
        public string Title;

        public string Body;

        public int Userid;

        public PostModels(string title, string body , int userid)
        {
            this.Title = title;
            this.Body = body;
            this.Userid = userid;
        }
    }
}
