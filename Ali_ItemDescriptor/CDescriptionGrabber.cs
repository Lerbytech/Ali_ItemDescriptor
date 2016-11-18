using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ali_ItemDescriptor
{
  public class CDescriptionGrabber
  {
    public CDescriptionGrabber()
    {
    }

    public void DoStuff()
    {
      string filepath = @"C:\Users\Admin\Documents\visual studio 2012\Projects\Ali_ItemDescriptor\Ali_ItemDescriptor\Files\Urls.txt";
      string[] urls = File.ReadAllLines(filepath);

      List<string> Descriptions = new List<string>();
      for (int i = 0; i < urls.Length; i++)
        Descriptions.Add(GetTextDescription(urls[i]));



    }

    public string GetTextDescription(string url)
    {
      string raw_page = WebTools.GetPageSourceCode(url);

      string left_detector = @"без предварительного уведомления продавца.</p><!--/noindex--><h3>Описание """;
      int left_index =  raw_page.IndexOf(left_detector) + left_detector.Length;
      string res = raw_page.Substring(left_index);

      left_detector = @"</h3><p>";
      left_index = raw_page.IndexOf(left_detector) + left_detector.Length;
      res = raw_page.Substring(left_index);

      string right_detector = @"</p>";
      int right_index = res.IndexOf(right_detector);

      res = res.Substring(0, right_index);
      res = res.Replace("&nbsp;", " ");
      res = res.Replace("</h3>", " ");
      res = res.Replace("<h3>", " ");
      res = res.Replace("<p>", " ");
      return res;
    }

  }
}
