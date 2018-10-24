using System;

using ObjCRuntime;
using Foundation;
using UIKit;
using CoreGraphics;

namespace BRPtouchPrintKitW
{
    // @interface BRPtouchPrintInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface BRPtouchPrintInfo
    {
        // @property (copy, nonatomic) NSString * strPaperName;
        [Export("strPaperName")]
        string StrPaperName { get; set; }

        // @property (assign, nonatomic) int nPrintMode;
        [Export("nPrintMode")]
        int NPrintMode { get; set; }

        // @property (assign, nonatomic) double scaleValue;
        [Export("scaleValue")]
        double ScaleValue { get; set; }

        // @property (assign, nonatomic) int nDensity;
        [Export("nDensity")]
        int NDensity { get; set; }

        // @property (assign, nonatomic) int nOrientation;
        [Export("nOrientation")]
        int NOrientation { get; set; }

        // @property (assign, nonatomic) int nHalftone;
        [Export("nHalftone")]
        int NHalftone { get; set; }

        // @property (assign, nonatomic) int nHalftoneBinaryThreshold;
        [Export("nHalftoneBinaryThreshold")]
        int NHalftoneBinaryThreshold { get; set; }

        // @property (assign, nonatomic) int nHorizontalAlign;
        [Export("nHorizontalAlign")]
        int NHorizontalAlign { get; set; }

        // @property (assign, nonatomic) int nVerticalAlign;
        [Export("nVerticalAlign")]
        int NVerticalAlign { get; set; }

        // @property (assign, nonatomic) int nPaperAlign;
        [Export("nPaperAlign")]
        int NPaperAlign { get; set; }

        // @property (assign, nonatomic) int nExtFlag;
        [Export("nExtFlag")]
        int NExtFlag { get; set; }

        // @property (assign, nonatomic) int nAutoCutFlag;
        [Export("nAutoCutFlag")]
        int NAutoCutFlag { get; set; }

        // @property (assign, nonatomic) BOOL bEndcut;
        [Export("bEndcut")]
        bool BEndcut { get; set; }

        // @property (assign, nonatomic) int nAutoCutCopies;
        [Export("nAutoCutCopies")]
        int NAutoCutCopies { get; set; }

        // @property (assign, nonatomic) BOOL bSpecialTape;
        [Export("bSpecialTape")]
        bool BSpecialTape { get; set; }

        // @property (assign, nonatomic) BOOL bHalfCut;
        [Export("bHalfCut")]
        bool BHalfCut { get; set; }

        // @property (assign, nonatomic) int nTopMargin;
        [Export("nTopMargin")]
        int NTopMargin { get; set; }

        // @property (assign, nonatomic) int nLeftMargin;
        [Export("nLeftMargin")]
        int NLeftMargin { get; set; }

        // @property (assign, nonatomic) int nSpeed;
        [Export("nSpeed")]
        int NSpeed { get; set; }

        // @property (assign, nonatomic) BOOL bBidirection;
        [Export("bBidirection")]
        bool BBidirection { get; set; }

        // @property (assign, nonatomic) int nCustomLength;
        [Export("nCustomLength")]
        int NCustomLength { get; set; }

        // @property (assign, nonatomic) int nCustomWidth;
        [Export("nCustomWidth")]
        int NCustomWidth { get; set; }

        // @property (assign, nonatomic) int nCustomFeed;
        [Export("nCustomFeed")]
        int NCustomFeed { get; set; }

        // @property (copy, nonatomic) NSString * strSaveFilePath;
        [Export("strSaveFilePath")]
        string StrSaveFilePath { get; set; }

        // @property (assign, nonatomic) BOOL bOverWrite;
        [Export("bOverWrite")]
        bool BOverWrite { get; set; }

        // @property (assign, nonatomic) int nRollPrinterCase;
        [Export("nRollPrinterCase")]
        int NRollPrinterCase { get; set; }

        // @property (assign, nonatomic) BOOL bRotate180;
        [Export("bRotate180")]
        bool BRotate180 { get; set; }

        // @property (assign, nonatomic) BOOL bPeel;
        [Export("bPeel")]
        bool BPeel { get; set; }

        // @property (assign, nonatomic) BOOL bCutMark;
        [Export("bCutMark")]
        bool BCutMark { get; set; }

        // @property (assign, nonatomic) int nLabelMargine;
        [Export("nLabelMargine")]
        int NLabelMargine { get; set; }

        // @property (assign, nonatomic) int nPJPaperKind;
        [Export("nPJPaperKind")]
        int NPJPaperKind { get; set; }

        // @property (assign, nonatomic) int nPrintQuality;
        [Export("nPrintQuality")]
        int NPrintQuality { get; set; }

        // @property (assign, nonatomic) BOOL bMode9;
        [Export("bMode9")]
        bool BMode9 { get; set; }

        // @property (assign, nonatomic) BOOL bRawMode;
        [Export("bRawMode")]
        bool BRawMode { get; set; }

        // @property (assign, nonatomic) BOOL bBanishMargin;
        [Export("bBanishMargin")]
        bool BBanishMargin { get; set; }

        // @property (assign, nonatomic) BOOL bUseLegacyHalftoneEngine;
        [Export("bUseLegacyHalftoneEngine")]
        bool BUseLegacyHalftoneEngine { get; set; }
    }

/*    // @interface BRPtouchPrinterData : NSObject
    [BaseType(typeof(NSObject))]
    interface BRPtouchPrinterData
    {
        // -(NSArray *)getPrinterList;
        [Export("getPrinterList")]
        NSObject[] PrinterList { get; }
    }

    // @interface BRPtouchPrinterStatus : NSObject
    [BaseType(typeof(NSObject))]
    interface BRPtouchPrinterStatus
    {
        // @property (nonatomic) PTSTATUSINFO statusInfo;
        [Export("statusInfo", ArgumentSemantic.Assign)]
        PTSTATUSINFO StatusInfo { get; set; }

        // @property (nonatomic) int32_t batteryResidualQuantityLevel;
        [Export("batteryResidualQuantityLevel")]
        int BatteryResidualQuantityLevel { get; set; }

        // @property (nonatomic) int32_t maxOfBatteryResidualQuantityLevel;
        [Export("maxOfBatteryResidualQuantityLevel")]
        int MaxOfBatteryResidualQuantityLevel { get; set; }

        // @property (nonatomic) BRPtouchPrinterStatusBatteryTernary isACConnected;
        [Export("isACConnected", ArgumentSemantic.Assign)]
        BRPtouchPrinterStatusBatteryTernary IsACConnected { get; set; }

        // @property (nonatomic) BRPtouchPrinterStatusBatteryTernary isBatteryMounted;
        [Export("isBatteryMounted", ArgumentSemantic.Assign)]
        BRPtouchPrinterStatusBatteryTernary IsBatteryMounted { get; set; }

        // @property (nonatomic) int16_t batteryLevel __attribute__((deprecated("")));
        [Export("batteryLevel")]
        short BatteryLevel { get; set; }
    }

    // @interface BRPtouchLabelParam : NSObject
    [BaseType(typeof(NSObject))]
    interface BRPtouchLabelParam
    {
        // @property (nonatomic) unsigned int paperID;
        [Export("paperID")]
        uint PaperID { get; set; }

        // @property (copy, nonatomic) NSString * paperName;
        [Export("paperName")]
        string PaperName { get; set; }

        // @property (nonatomic) unsigned int paperSize;
        [Export("paperSize")]
        uint PaperSize { get; set; }

        // @property (nonatomic) unsigned int pinOffsetLeft;
        [Export("pinOffsetLeft")]
        uint PinOffsetLeft { get; set; }

        // @property (nonatomic) unsigned int pinOffsetRight;
        [Export("pinOffsetRight")]
        uint PinOffsetRight { get; set; }

        // @property (nonatomic) unsigned int physicalOffsetX;
        [Export("physicalOffsetX")]
        uint PhysicalOffsetX { get; set; }

        // @property (nonatomic) unsigned int physicalOffsetY;
        [Export("physicalOffsetY")]
        uint PhysicalOffsetY { get; set; }

        // @property (nonatomic) unsigned int paperWidth;
        [Export("paperWidth")]
        uint PaperWidth { get; set; }

        // @property (nonatomic) float paperWidth_mm;
        [Export("paperWidth_mm")]
        float PaperWidth_mm { get; set; }

        // @property (nonatomic) unsigned int paperLength;
        [Export("paperLength")]
        uint PaperLength { get; set; }

        // @property (nonatomic) float paperLength_mm;
        [Export("paperLength_mm")]
        float PaperLength_mm { get; set; }

        // @property (nonatomic) unsigned int imageAreaWidth;
        [Export("imageAreaWidth")]
        uint ImageAreaWidth { get; set; }

        // @property (nonatomic) unsigned int imageAreaWidth_mm;
        [Export("imageAreaWidth_mm")]
        uint ImageAreaWidth_mm { get; set; }

        // @property (nonatomic) unsigned int imageAreaLength;
        [Export("imageAreaLength")]
        uint ImageAreaLength { get; set; }

        // @property (nonatomic) unsigned int imageAreaLength_mm;
        [Export("imageAreaLength_mm")]
        uint ImageAreaLength_mm { get; set; }
    }

    // @interface BRPtouchLabelInfoStatus : NSObject
    [BaseType(typeof(NSObject))]
    interface BRPtouchLabelInfoStatus
    {
        // @property (nonatomic) LabelIdType labelID;
        [Export("labelID", ArgumentSemantic.Assign)]
        LabelIdType LabelID { get; set; }

        // @property (nonatomic) ColorType labelColor;
        [Export("labelColor", ArgumentSemantic.Assign)]
        ColorType LabelColor { get; set; }

        // @property (nonatomic) ColorType fontColor;
        [Export("fontColor", ArgumentSemantic.Assign)]
        ColorType FontColor { get; set; }
    }

    // @interface BRPtouchBatteryInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface BRPtouchBatteryInfo
    {
        // @property (readonly, nonatomic) int8_t batteryChargeLevel;
        [Export("batteryChargeLevel")]
        sbyte BatteryChargeLevel { get; }

        // @property (readonly, nonatomic) int8_t batteryHealthLevel;
        [Export("batteryHealthLevel")]
        sbyte BatteryHealthLevel { get; }

        // @property (readonly, nonatomic) BRPtouchBatteryInfoBatteryHealthStatus batteryHealthStatus;
        [Export("batteryHealthStatus")]
        BRPtouchBatteryInfoBatteryHealthStatus BatteryHealthStatus { get; }

        // -(instancetype)initWithChargeLevel:(int8_t)chargeLevel healthLevel:(int8_t)healthLevel healthStatusData:(int8_t)healthStatusData;
        [Export("initWithChargeLevel:healthLevel:healthStatusData:")]
        IntPtr Constructor(sbyte chargeLevel, sbyte healthLevel, sbyte healthStatusData);
    }
    */
    [Static]
    partial interface Constants
    {
        // extern NSString * BRWLanConnectBytesWrittenNotification;
        [Field("BRWLanConnectBytesWrittenNotification", "__Internal")]
        NSString BRWLanConnectBytesWrittenNotification { get; }

