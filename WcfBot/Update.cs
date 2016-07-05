using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfBot
{
    public class From
    {
        public long id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string username { get; set; }
    }

    public class Chat
    {
        public long id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string username { get; set; }
    }

    public class ForwardFrom
    {
        public long id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string username { get; set; }
    }

    public class Audio
    {
        public string file_id { get; set; }
        public long duration { get; set; }
        public string performer { get; set; }
        public string title { get; set; }
        public string mime_type { get; set; }
        public long file_size { get; set; }
    }

    public class Thumb
    {
        public string file_id { get; set; }
        public long width { get; set; }
        public long height { get; set; }
        public long file_size { get; set; }
    }

    public class Document
    {
        public string file_id { get; set; }
        public Thumb thumb { get; set; }
        public string file_name { get; set; }
        public string mime_type { get; set; }
        public long file_size { get; set; }
    }

    public class Photo
    {
        public string file_id { get; set; }
        public long width { get; set; }
        public long height { get; set; }
        public long file_size { get; set; }
    }

    public class Sticker
    {
        public string file_id { get; set; }
        public string width { get; set; }
        public string height { get; set; }
        public Thumb thumb { get; set; }
        public long file_size { get; set; }
    }

    public class Video
    {
        public string file_id { get; set; }
        public long width { get; set; }
        public long height { get; set; }
        public long duration { get; set; }
        public Thumb thumb { get; set; }
        public string mime_type { get; set; }
        public long file_size { get; set; }
    }

    public class Voice
    {
        public string file_id { get; set; }
        public long duration { get; set; }
        public string mime_type { get; set; }
        public long file_size { get; set; }
    }

    public class Contact
    {
        public string phone_number { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public long user_id { get; set; }
    }

    public class Location
    {
        public double longitude { get; set; }
        public double latitude { get; set; }
    }

    public class NewChatParticipant
    {
        public long id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string username { get; set; }
    }

    public class LeftChatParticipant
    {
        public long id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string username { get; set; }
    }

    public class NewChatPhoto
    {
        public string file_id { get; set; }
        public long width { get; set; }
        public long height { get; set; }
        public long file_size { get; set; }
    }

    public class ReplyToMessage
    {
        public long message_id { get; set; }
        public From from { get; set; }
        public long date { get; set; }
        public Chat chat { get; set; }
        public ForwardFrom forward_from { get; set; }
        public long forward_date { get; set; }
        public object reply_to_message { get; set; }
        public string text { get; set; }
        public Audio audio { get; set; }
        public Document document { get; set; }
        public IList<Photo> photo { get; set; }
        public Sticker sticker { get; set; }
        public Video video { get; set; }
        public Voice voice { get; set; }
        public string caption { get; set; }
        public Contact contact { get; set; }
        public Location location { get; set; }
        public NewChatParticipant new_chat_participant { get; set; }
        public LeftChatParticipant left_chat_participant { get; set; }
        public string new_chat_title { get; set; }
        public IList<NewChatPhoto> new_chat_photo { get; set; }
        public bool delete_chat_photo { get; set; }
        public bool group_chat_created { get; set; }
    }

    public class Message
    {
        public long message_id { get; set; }
        public From from { get; set; }
        public long date { get; set; }
        public Chat chat { get; set; }
        public ForwardFrom forward_from { get; set; }
        public long forward_date { get; set; }
        public ReplyToMessage reply_to_message { get; set; }
        public string text { get; set; }
        public Audio audio { get; set; }
        public Document document { get; set; }
        public IList<Photo> photo { get; set; }
        public Sticker sticker { get; set; }
        public Video video { get; set; }
        public Voice voice { get; set; }
        public string caption { get; set; }
        public Contact contact { get; set; }
        public Location location { get; set; }
        public NewChatParticipant new_chat_participant { get; set; }
        public LeftChatParticipant left_chat_participant { get; set; }
        public string new_chat_title { get; set; }
        public IList<NewChatPhoto> new_chat_photo { get; set; }
        public bool delete_chat_photo { get; set; }
        public bool group_chat_created { get; set; }
    }

    public class Update
    {
        public long update_id { get; set; }
        public Message message { get; set; }
    }
}