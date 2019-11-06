namespace Parser.Core.Findanime
{
    class FindanimeSettings : IParserSettings
    {
        public string BaseURL { get; set; } = "https://findanime.org";

        public string Prefix { get; set; } = "?offset={CurrentId}";

        public int StartPoint { get; set; }

        public int EndPoint { get; set; }

        public FindanimeSettings(int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }
    }
}
