﻿
using AngleSharp.Html.Parser;
using System;
using System.Collections.Generic;

namespace TestProject.Core
{
    class ParserWorker<T> where T : class
    {
        IParser<T> parser;
        IParserSettings parserSettings;
        HtmlLoader loader;
        bool isActive;
        #region Properties
        public event Action<object, T> OnNewData;
        public event Action<object> OnComleted;
        public IParser<T> Parser
        {
            get
            {
                return parser;
            }
            set
            {
                parser = value;
            }
        }

        public IParserSettings Settings
        {
            get
            {
                return parserSettings;
            }
            set
            {
                parserSettings = value;
                loader = new HtmlLoader(value);
            }
        }

        public bool IsActive
        {
            get
            {
                return isActive;
            }
        }
        #endregion
        public ParserWorker(IParser<T> parser)
        {
            this.parser = parser;

        }

        public ParserWorker(IParser<T> parser, IParserSettings parserSettings) : this(parser)
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
            for(int i = parserSettings.StartPoint; i <= parserSettings.EndPoint; i++)
            {

                if (!isActive)
                {
                    OnComleted?.Invoke(this);
                    return;
                }
                HabrParserForm.idPage = i.ToString();
            
                
                var source = await loader.GetSoutseByPageId(i);
                var domParser = new HtmlParser();

                var document = await domParser.ParseDocumentAsync(source);

                var result = parser.Parse(document);

                OnNewData?.Invoke(this, result);
            }
            OnComleted?.Invoke(this);
            isActive = false;
        }
             
    }
}
