using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali_ItemDescriptor
{
  public static class CItemGenerator
  {


    /// <summary>
    /// Возвращает лист с карточкой свойств товара.
    /// </summary>
    /// <param name="Item">Карточка товара</param>
    /// <returns>Список строк - свойство : значение </returns>
    public static List<string> GetItemStats(CItemCard Item)
    {
      List<string> res = new List<string>();
      Random R = new Random();
      int N = R.Next(2, 5);
      for (int i = 0; i < N; i++)
        res.Add(" string " + i.ToString());

      return res;
    }

    /// <summary>
    /// Сгенерировать новую карточку товара
    /// </summary>
    /// <returns></returns>
    public static CItemCard GenerateStats()
    {
      return new CItemCard();
    }


    /// <summary>
    /// Возвращает одну и ту же карточку для тестов языкового модуля.
    /// Это телефон  SAMSUNG Galaxy J3 (2016) SM-J320F золотистый 
    /// http://www.citilink.ru/catalog/mobile/cell_phones/359915/
    /// </summary>
    /// <returns>Шаблонная карточка</returns>
    public static CItemCard GetDefaultStats()
    {
      return new CItemCard();
    }
  }
}
