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
    public int SARcoeff;

    //Дисплей
    public int displayDiag;
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

    public bool isBackCameraFlash;
    public string BackCameraFlashType;
    public int[] BackCameraDimension;
    public int BackCameraOpticalZoom;
    public int BackCameraDigitalZoom;
    public string BackCameraDiafragme;
    public bool isBackCameraAutoFocus;
    public string BackCameraHDMode; //720p or 1080p
    public string BackCameraVideoModes;

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
    public string isMiniUSB;
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
    public int HourdsWhileWaiting;
    public int HoursWhilePlayingVideo;
    public int HoursWhilePlayingAudio;

    //Корпус
    public string BodyMaterial;
    public string Color;
    public int[] Sizes;
    public int Weight;

    public CItemCard()
    {

    }





  }
}