        // extern NSString * BRBluetoothSessionBytesWrittenNotification;
//        [Field("BRBluetoothSessionBytesWrittenNotification", "__Internal")]
//        NSString BRBluetoothSessionBytesWrittenNotification { get; }

        // extern NSString * BRBLEBytesWrittenNotification;
        [Field("BRBLEBytesWrittenNotification", "__Internal")]
        NSString BRBLEBytesWrittenNotification { get; }

        // extern NSString * BRPtouchPrinterKitMessageNotification;
        [Field("BRPtouchPrinterKitMessageNotification", "__Internal")]
        NSString BRPtouchPrinterKitMessageNotification { get; }

        // extern NSString *const BRBytesWrittenKey;
        [Field("BRBytesWrittenKey", "__Internal")]
        NSString BRBytesWrittenKey { get; }

        // extern NSString *const BRBytesToWriteKey;
        [Field("BRBytesToWriteKey", "__Internal")]
        NSString BRBytesToWriteKey { get; }

        // extern NSString *const BRMessageKey;
        [Field("BRMessageKey", "__Internal")]
        NSString BRMessageKey { get; }
    }

    // @interface BRPtouchPrinter : NSObject <NSNetServiceBrowserDelegate, NSNetServiceDelegate>
    [BaseType(typeof(NSObject))]
    interface BRPtouchPrinter : INSNetServiceBrowserDelegate, INSNetServiceDelegate
    {
        // -(id)initWithPrinterIPAddress:(NSString *)IPAddress;
        [Export("initWithPrinterIPAddress:")]
        IntPtr Constructor(string IPAddress);

