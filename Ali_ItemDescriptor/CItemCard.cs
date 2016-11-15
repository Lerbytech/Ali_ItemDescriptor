using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ali_ItemDescriptor
{
  public class CItemCard
  {
    //  Общие характеристики
    public string Manufacturer;
    public string Model;
    public string BodyType;
    public string OS;
    public int SimCard_N;
    public string SimCard_Type;
    public string SimCards_WorkMode;
    public bool is3G;
    public bool is4G;
    public bool isGSM850;
    public bool isGSM900_1800;
    public bool isGSM1900;
    public float SARcoeff;

    //Дисплей
    public float displayDiag;
    public string DisplayType;
    public int[] DisplayDimensions;
    public bool isMultitouch;
    public bool isDefenseLayer;
    public int NumOfColors;
    public int displayPPI;

    //Конфигурация
    public string CPU_Manufacturer;
    public string CPU_Model;
    public int CPU_MHz;
    public int CPU_CoreN;
    public string GPU_Accelerator;
    public int RAM;
    public int ROM;
    public bool isExternalMemoryCards;
    public string ExternalMemoryCardsTypes;
    public int MaxExternalMemoryCardSize;

    //Камера
    public bool isBackCamera;
    public bool isFrontalCamera;

    public float BackCameraMP;
    public bool isBackCameraFlash;
    public string BackCameraFlashType;
    public int[] BackCameraDimension;
    public int BackCameraOpticalZoom;
    public int BackCameraDigitalZoom;
    public string BackCameraDiafragme;
    public bool isBackCameraAutoFocus;
    public string BackCameraHDMode; //720p or 1080p
    public string BackCameraVideoModes;

    public float FrontalCameraMP;
    public bool isFrontalCameraFlash;
    public string FrontalCameraFlashType;
    public int[] FrontalCameraDimension;
    public int FrontalCameraOpticalZoom;
    public int FrontalCameraDigitalZoom;
    public string FrontalCameraDiafragme;
    public bool isFrontalCameraAutoFocus;
    public string FrontalCameraHDMode; //720p or 1080p
    public string FrontalCameraVideoModes;

    //Мультимедиа
    public bool isMP3Player;
    public bool isMP3asMelody;
    public bool isFMRadio;
    public string SupportedAudioFormats;
    public string SupportedVideoFormats;
    public bool is3_5Jack;
    public bool isMicroUSB;
    public bool isDictophone;

    //Коммуникации
    public bool isWIFI;
    public string SupportedWIFIModes;
    public bool isBluetooth;
    public string SupportedBluetoothModes;
    public bool isAGPS;
    public bool isGPS;
    public bool isGlonass;
    public bool isA2DP;

    //Особенности
    public bool isGSensor;
    public bool isLightSensor;
    public bool isDactiloscopy;
    public bool isProximitySensor; //датчик приближения
    public bool isAccelerometer;
    public string Additional;
    public bool isLighter;

    //Питание
    public string BatteryType;
    public int BatteryCapacity;
    public int HoursWhileTalking;
    public int HoursWhileWaiting;
    public int HoursWhilePlayingVideo;
    public int HoursWhilePlayingAudio;

    //Корпус
    public string BodyMaterial;
    public string Color;
    public float[] Sizes;
    public int Weight;

    public CItemCard()
    {
      Manufacturer = String.Empty;
      Model = String.Empty;
      BodyType = String.Empty;
      OS = String.Empty;
      SimCard_N = 0;
      SimCard_Type = String.Empty;
      SimCards_WorkMode = String.Empty;
      is3G = false;
      is4G = false;
      isGSM850 = false;
      isGSM900_1800 = false;
      isGSM1900 = false;
      SARcoeff = 0;

    //Дисплей
      displayDiag = 0;
      DisplayType = String.Empty;
      DisplayDimensions = new int[2];
      isMultitouch = false;
      isDefenseLayer = false;
      NumOfColors = 0;
      displayPPI = 0;

    //Конфигурация
      CPU_Manufacturer = String.Empty;
      CPU_Model = String.Empty;
      CPU_MHz = 0;
      CPU_CoreN = 0;
      GPU_Accelerator = String.Empty;
      RAM = 0;
      ROM = 0;
      isExternalMemoryCards = false;
      ExternalMemoryCardsTypes = String.Empty;
      MaxExternalMemoryCardSize = 0;

    //Камера
      isBackCamera = false;
      isFrontalCamera = false;

      BackCameraMP = 0;
      isBackCameraFlash = false;
      BackCameraFlashType = String.Empty;
      BackCameraDimension = new int[2];
      BackCameraOpticalZoom = 0;
      BackCameraDigitalZoom = 0;
      BackCameraDiafragme = String.Empty;
      isBackCameraAutoFocus = false;
      BackCameraHDMode = String.Empty; //720p or 1080p
      BackCameraVideoModes = String.Empty;

      FrontalCameraMP = 0;
      isFrontalCameraFlash = false;
      FrontalCameraFlashType = String.Empty;
      FrontalCameraDimension = new int[2];
      FrontalCameraOpticalZoom = 0;
      FrontalCameraDigitalZoom = 0;
      FrontalCameraDiafragme = String.Empty;
      isFrontalCameraAutoFocus = false;
      FrontalCameraHDMode = String.Empty; //720p or 1080p
      FrontalCameraVideoModes = String.Empty;

    //Мультимедиа
      isMP3Player = false;
      isMP3asMelody = false;
      isFMRadio = false;
      SupportedAudioFormats = String.Empty;
      SupportedVideoFormats = String.Empty;
      is3_5Jack = false;
      isMicroUSB = false;
      isDictophone = false;

    //Коммуникации
      isWIFI = false;
      SupportedWIFIModes = String.Empty;
      isBluetooth = false;
      SupportedBluetoothModes = String.Empty;
      isAGPS = false;
      isGPS = false;
      isGlonass = false;
      isA2DP = false;

    //Особенности
      isGSensor = false;
      isLightSensor = false;
      isDactiloscopy = false;
      isProximitySensor = false; //датчик приближения
      isAccelerometer = false;
      Additional = String.Empty;
      isLighter = false;

    //Питание
      BatteryType = String.Empty;
      BatteryCapacity = 0;
      HoursWhileTalking = 0;
      HoursWhileWaiting = 0;
      HoursWhilePlayingVideo = 0;
      HoursWhilePlayingAudio = 0;

    //Корпус
      BodyMaterial = String.Empty;
      Color = String.Empty;
      Sizes = new float[3];
      Weight = 0;
    }
  }
}
