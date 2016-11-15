using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali_ItemDescriptor
{
  public static class CItemDescriptionGenerator
  {
    public static List<string> GetDescription(CItemCard Item)
    {
      List<string> res = new List<string>();
      Random R = new Random();
      int N = R.Next(2, 10);
      for (int i = 0; i < N; i++)
        res.Add(" Description " + i.ToString());

      return res;
    }

  }
}