        // -(id)initWithPrinterName:(NSString *)strPrinterName;
//        [Export("initWithPrinterName:")]
//        IntPtr Constructor(string strPrinterName);

        // -(id)initWithPrinterName:(NSString *)strPrinterName interface:(CONNECTION_TYPE)type;
        [Export("initWithPrinterName:interface:")]
        IntPtr Constructor(string strPrinterName, ConnectionType type);

        // -(BOOL)setPrinterName:(NSString *)strPrinterName;
        [Export("setPrinterName:")]
        bool SetPrinterName(string strPrinterName);

        // -(void)setPrintInfo:(BRPtouchPrintInfo *)printInfo;
        [Export("setPrintInfo:")]
        void SetPrintInfo(BRPtouchPrintInfo printInfo);

        // -(BOOL)setCustomPaperFile:(NSString *)strFilePath;
/*        [Export("setCustomPaperFile:")]
        bool SetCustomPaperFile(string strFilePath);

        // -(BOOL)isPrinterReady;
        [Export("isPrinterReady")]
        bool IsPrinterReady { get; }

        // -(NSArray *)getSupportPaperArray;
        [Export("getSupportPaperArray")]
        NSObject[] SupportPaperArray { get; }

        // -(BRPtouchLabelParam *)getCurrentLabelParam;
        [Export("getCurrentLabelParam")]
        BRPtouchLabelParam CurrentLabelParam { get; }

        // -(BRPtouchLabelInfoStatus *)getLabelInfoStatus;
        [Export("getLabelInfoStatus")]
        BRPtouchLabelInfoStatus LabelInfoStatus { get; }

        // -(int)getPTStatus:(PTSTATUSINFO *)status;
        [Export("getPTStatus:")]
        unsafe int GetPTStatus(PTSTATUSINFO status);

        // -(int)getStatus:(BRPtouchPrinterStatus **)status;
        [Export("getStatus:")]
        int GetStatus(out BRPtouchPrinterStatus status);

        // -(NSString *)getModelName;
        [Export("getModelName")]
        string ModelName { get; }

        // -(NSString *)getFirmVersion;
        [Export("getFirmVersion")]
        string FirmVersion { get; }

        // -(NSString *)getMediaVersion;
        [Export("getMediaVersion")]
        string MediaVersion { get; }

        // -(NSString *)getMediaFileVersion:(NSString *)filepath;
        [Export("getMediaFileVersion:")]
        string GetMediaFileVersion(string filepath);

        // -(NSString *)getDeviceSerialNumber;
        [Export("getDeviceSerialNumber")]
        string DeviceSerialNumber { get; }

        // -(int)getSystemReport:(NSString **)report;
        [Export("getSystemReport:")]
        int GetSystemReport(out string report);

        // -(BOOL)sendTemplateFile:(NSArray *)sendFileArray;
        [Export("sendTemplateFile:")]
        bool SendTemplateFile(NSObject[] sendFileArray);

        // -(BOOL)sendFirmwareFile:(NSArray *)sendFileArray;
        [Export("sendFirmwareFile:")]
        bool SendFirmwareFile(NSObject[] sendFileArray);

        // -(int)sendTemplate:(NSString *)sendtemplateFilePath connectionType:(CONNECTION_TYPE)type;
        [Export("sendTemplate:connectionType:")]
        int SendTemplate(string sendtemplateFilePath, ConnectionType type);
*/
        // -(void)setIPAddress:(NSString *)strIP;
        [Export("setIPAddress:")]
        void SetIPAddress(string strIP);

