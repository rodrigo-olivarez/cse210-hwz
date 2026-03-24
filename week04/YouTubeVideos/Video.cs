using System.Collections.Generic;


namespace YouTubeTracker
{
    public class Video
    {
        public string _title;
        public string _author;
        public int _length;
        public List<Comment> _commentList = new List<Comment>();

        public Video(string title, string author, int length)
        {
            _title = title;
            _author = author;
            _length = length;
        }

        public int CommentCount()
        {
            return _commentList.Count;
        }
    }


}