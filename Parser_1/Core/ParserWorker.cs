using System;
using AngleSharp.Html.Parser;

namespace Parser_1.Core
{
    class ParserWorker<T> where T :class
    {
        IParser<T> parser;
        IParserSettings parserSettings;
        HtmlLoader htmlLoader;
        bool isActive;

        #region Properties
        public event Action<object, T> OnNewData;
        public event Action<object> OnCompleted;
        public IParser<T> Parser
        {
            get { return parser; }
            set { parser = value; }
        }



        public IParserSettings ParserSettings
        {
            get { return parserSettings; }
            set 
            { 
                parserSettings = value;
                htmlLoader = new HtmlLoader(value);
            }
        }
        public bool IsActive
        {
            get { return isActive; }

        }
        #endregion

        public ParserWorker(IParser<T> p)
        {
            this.parser = p;
        }
        public ParserWorker(IParser<T> p, IParserSettings parserSettings):this(p)
        {
            this.parserSettings = parserSettings;
        }
        public void Start()
        {
            isActive = true;
            Worker();
        }
        public void Abort()
        {
            isActive = false;
        }
        private async void Worker()
        {
            //for (int i = parserSettings.StartPoint; i <= parserSettings.EndPoint; i++)
            //{
                if (!isActive)
                {
                    OnCompleted?.Invoke(this);
                    return;
                }
                //var source = await htmlLoader.GetSourceByPage(i);
            var source = await htmlLoader.GetSourceByPage();
            var domParser = new HtmlParser();

                var document = await domParser.ParseDocumentAsync(source);
                var result = parser.Parse(document);
                OnNewData?.Invoke(this, result);
            //}
            OnCompleted?.Invoke(this);
            isActive = false;
        }
    }
}