        // -(void)setupForBluetoothDeviceWithSerialNumber:(NSString *)serialNumber;
/*        [Export("setupForBluetoothDeviceWithSerialNumber:")]
        void SetupForBluetoothDeviceWithSerialNumber(string serialNumber);

        // -(void)setBLEAdvertiseLocalName:(NSString *)advertiseLocalName;
        [Export("setBLEAdvertiseLocalName:")]
        void SetBLEAdvertiseLocalName(string advertiseLocalName);
*/
        // -(int)startPrint __attribute__((deprecated("")));
        [Export("startPrint")]
        int StartPrint { get; }

        // -(BOOL)startCommunication;
        [Export("startCommunication")]
        bool StartCommunication();

        // -(void)endPrint __attribute__((deprecated("")));
        [Export("endPrint")]
        void EndPrint();

        // -(void)endCommunication;
        [Export("endCommunication")]
        void EndCommunication();

        // -(int)sendFile:(NSString *)filePath;
/*        [Export("sendFile:")]
        int SendFile(string filePath);

        // -(int)sendData:(NSData *)data;
        [Export("sendData:")]
        int SendData(NSData data);

        // -(int)sendFileEx:(NSString *)filePath;
        [Export("sendFileEx:")]
        int SendFileEx(string filePath);

        // -(int)sendDataEx:(NSData *)data;
        [Export("sendDataEx:")]
        int SendDataEx(NSData data);

        // -(int)printPDFAtPath:(NSString *)pdfPath pages:(NSUInteger *)indexes length:(NSUInteger)length copy:(int)nCopy;
        [Export("printPDFAtPath:pages:length:copy:")]
        int PrintPDFAtPath(string pdfPath, Foundation.NSObject indexes, nuint length, int nCopy);
*/
        // -(int)printImage:(CGImageRef)imageRef copy:(int)nCopy;
        [Export("printImage:copy:")]
        unsafe int PrintImage(CGImage imageRef, int nCopy);

