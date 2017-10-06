using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LockedVehicles.Processing
{
  [JsonConverter(typeof(StringEnumConverter))]

  public enum VehicleField
  {
    None = 0,
    BodyStyle,
    Carfax1Owner,
    ChromeIncentives,
    ChromeOptionCodes,
    ChromeStockPhotos,
    ChromeStyleId,
    Comments,
    ComponentFeeds,
    Cpo,
    Display,
    DriveTrainType,
    Engine,
    EngineCylinders,
    EngineDisp,
    ExteriorColor,
    ExteriorColorCode,
    ExteriorColorGeneric,
    ExteriorColorHexCode,
    Features,
    FeedSpecial,
    FuelType,
    InteriorColor,
    InteriorColorCode,
    InteriorColorGeneric,
    InteriorColorHexCode,
    InTransit,
    IsHybrid,
    JatoFirstPhoto,
    JatoStockPhotos,
    JatoVehicleId,
    Make,
    Mileage,
    Model,
    ModelCode,
    MpgCity,
    MpgHwy,
    OemFileStatus,
    Options,
    Packages,
    PhotoCount,
    Photos,
    Prices,
    Rebates,
    StandardEquipment,
    StockNum,
    StockPhotoCount,
    StockPhotos,
    Tags,
    TechSpecs,
    Transmission,
    Trim,
    Type,
    Upholstery,
    VideoFeedUrl,
    Warranty,
    WhenFirstImported,
    WhenInStock,
    WhenPhotosUpdated,
    WhenUpdated,
    Year,
    [Obsolete]
    DaysInInventory,
    [Obsolete]
    InternetPrice,
    [Obsolete]
    Msrp,
    [Obsolete]
    WhenCreated,
    [Obsolete]
    WhenInInventory,
  }
}
