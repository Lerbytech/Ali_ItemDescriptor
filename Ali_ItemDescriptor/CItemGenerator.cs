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

      if (!String.IsNullOrEmpty(Item.Manufacturer)) res.Add("Производитель: " + Item.Manufacturer);
      if (!String.IsNullOrEmpty(Item.Model)) res.Add("Модель: " + Item.Model);
      if (!String.IsNullOrEmpty(Item.BodyType)) res.Add("Тип корпуса: " + Item.BodyType);
      if (!String.IsNullOrEmpty(Item.OS)) res.Add("Операционная система: " + Item.OS);
      if (Item.SimCard_N != 0) res.Add("Кол-во сим-карт: " + Item.SimCard_N.ToString());
      if (!String.IsNullOrEmpty(Item.SimCard_Type)) res.Add("Тип сим-карт: " + Item.SimCard_Type);
      if (!String.IsNullOrEmpty(Item.SimCards_WorkMode)) res.Add("Режим работы двух сим-карт: " + Item.SimCards_WorkMode);
      if (!Item.is3G) res.Add("3G: поддерживает");
      if (!Item.is4G) res.Add("4G(LTE): поддерживает");
      if (!Item.isGSM850) res.Add("GSM 850: поддерживает");
      if (!Item.isGSM900_1800) res.Add("GSM 900/1800: поддерживает");
      if (!Item.isGSM1900) res.Add("GSM 1900: поддерживает");
      if (Item.SARcoeff != 0) res.Add("Коэффициент SAR: " + Item.SARcoeff.ToString());

      //Дисплей
      if (Item.displayDiag != 0) res.Add("Диагональ дисплея: " + Item.displayDiag.ToString() + " дюймов" );
      if (!String.IsNullOrEmpty(Item.DisplayType)) res.Add("Тип матрицы: " + Item.DisplayType);
      if (Item.DisplayDimensions[0] != 0) res.Add("Разрешение дисплея: " + Item.DisplayDimensions[0].ToString() +"*" + Item.DisplayDimensions[1].ToString());
      if (!Item.isMultitouch) res.Add("Multitouch: есть");
      if (!Item.isDefenseLayer) res.Add("защитное стекло: есть");
      if (Item.NumOfColors != 0) res.Add("Цветов: " + Item.NumOfColors.ToString());
      if (Item.displayPPI != 0) res.Add("PPI: " + Item.displayPPI.ToString());

      //Конфигурация
      if (!String.IsNullOrEmpty(Item.CPU_Manufacturer)) res.Add("Производитель процессора: " + Item.CPU_Manufacturer);
      if (!String.IsNullOrEmpty(Item.CPU_Model)) res.Add("Модель: " + Item.CPU_Model);
      if (Item.CPU_MHz != 0) res.Add("Тактовая частота: " + Item.CPU_MHz.ToString());
      if (Item.CPU_CoreN != 0) res.Add("Кол-во ядер: " + Item.CPU_CoreN.ToString());
      if (!String.IsNullOrEmpty(Item.GPU_Accelerator)) res.Add("Графический ускоритель: " + Item.GPU_Accelerator);
      if (Item.RAM != 0) res.Add("Объем оперативной памяти: " + Item.RAM.ToString());
      if (Item.ROM != 0) res.Add("Объем встроенной памяти: " + Item.ROM.ToString());
      if (!Item.isExternalMemoryCards) res.Add("Поддержка внешних SD карт: есть");
      if (!String.IsNullOrEmpty(Item.ExternalMemoryCardsTypes)) res.Add("Поддерживаемы типы карт памяти: " + Item.ExternalMemoryCardsTypes);
      if (Item.MaxExternalMemoryCardSize != 0) res.Add("Максимальный объем памяти поддерживаемых карт:" + Item.MaxExternalMemoryCardSize.ToString());

      //Камера
      if (!Item.isBackCamera) res.Add("Задняя камера: есть");
      if (!Item.isFrontalCamera) res.Add("Фронтальная камера: есть");

      if (Item.BackCameraMP != 0) res.Add("Задняя камера: " + Item.BackCameraMP.ToString() + "MP");
      if (!Item.isBackCameraFlash) res.Add("Вспышка для задней камеры: есть");
      if (!String.IsNullOrEmpty(Item.BackCameraFlashType)) res.Add("Тип вспышки задней камеры: " + Item.BackCameraFlashType);
      if (Item.BackCameraDimension[0] != 0) res.Add("Разрешение задней камеры: " + Item.BackCameraDimension[0].ToString() + "*" + Item.BackCameraDimension[1].ToString());
      if (Item.BackCameraOpticalZoom != 0) res.Add("Оптический зум задней камеры: х" + Item.BackCameraOpticalZoom.ToString());
      if (Item.BackCameraDigitalZoom != 0) res.Add("Цифровой зум задней камеры: х" + Item.BackCameraDigitalZoom.ToString());
      if (!String.IsNullOrEmpty(Item.BackCameraDiafragme)) res.Add("Диафрагма задней камеры: " + Item.BackCameraDiafragme);
      if (!Item.isBackCameraAutoFocus) res.Add("Автофокус задней камеры: есть");
      if (!String.IsNullOrEmpty(Item.BackCameraHDMode)) res.Add("Разрешение задней камеры: " + Item.BackCameraHDMode); //720p or 1080p
      if (!String.IsNullOrEmpty(Item.BackCameraVideoModes)) res.Add("Режимы работы задней камеры: " + Item.BackCameraVideoModes);

      if (Item.FrontalCameraMP != 0) res.Add("Фронтальная камера: " + Item.FrontalCameraMP.ToString() + "МР");
      if (!Item.isFrontalCameraFlash) res.Add("Вспышка фронтальной камеры: есть");
      if (!String.IsNullOrEmpty(Item.FrontalCameraFlashType)) res.Add("Тип вспышки фронтальной камеры: " + Item.FrontalCameraFlashType);
      if (Item.FrontalCameraDimension[0] != 0) res.Add( "Разрешение фронтальной камеры: " + Item.DisplayDimensions[0].ToString() + "*" + Item.DisplayDimensions[1].ToString());
      if (Item.FrontalCameraOpticalZoom != 0) res.Add("Оптический зум фронтальной камеры: х" + Item.FrontalCameraOpticalZoom.ToString());
      if (Item.FrontalCameraDigitalZoom != 0) res.Add("Цифровой зум фронтальной камеры: х" + Item.FrontalCameraDigitalZoom.ToString());
      if (!String.IsNullOrEmpty(Item.FrontalCameraDiafragme)) res.Add("Диафрагма фронтальной камеры: " + Item.FrontalCameraDiafragme );
      if (!Item.isFrontalCameraAutoFocus) res.Add("Автофокус фронтальной камеры: есть");
      if (!String.IsNullOrEmpty(Item.FrontalCameraHDMode)) res.Add("Разрешение фронтальной камеры: " + Item.FrontalCameraHDMode ); //720p or 1080p
      if (!String.IsNullOrEmpty(Item.FrontalCameraVideoModes)) res.Add("Режимы работы фронтальной камеры: " + Item.FrontalCameraVideoModes );

      //Мультимедиа
      if (!Item.isMP3Player) res.Add("MP3 плеер: есть");
      if (!Item.isMP3asMelody) res.Add("МР3 мелодии на звонок: поддерживает");
      if (!Item.isFMRadio) res.Add("FM-тюнер: есть");
      if (!String.IsNullOrEmpty(Item.SupportedAudioFormats)) res.Add("Поддерживаемые аудио-форматы: " + Item.SupportedAudioFormats);
      if (!String.IsNullOrEmpty(Item.SupportedVideoFormats)) res.Add("Поддерживаемы форматы видео:" + Item.SupportedVideoFormats);
      if (!Item.is3_5Jack) res.Add("Аудио разъем: 3.5мм");
      if (!Item.isMicroUSB) res.Add("Micro-USB: есть");
      if (!Item.isDictophone) res.Add("Диктофон: есть");

      //Коммуникации
      if (!Item.isWIFI) res.Add("Wi-Fi: поддерживает");
      if (!String.IsNullOrEmpty(Item.SupportedWIFIModes)) res.Add("Режимы Wi-Fi: " + Item.SupportedWIFIModes);
      if (!Item.isBluetooth) res.Add("Bluetooth: поддерживает");
      if (!String.IsNullOrEmpty(Item.SupportedBluetoothModes)) res.Add("Версии Bluetooth: " + Item.SupportedBluetoothModes);
      if (!Item.isAGPS) res.Add("A-GPS: поддерживает");
      if (!Item.isGPS) res.Add("GPS: поддерживает");
      if (!Item.isGlonass) res.Add("Глонасс: поддерживает");
      if (!Item.isA2DP) res.Add("A2DP: поддерживает");

      //Особенности
      if (!Item.isGSensor) res.Add("G-сенсор: есть");
      if (!Item.isLightSensor) res.Add("Сенсор освещенности: есть");
      if (!Item.isDactiloscopy) res.Add("Распознавание отпечатка пальца: есть");
      if (!Item.isProximitySensor) res.Add("Датчик приближения: есть"); //датчик приближения
      if (!Item.isAccelerometer) res.Add("Акселлерометр: есть");
      if (!String.IsNullOrEmpty(Item.Additional)) res.Add("Дополнительные особенности: " + Item.Additional);
      if (!Item.isLighter) res.Add("Фонарик: есть");

      //Питание
      if (!String.IsNullOrEmpty(Item.BatteryType)) res.Add("Тип батареи: " + Item.BatteryType);
      if (Item.BatteryCapacity != 0) res.Add("Емкость батареи: " + Item.BatteryCapacity.ToString() + "MAH");
      if (Item.HoursWhileTalking != 0) res.Add("Часов во время разговора: " + Item.HoursWhileTalking.ToString());
      if (Item.HoursWhileWaiting != 0) res.Add("Часов в режиме ожидания: " + Item.HoursWhileWaiting.ToString());
      if (Item.HoursWhilePlayingVideo != 0) res.Add("Часов проигрывания видео: " + Item.HoursWhilePlayingVideo.ToString());
      if (Item.HoursWhilePlayingAudio != 0) res.Add("Часов проигрывания музыки: " + Item.HoursWhilePlayingAudio.ToString());

      //Корпус
      if (!String.IsNullOrEmpty(Item.BodyMaterial)) res.Add("Материал корпуса: " + Item.BodyMaterial );
      if (!String.IsNullOrEmpty(Item.Color)) res.Add("Цвет: " + Item.Color );
      if (Item.Sizes[0] != 0) res.Add("Размеры: " + Item.Sizes[0].ToString() + "*"+ Item.Sizes[1].ToString() + "*" + Item.Sizes[2].ToString());
      if (Item.Weight != 0) res.Add("Вес: " + Item.Weight.ToString() + "грамм");

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

      Item.Manufacturer = "SAMSUNG";
      Item.Model = "Galaxy J3";
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

      return Item;
    }
  }
}