        // -(int)printFiles:(NSArray *)filePaths copy:(int)nCopy;
//        [Export("printFiles:copy:")]
//        int PrintFiles(NSObject[] filePaths, int nCopy);

        // -(int)cancelPrinting;
        [Export("cancelPrinting")]
        int CancelPrinting { get; }

        // -(void)setInterface:(CONNECTION_TYPE)strInterface;
/*        [Export("setInterface:")]
        void SetInterface(ConnectionType strInterface);

        // -(int)getBatteryStatus;
        [Export("getBatteryStatus")]
        int BatteryStatus { get; }

        // -(int)getBatteryInfo:(BRPtouchBatteryInfo **)batteryInfo;
        [Export("getBatteryInfo:")]
        int GetBatteryInfo(out BRPtouchBatteryInfo batteryInfo);

        // -(int)getPrinterBootMode;
        [Export("getPrinterBootMode")]
        int PrinterBootMode { get; }

        // -(int)setAutoConnectBluetooth:(BOOL)flag;
        [Export("setAutoConnectBluetooth:")]
        int SetAutoConnectBluetooth(bool flag);

        // -(int)isAutoConnectBluetooth;
        [Export("isAutoConnectBluetooth")]
        int IsAutoConnectBluetooth { get; }
*/
        // -(int)setPrinterSettings:(NSDictionary *)printerSettings;
        [Export("setPrinterSettings:")]
        int SetPrinterSettings(NSDictionary printerSettings);

        // -(int)getPrinterSettings:(NSDictionary **)printerSettings require:(NSArray *)require;
        [Export("getPrinterSettings:require:")]
        int GetPrinterSettings(out NSDictionary printerSettings, NSObject[] require);
    }
}

