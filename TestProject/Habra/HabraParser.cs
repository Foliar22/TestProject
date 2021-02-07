using AngleSharp.Html.Dom;
using TestProject.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TestProject.Habra
{
    class HabraParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            var listword = new List<string>();
            var listresult = new List<string>();
            foreach(var element in document.QuerySelectorAll("script"))
            {
                element.Remove();
            }
            var items = document.QuerySelectorAll("div").Where(item => item.ClassName != null);
            foreach (var item in items)
            {
                string[] word = item.TextContent.Split(new Char[] { ' ', '"', '<', '>', '\t', '\n', ',', '(', ')', '.', '-', '/', ':', '«', '»', '!', '&', '@', ';', '#', '?', '-', '≥', ' ', '\'', '=' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < word.Length; i++)
                {
                    word[i] = word[i].ToLower();
                }
                listword.AddRange(word);

            }
            items = null;
            GC.Collect();
            var result = listword.GroupBy(x => x).Where(x => x.Count() > 0).Select(x => new { Word = x.Key, Frequency = x.Count() });
            listword = null;
            GC.Collect();
            foreach (var item in result)
            {

                bool isNum = int.TryParse(item.Word, out int num);
                if (!isNum)
                {
                    if (item.Word.Length > 1)
                    {


                        listresult.Add("Слово: " + item.Word + " Количество Повторов: " + item.Frequency);
                    }
                }


            }

            return listresult.ToArray();
            
           
        }
    }
}
