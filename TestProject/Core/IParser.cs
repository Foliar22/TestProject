﻿using AngleSharp.Html.Dom;


namespace TestProject.Core
{
    interface IParser<T> where T : class
    {
        T Parse(IHtmlDocument document);
    }
}
