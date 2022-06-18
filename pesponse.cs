using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parser
{
    public class Parser
    {
        public Response response { get; set; }
    }
    public class Response
    {
        public int count { get; set; }
        public Item[] items { get; set; }

    }
    public class Item
    {
        public string id { get; set; }
        public string from_id {get; set; }
        public string owner_id { get; set; }
        public string date { get; set; }
        public int marked_as_ads { get; set; }
        public bool is_favorite { get; set; }
        public string post_type { get; set; }
        public string text { get; set; }
        public Attachments[] attachments { get; set; }
        public Post_source post_source { get; set; }
        public Comments comments { get; set; }
        public Likes likes { get; set; }
        public Reposts reposts { get; set; }
        public Views views { get; set; }
        public Donut donut { get; set; }
        public float short_text_rate { get; set; }
        public int carousel_offset { get; set; }
        public Int32 edited { get; set; }
        public string hash { get; set; }


    }
    public class Attachments
    {

    }
    public class Comments
    {
        public int can_post { get; set; }
        public int count { get; set; }
        public bool groups_can_post { get; set; }
    }
    public class Likes
    {

        public int can_like { get; set; }
        public int count { get; set; }
        public int user_likes { get; set; }
        public int can_publish { get; set; }
    }
    public class Reposts
    {
        public int count { get; set; }
        public int user_reposted { get; set; }
    }
    public class Views
    {
        public int count { get; set; }
    }
    public class Donut
    {
        public bool is_donut { get; set; }
    }
    public class Post_source
    {
        public string type { get; set; }
    }
}
