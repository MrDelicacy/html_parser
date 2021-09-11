using AngleSharp.Html.Dom;

namespace Parser_1.Core
{
    interface IParser<T> where T:class
    {
        T Parse(IHtmlDocument document);
    }
}
