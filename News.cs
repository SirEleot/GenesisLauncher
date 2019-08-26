using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static Launcher.Program;

namespace Launcher
{
    class NewsModel
    {
        public string Tittle { get; set; }
        public string Text { get; set; }
    }
     
    class News
    {
        Label_news LNews;

        public News(Form form)
        {
            LNews = new Label_news();
            form.Controls.Add(LNews);
        }
        private List<NewsModel> Update()
        {
            try
            {
                HttpWebRequest proxy_request = (HttpWebRequest)WebRequest.Create(_config.News);
                proxy_request.Method = "GET";
                proxy_request.ContentType = "text/plain";
                proxy_request.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
                
                HttpWebResponse resp = proxy_request.GetResponse() as HttpWebResponse;
                string RemoteString = "";
                using (StreamReader sr = new StreamReader(resp.GetResponseStream(), Encoding.GetEncoding(1251)))
                    RemoteString = sr.ReadToEnd();
                RemoteString = RemoteString.Trim();
               // Logger.LogIt(RemoteString);
                return JsonConvert.DeserializeObject<List<NewsModel>>(RemoteString);
            }
            catch (Exception e)
            {
                Logger.LogIt($"Error http: {e.Message}");
                Logger.LogIt($"Error http: {e.StackTrace}");
                return new List<NewsModel> {
                    new NewsModel { Tittle = "Ошибка!", Text="Сервер новостей недоступен"}
                };
            }
        }

        public void Parse()
        {
            LNews.ListNews = Update();
        }
    }
}
