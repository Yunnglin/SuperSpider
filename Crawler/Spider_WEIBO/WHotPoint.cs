namespace Spider_WEIBO
{
    public class WHotPoint
    {
        public int Rank { set; get; }
        public string Url { set; get; }
        public string Title { set; get; }
        public string HotDegree { set; get; }

        public WHotPoint(int rank, string url, string title, string hot)
        {
            Rank = rank;
            Url = url;
            Title = title;
            HotDegree = hot;
        }

        public override string ToString()
        {
            return "排行："+Rank + "   " + "关键词："+Title + '\n'+'\n' + "热度：" + HotDegree + '\n' + '\n' + "详情链接：" + Url+ "\n------------------------\n";
        }
    }
}
