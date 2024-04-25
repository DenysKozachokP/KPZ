using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask3_4
{
    public class LightImageNode : LightNode
    {
        public string Src { get; set; }
        public string Alt { get; set; }

        public override string OuterHtml
        {
            get
            {
                return $"<img src=\"{Src}\" alt=\"{Alt}\" />";
            }
        }

        public override string InnerHtml
        {
            get { return ""; }
        }

        public LightImageNode(string src, string alt)
        {
            Src = src;
            Alt = alt;
        }

        public void LoadImage()
        {
            try
            {
                if (Uri.IsWellFormedUriString(Src, UriKind.Absolute))
                {
                    using (var webClient = new WebClient())
                    {
                        webClient.DownloadFile(Src, Path.GetFileName(Src));
                    }
                }
                else
                {
                    File.Copy(Src, Path.GetFileName(Src), true);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading image: {ex.Message}");
            }
        }
    }
}
