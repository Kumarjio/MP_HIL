﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeoUtility.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("GeoUtility.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 Eine Typ-Konvertierung zwischen {0} und {1} ist nicht erlaubt. 的本地化字符串。
        /// </summary>
        internal static string DE_ERROR_CONVERTFROM {
            get {
                return ResourceManager.GetString("DE_ERROR_CONVERTFROM", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Rechtswert außerhalb des für Deutschland definierten Gauss-Krüger-Systems: 
        ///Geogr. Länge: 5 bis 16 E. 的本地化字符串。
        /// </summary>
        internal static string DE_ERROR_GAUSS_EAST {
            get {
                return ResourceManager.GetString("DE_ERROR_GAUSS_EAST", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Hochwert außerhalb des für Deutschland definierten Gauss-Krüger-Systems: 
        ///Geogr. Breite: 46 bis 55 N. 的本地化字符串。
        /// </summary>
        internal static string DE_ERROR_GAUSS_NORTH {
            get {
                return ResourceManager.GetString("DE_ERROR_GAUSS_NORTH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Breitengrad ungültig. Definierter Bereich: -80 (südl.) bis +84 (nördl.) 的本地化字符串。
        /// </summary>
        internal static string DE_ERROR_GEO_LATITUDE {
            get {
                return ResourceManager.GetString("DE_ERROR_GEO_LATITUDE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Längengrad ungültig. Definierter Bereich: -180 (westl.) bis +180 (östl.) 的本地化字符串。
        /// </summary>
        internal static string DE_ERROR_GEO_LONGITUDE {
            get {
                return ResourceManager.GetString("DE_ERROR_GEO_LONGITUDE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Werte außerhalb des definierten Bereichs im WGS84 Datum: 
        ///Länge: -180 bis +180 E; Breite: -80 bis +84 N. 的本地化字符串。
        /// </summary>
        internal static string DE_ERROR_GEO2UTM {
            get {
                return ResourceManager.GetString("DE_ERROR_GEO2UTM", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Werte außerhalb des für Deutschland definierten Gauss-Krüger-Systems: 
        ///Länge: 5 bis 16 E; Breite: 46 bis 55 N. 的本地化字符串。
        /// </summary>
        internal static string DE_ERROR_GK_OUT_OF_RANGE {
            get {
                return ResourceManager.GetString("DE_ERROR_GK_OUT_OF_RANGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Ungültiger interner Schlüssel für das Satellitenbild. 的本地化字符串。
        /// </summary>
        internal static string DE_ERROR_MAPDIMENSION {
            get {
                return ResourceManager.GetString("DE_ERROR_MAPDIMENSION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Format des MGRS-Koordinatenstrings konnte nicht erkannt werden oder außerhalb des gültigen Bereichs. 的本地化字符串。
        /// </summary>
        internal static string DE_ERROR_MGRS {
            get {
                return ResourceManager.GetString("DE_ERROR_MGRS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 East-Wert ungültig.  的本地化字符串。
        /// </summary>
        internal static string DE_ERROR_MGRS_EAST {
            get {
                return ResourceManager.GetString("DE_ERROR_MGRS_EAST", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Grid-Wert ungültig. Er besteht aus 2 Buchstaben. 的本地化字符串。
        /// </summary>
        internal static string DE_ERROR_MGRS_GRID {
            get {
                return ResourceManager.GetString("DE_ERROR_MGRS_GRID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 North-Wert ungültig. 的本地化字符串。
        /// </summary>
        internal static string DE_ERROR_MGRS_NORTH {
            get {
                return ResourceManager.GetString("DE_ERROR_MGRS_NORTH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Ungültige Werte in dem von MapServiceTileBase abgeleiteten Parameter. 的本地化字符串。
        /// </summary>
        internal static string DE_ERROR_TILE {
            get {
                return ResourceManager.GetString("DE_ERROR_TILE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Band ungültig. Definierter Bereich: C bis X (ohne I und O). 的本地化字符串。
        /// </summary>
        internal static string DE_ERROR_UTM_BAND {
            get {
                return ResourceManager.GetString("DE_ERROR_UTM_BAND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 East-Wert ungültig. Definierter Bereich: ca. 200000 bis 800000 的本地化字符串。
        /// </summary>
        internal static string DE_ERROR_UTM_EAST {
            get {
                return ResourceManager.GetString("DE_ERROR_UTM_EAST", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Nord-Wert ungültig. Def.-Bereich: ca. 0 bis 9300000 (Nord), ca. 1100000 bis 10000000 (Süd) 的本地化字符串。
        /// </summary>
        internal static string DE_ERROR_UTM_NORTH {
            get {
                return ResourceManager.GetString("DE_ERROR_UTM_NORTH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Der UTM-String konnte nicht erkannt werden (Format unbekannt). 的本地化字符串。
        /// </summary>
        internal static string DE_ERROR_UTM_STRING {
            get {
                return ResourceManager.GetString("DE_ERROR_UTM_STRING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0}{1} ist eine ungültige UTM-Zone. 的本地化字符串。
        /// </summary>
        internal static string DE_ERROR_UTM_ZONE {
            get {
                return ResourceManager.GetString("DE_ERROR_UTM_ZONE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Zone ungültig. Definierter Bereich: 1 bis 60. 的本地化字符串。
        /// </summary>
        internal static string DE_ERROR_UTM_ZONE2 {
            get {
                return ResourceManager.GetString("DE_ERROR_UTM_ZONE2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Rechts: {0}; Hoch: {1} 的本地化字符串。
        /// </summary>
        internal static string DE_GAUSS_LONG_STRING {
            get {
                return ResourceManager.GetString("DE_GAUSS_LONG_STRING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 R: {0}   H: {1} 的本地化字符串。
        /// </summary>
        internal static string DE_GAUSS_SHORT_STRING {
            get {
                return ResourceManager.GetString("DE_GAUSS_SHORT_STRING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Länge: {0}; Breite: {1} 的本地化字符串。
        /// </summary>
        internal static string DE_GEOGRAPHIC_STRING {
            get {
                return ResourceManager.GetString("DE_GEOGRAPHIC_STRING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Satellitenbild in dieser Zoomstufe nicht verfügar. 的本地化字符串。
        /// </summary>
        internal static string DE_MS_NO_IMAGE {
            get {
                return ResourceManager.GetString("DE_MS_NO_IMAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Nähere Angaben zum Fehler sind nicht verfügbar. 的本地化字符串。
        /// </summary>
        internal static string DE_NO_ERROR_MESSAGE {
            get {
                return ResourceManager.GetString("DE_NO_ERROR_MESSAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Type conversion between {0} and {1} is not allowed. 的本地化字符串。
        /// </summary>
        internal static string ERROR_CONVERTFROM {
            get {
                return ResourceManager.GetString("ERROR_CONVERTFROM", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 East value out of range for the german Gauss-Krueger-System: 
        ///Longitude: 5 bis 16 E. 的本地化字符串。
        /// </summary>
        internal static string ERROR_GAUSS_EAST {
            get {
                return ResourceManager.GetString("ERROR_GAUSS_EAST", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 North value out of range for the german Gauss-Krueger-System: 
        ///Latitude: 46 to 55 N. 的本地化字符串。
        /// </summary>
        internal static string ERROR_GAUSS_NORTH {
            get {
                return ResourceManager.GetString("ERROR_GAUSS_NORTH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Latitude invalid. Range: -80 (South) to +84 (North) 的本地化字符串。
        /// </summary>
        internal static string ERROR_GEO_LATITUDE {
            get {
                return ResourceManager.GetString("ERROR_GEO_LATITUDE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Longitude invalid. Range: -180 (West) to +180 (East) 的本地化字符串。
        /// </summary>
        internal static string ERROR_GEO_LONGITUDE {
            get {
                return ResourceManager.GetString("ERROR_GEO_LONGITUDE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Values out of range for UTM: 
        ///Longitude: -180 to +180 E; Latitude: -80 to +84 N. 的本地化字符串。
        /// </summary>
        internal static string ERROR_GEO2UTM {
            get {
                return ResourceManager.GetString("ERROR_GEO2UTM", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Values out of range for the german Gauss-Krueger-System: 
        ///Longitude: 5 bis 16 E; Latitude: 46 to 55 N. 的本地化字符串。
        /// </summary>
        internal static string ERROR_GK_OUT_OF_RANGE {
            get {
                return ResourceManager.GetString("ERROR_GK_OUT_OF_RANGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Invalid internal key for the satellite picture. 的本地化字符串。
        /// </summary>
        internal static string ERROR_MAPDIMENSION {
            get {
                return ResourceManager.GetString("ERROR_MAPDIMENSION", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Format of the MGRS string could not be parsed or out of range. 的本地化字符串。
        /// </summary>
        internal static string ERROR_MGRS {
            get {
                return ResourceManager.GetString("ERROR_MGRS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 East value invalid. 的本地化字符串。
        /// </summary>
        internal static string ERROR_MGRS_EAST {
            get {
                return ResourceManager.GetString("ERROR_MGRS_EAST", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Grid value invalid. It needs 2 letters. 的本地化字符串。
        /// </summary>
        internal static string ERROR_MGRS_GRID {
            get {
                return ResourceManager.GetString("ERROR_MGRS_GRID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 North value invalid. 的本地化字符串。
        /// </summary>
        internal static string ERROR_MGRS_NORTH {
            get {
                return ResourceManager.GetString("ERROR_MGRS_NORTH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Your MapServiceTileBase derived object contains invalid values. 的本地化字符串。
        /// </summary>
        internal static string ERROR_TILE {
            get {
                return ResourceManager.GetString("ERROR_TILE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Band invalid. Range: C to X (without I and O). 的本地化字符串。
        /// </summary>
        internal static string ERROR_UTM_BAND {
            get {
                return ResourceManager.GetString("ERROR_UTM_BAND", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 East value invalid. Range: approx. 200000 to 800000 的本地化字符串。
        /// </summary>
        internal static string ERROR_UTM_EAST {
            get {
                return ResourceManager.GetString("ERROR_UTM_EAST", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 North value invalid. Range: approx. 0 to 9300000 (North), approx. 1100000 to 10000000 (South) 的本地化字符串。
        /// </summary>
        internal static string ERROR_UTM_NORTH {
            get {
                return ResourceManager.GetString("ERROR_UTM_NORTH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 UTM string could not be parsed (format unknown). 的本地化字符串。
        /// </summary>
        internal static string ERROR_UTM_STRING {
            get {
                return ResourceManager.GetString("ERROR_UTM_STRING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 {0}{1} is an invalid utm zone. 的本地化字符串。
        /// </summary>
        internal static string ERROR_UTM_ZONE {
            get {
                return ResourceManager.GetString("ERROR_UTM_ZONE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Zone invalid. Range: 1 to 60. 的本地化字符串。
        /// </summary>
        internal static string ERROR_UTM_ZONE2 {
            get {
                return ResourceManager.GetString("ERROR_UTM_ZONE2", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 East: {0}; North: {1} 的本地化字符串。
        /// </summary>
        internal static string GAUSS_LONG_STRING {
            get {
                return ResourceManager.GetString("GAUSS_LONG_STRING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 E {0}   N {1} 的本地化字符串。
        /// </summary>
        internal static string GAUSS_SHORT_STRING {
            get {
                return ResourceManager.GetString("GAUSS_SHORT_STRING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Longitude: {0}; Latitude: {1} 的本地化字符串。
        /// </summary>
        internal static string GEOGRAPHIC_STRING {
            get {
                return ResourceManager.GetString("GEOGRAPHIC_STRING", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Satellite picture with this zoom level not available . 的本地化字符串。
        /// </summary>
        internal static string MS_NO_IMAGE {
            get {
                return ResourceManager.GetString("MS_NO_IMAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 There are no error details available. 的本地化字符串。
        /// </summary>
        internal static string NO_ERROR_MESSAGE {
            get {
                return ResourceManager.GetString("NO_ERROR_MESSAGE", resourceCulture);
            }
        }
    }
}
