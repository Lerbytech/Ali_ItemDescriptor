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
      CItemCard Item = new CItemCard();

      Item.BodyType = "смартфон";
      Item.isGSM850 = true;
      Item.isGSM900_1800 = true;
      Item.isGSM1900 = true;
      Item.is3G = true;
      Item.is4G = true;
      Item.SimCard_N = 2;
      Item.SimCard_Type = "микро-SIM";
      Item.OS = "Андроид 5.0";
      Item.SARcoeff = 0.477f;
      Item.displayDiag = 5.0f;
      Item.DisplayType = "Super AMOLED";
      Item.DisplayDimensions[0] = 1280;
      Item.DisplayDimensions[1] = 720;
      Item.displayPPI = 293;
      Item.NumOfColors = 16000000;
      Item.isMultitouch = true;
      Item.CPU_Manufacturer = "Spreadtrum";
      Item.CPU_Model = "SC9830";
      Item.CPU_MHz = 1500;
      Item.CPU_CoreN = 4;
      Item.GPU_Accelerator = "Mali-400 MP2";
      Item.RAM = 1536;
      Item.ROM = 8096;
      Item.MaxExternalMemoryCardSize = 128;
      Item.isExternalMemoryCards = true;
      Item.ExternalMemoryCardsTypes = "microSD";

      Item.isBackCamera = true;
      Item.isBackCameraFlash = true;
      Item.BackCameraFlashType = "светодиодная";
      Item.isFrontalCamera = true;
      Item.FrontalCameraMP = 5;
      Item.BackCameraMP = 8;
      Item.isBackCameraAutoFocus = true;
      Item.BackCameraHDMode = "720p";

      Item.isMP3Player = true;
      Item.isMP3asMelody = true;
      Item.isFMRadio = true;
      Item.isDictophone = true;
      Item.SupportedAudioFormats = "";
      Item.SupportedVideoFormats = "";
      Item.is3_5Jack = true;
      Item.isMicroUSB = true;

      Item.isWIFI = true;
      Item.SupportedWIFIModes = "802.11n";
      Item.isBluetooth = true;
      Item.SupportedBluetoothModes = "4.0";
      Item.isA2DP = true;
      Item.isGPS = true;
      Item.isGlonass = true;

      Item.isGSensor = true;
      Item.isAccelerometer = true;
      Item.isProximitySensor = true;

      Item.HoursWhileTalking = 13;
      Item.BatteryCapacity = 2600;
      Item.HoursWhilePlayingAudio = 39;
      Item.HoursWhilePlayingVideo = 11;

      Item.BodyMaterial = "пластик";
      Item.Color = "золотистый";
      Item.Sizes[0] = 71;
      Item.Sizes[1] = 142.3f;
      Item.Sizes[2] = 7.9f;
      Item.Weight = 138;

      return new CItemCard();
    }
  }
}
