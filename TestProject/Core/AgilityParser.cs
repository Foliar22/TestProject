using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;


namespace TestProject.Core
{
    class AgilityParser
    {
        public string[] AgilityPars (string url)
        {
            var listResult = new List<string>();
            try
            {
                using (HttpClientHandler hdl = new HttpClientHandler { AllowAutoRedirect = false, AutomaticDecompression = System.Net.DecompressionMethods.Deflate | System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.None })
                {
                    using(var clnt = new HttpClient(hdl))
                    {
                        using (HttpResponseMessage resp = clnt.GetAsync(url).Result)
                        {
                            if (resp.IsSuccessStatusCode)
                            {
                                var html = resp.Content.ReadAsStringAsync().Result;
                                if (!string.IsNullOrEmpty(html))
                                {
                                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                                    doc.LoadHtml(html);
                                    var word = doc.DocumentNode.SelectSingleNode(".//div[@class]").InnerText.Trim();
                                    doc = null;
                                    GC.Collect();
                                    string[] words = word.ToString().Split(new Char[] { '\r', ' ', '"', '<', '>', '\t', '\n', ',', '(', ')', '.', '-', '/', ':', '«', '»', '!', '&', '@', ';', '#', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);
                                    for (int i = 0; i < words.Length; i++)
                                    {
                                        words[i] = words[i].ToLower();
                                    }
                                    word = null;
                                    GC.Collect();
                                    var result = words.GroupBy(x => x).Where(x => x.Count() > 0).Select(x => new { Word = x.Key, Frequency = x.Count() });
                                    words = null;
                                    GC.Collect();
                                    foreach (var item in result)
                                    {
                                        if (item.Word.Length > 1)
                                        {
                                            bool isNum = int.TryParse(item.Word, out int num);
                                            if (!isNum)
                                            {

                                                listResult.Add("Слово: " + item.Word + " Количество Повторов: " + item.Frequency);


                                            }
                                        }

                                    }
                                    result = null;
                                    GC.Collect();
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception)
            {
                
            }
            return listResult.ToArray();
        }
    }
}
