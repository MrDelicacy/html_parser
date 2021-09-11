namespace Parser_1.Core.Functionality
{
    class FunctionalitySettings : IParserSettings
    {
        public FunctionalitySettings(string url)
        {
            BaseUrl = url;
        }

        public string BaseUrl { get; set; };
        //public string Prefix { get; set; } = "page{CurrentId}";
        //public int StartPoint { get; set; }
        //public int EndPoint { get; set; }
    }
}
