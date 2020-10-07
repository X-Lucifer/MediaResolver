namespace X.MediaResolver.Models
{
    public class Douyin
    {
        public class DouyinResult
        {
            public int status_code { get; set; }
            public Item_List[] item_list { get; set; }
            public int ab_type { get; set; }
            public Extra extra { get; set; }
        }

        public class Extra
        {
            public long now { get; set; }
            public string logid { get; set; }
        }

        public class Item_List
        {
            public Statistics statistics { get; set; }
            public Text_Extra[] text_extra { get; set; }
            public string video_labels { get; set; }
            public bool is_live_replay { get; set; }
            public string aweme_id { get; set; }
            public string image_infos { get; set; }
            public Risk_Infos risk_infos { get; set; }
            public string video_text { get; set; }
            public int duration { get; set; }
            public int aweme_type { get; set; }
            public string label_top_text { get; set; }
            public string forward_id { get; set; }
            public string desc { get; set; }
            public Video video { get; set; }
            public long group_id { get; set; }
            public string promotions { get; set; }
            public Author author { get; set; }
            public string comment_list { get; set; }
            public string geofencing { get; set; }
            public Music music { get; set; }
            public Share_Info share_info { get; set; }
            public string long_video { get; set; }
            public int category { get; set; }
            public int is_preview { get; set; }
            public int create_time { get; set; }
            public Cha_List[] cha_list { get; set; }
            public string share_url { get; set; }
            public long author_user_id { get; set; }
        }

        public class Statistics
        {
            public string aweme_id { get; set; }
            public int comment_count { get; set; }
            public int digg_count { get; set; }
            public int play_count { get; set; }
        }

        public class Risk_Infos
        {
            public bool warn { get; set; }
            public int type { get; set; }
            public string content { get; set; }
        }

        public class Video
        {
            public int is_long_video { get; set; }
            public Play_Addr play_addr { get; set; }
            public Cover cover { get; set; }
            public int height { get; set; }
            public Dynamic_Cover dynamic_cover { get; set; }
            public Origin_Cover origin_cover { get; set; }
            public int duration { get; set; }
            public int width { get; set; }
            public string ratio { get; set; }
            public bool has_watermark { get; set; }
            public string bit_rate { get; set; }
            public string vid { get; set; }
        }

        public class Play_Addr
        {
            public string uri { get; set; }
            public string[] url_list { get; set; }
        }

        public class Cover
        {
            public string uri { get; set; }
            public string[] url_list { get; set; }
        }

        public class Dynamic_Cover
        {
            public string uri { get; set; }
            public string[] url_list { get; set; }
        }

        public class Origin_Cover
        {
            public string uri { get; set; }
            public string[] url_list { get; set; }
        }

        public class Author
        {
            public string uid { get; set; }
            public Avatar_Larger avatar_larger { get; set; }
            public Avatar_Thumb avatar_thumb { get; set; }
            public Avatar_Medium avatar_medium { get; set; }
            public string unique_id { get; set; }
            public string policy_version { get; set; }
            public string short_id { get; set; }
            public string nickname { get; set; }
            public string signature { get; set; }
            public string followers_detail { get; set; }
            public string platform_sync_info { get; set; }
            public string geofencing { get; set; }
            public string type_label { get; set; }
        }

        public class Avatar_Larger
        {
            public string uri { get; set; }
            public string[] url_list { get; set; }
        }

        public class Avatar_Thumb
        {
            public string uri { get; set; }
            public string[] url_list { get; set; }
        }

        public class Avatar_Medium
        {
            public string uri { get; set; }
            public string[] url_list { get; set; }
        }

        public class Music
        {
            public long id { get; set; }
            public string mid { get; set; }
            public Cover_Large cover_large { get; set; }
            public Cover_Thumb cover_thumb { get; set; }
            public string position { get; set; }
            public int duration { get; set; }
            public int status { get; set; }
            public string title { get; set; }
            public string author { get; set; }
            public Cover_Hd cover_hd { get; set; }
            public Cover_Medium cover_medium { get; set; }
            public Play_Url play_url { get; set; }
        }

        public class Cover_Large
        {
            public string uri { get; set; }
            public string[] url_list { get; set; }
        }

        public class Cover_Thumb
        {
            public string uri { get; set; }
            public string[] url_list { get; set; }
        }

        public class Cover_Hd
        {
            public string[] url_list { get; set; }
            public string uri { get; set; }
        }

        public class Cover_Medium
        {
            public string uri { get; set; }
            public string[] url_list { get; set; }
        }

        public class Play_Url
        {
            public string uri { get; set; }
            public string[] url_list { get; set; }
        }

        public class Share_Info
        {
            public string share_weibo_desc { get; set; }
            public string share_desc { get; set; }
            public string share_title { get; set; }
        }

        public class Text_Extra
        {
            public int start { get; set; }
            public int end { get; set; }
            public int type { get; set; }
            public string hashtag_name { get; set; }
            public long hashtag_id { get; set; }
            public string user_id { get; set; }
        }

        public class Cha_List
        {
            public string cid { get; set; }
            public string desc { get; set; }
            public int type { get; set; }
            public string hash_tag_profile { get; set; }
            public bool is_commerce { get; set; }
            public string cha_name { get; set; }
            public int user_count { get; set; }
            public string connect_music { get; set; }
            public int view_count { get; set; }
        }
    }
}