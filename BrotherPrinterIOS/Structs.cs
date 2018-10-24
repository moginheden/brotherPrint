using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace BRPtouchPrintKitW
{
    [StructLayout(LayoutKind.Sequential)]
    public struct PTSTATUSINFO
    {
        public byte byHead;

        public byte bySize;

        public byte byBrotherCode;

        public byte bySeriesCode;

        public byte byModelCode;

        public byte byNationCode;

        public byte byFiller;

        public byte byFiller2;

        public byte byErrorInf;

        public byte byErrorInf2;

        public byte byMediaWidth;

        public byte byMediaType;

        public byte byColorNum;

        public byte byFont;

        public byte byJapanesFont;

        public byte byMode;

        public byte byDensity;

        public byte byMediaLength;

        public byte byStatusType;

        public byte byPhaseType;

        public byte byPhaseNoHi;

        public byte byPhaseNoLow;

        public byte byNoticeNo;

        public byte byExtByteNum;

        public byte byLabelColor;

        public byte byFontColor;

        public byte[] byHardWareSetting;

        public byte[] byNoUse;
    }

    [Native]
    public enum BRPtouchPrinterStatusBatteryTernary : long
    {
        Unknown = -1,
        Yes = 1,
        No = 0
    }

    [Native]
    public enum LabelIdType : long
    {
        W17h54 = 1,
        W17h87 = 2,
        W23h23 = 3,
        W29h42 = 4,
        W29h90 = 5,
        W38h90 = 6,
        W39h48 = 7,
        W52h29 = 8,
        W62h29 = 9,
        W62h100 = 10,
        W12 = 11,
        W29 = 12,
        W38 = 13,
        W50 = 14,
        W54 = 15,
        W62 = 16,
        W60h86 = 17,
        W35 = 18,
        W6 = 19,
        W9 = 20,
        W18 = 21,
        W24 = 22,
        HsW6 = 23,
        HsW9 = 24,
        HsW12 = 25,
        HsW18 = 26,
        HsW24 = 27,
        W36 = 28,
        R65 = 29,
        R60 = 31,
        R50 = 32,
        R40 = 33,
        R35 = 34,
        R30 = 35,
        R25 = 36,
        FleW21h45 = 37,
        W62rb = 38,
        W54h29 = 39,
        W102 = 40,
        W102h51 = 41,
        W102h152 = 48,
        W103 = 49,
        W103h164 = 50,
        DtW90 = 51,
        DtW102 = 52,
        DtW102h51 = 53,
        DtW102h152 = 54,
        LabelMax
    }

    [Native]
    public enum ColorType : long
    {
        White = 1,
        Others,
        Clear,
        Red,
        Blue,
        Yellow,
        Green,
        Black,
        ClearWhite,
        Gold = 10,
        GoldPremium = 11,
        SilverPremium = 12,
        OthersPremium = 13,
        OthersMasking = 14,
        MatteWhite = 32,
        MatteClear,
        MatteSilver,
        SatinGold,
        SatinSilver = 36,
        BlueWhite = 48,
        RedWhite = 49,
        FlourescentOrange = 64,
        FlourescentYellow = 65,
        BerryPink = 80,
        LightGlay,
        LimeGreen = 82,
        FabricYellow = 96,
        FabricPink = 97,
        FabricBlue = 98,
        TubeWhite = 112,
        SelfWhite = 128,
        FlexibleWhite = 144,
        FlexibleYellow = 145,
        Cleaning = 240,
        Stencil = 241,
        Unsupport = 255
    }

    [Native]
    public enum BRPtouchBatteryInfoBatteryHealthStatus : long
    {
        Excellent,
        Good,
        ReplaceSoon,
        ReplaceBattery,
        NotInstalled
    }

    [Native]
    public enum PrinterSettingItem : long
    {
        NetBootmode = 1,
        NetInterface = 2,
        NetUsedIpv6 = 3,
        NetPriorityIpv6 = 4,
        NetIpv4Bootmethod = 5,
        NetStaticIpv4address = 6,
        NetSubnetmask = 7,
        NetGateway = 8,
        NetDnsIpv4Bootmethod = 9,
        NetPrimaryDnsIpv4address = 10,
        NetSecondDnsIpv4address = 11,
        NetIpv6Bootmethod = 12,
        NetStaticIpv6address = 13,
        NetPrimaryDnsIpv6address = 14,
        NetSecondDnsIpv6address = 15,
        NetIpv6addressList = 16,
        NetCommunicationMode = 17,
        NetSsid = 18,
        NetChannel = 19,
        NetAuthenticationMethod = 20,
        NetEncryptionmode = 21,
        NetWepkey = 22,
        NetPassphrase = 23,
        NetUserId = 24,
        NetPassword = 25,
        NetNodename = 26,
        WirelessdirectKeyCreateMode = 27,
        WirelessdirectSsid = 28,
        WirelessdirectNetworkKey = 29,
        BtIsdiscoverable = 30,
        BtDevicename = 31,
        BtBootmode = 34,
        PrinterPowerofftime = 35,
        PrinterPowerofftimeBattery = 36,
        PrintJpegHalftone = 37,
        PrintJpegScale = 38,
        PrintDensity = 39,
        PrintSpeed = 40,
        BtPowersavemode = 41,
        BtSsp = 42,
        BtAuthmode = 43,
        BtAutoConnection = 44
    }

    [Native]
    public enum ConnectionType : long
    {
        Wlan,
        Bluetooth,
        Ble,
        Error
    }

    public enum BRPtouchPrinterErrors : long
    {
        ERROR_NONE_ = 0,
        ERROR_TIMEOUT = -3,
        ERROR_BADPAPERRES = -4,
        ERROR_IMAGELARGE = -6,
        ERROR_CREATESTREAM = -7,
        ERROR_OPENSTREAM = -8,
        ERROR_FILENOTEXIST = -9,
        ERROR_PAGERANGEERROR = -10,
        ERROR_NOT_SAME_MODEL_ = -11,
        ERROR_BROTHER_PRINTER_NOT_FOUND_ = -12,
        ERROR_PAPER_EMPTY_ = -13,
        ERROR_BATTERY_EMPTY_ = -14,
        ERROR_COMMUNICATION_ERROR_ = -15,
        ERROR_OVERHEAT_ = -16,
        ERROR_PAPER_JAM_ = -17,
        ERROR_HIGH_VOLTAGE_ADAPTER_ = -18,
        ERROR_CHANGE_CASSETTE_ = -19,
        ERROR_FEED_OR_CASSETTE_EMPTY_ = -20,
        ERROR_SYSTEM_ERROR_ = -21,
        ERROR_NO_CASSETTE_ = -22,
        ERROR_WRONG_CASSENDTE_DIRECT_ = -23,
        ERROR_CREATE_SOCKET_FAILED_ = -24,
        ERROR_CONNECT_SOCKET_FAILED_ = -25,
        ERROR_GET_OUTPUT_STREAM_FAILED_ = -26,
        ERROR_GET_INPUT_STREAM_FAILED_ = -27,
        ERROR_CLOSE_SOCKET_FAILED_ = -28,
        ERROR_OUT_OF_MEMORY_ = -29,
        ERROR_SET_OVER_MARGIN_ = -30,
        ERROR_NO_SD_CARD_ = -31,
        ERROR_FILE_NOT_SUPPORTED_ = -32,
        ERROR_EVALUATION_TIMEUP_ = -33,
        ERROR_WRONG_CUSTOM_INFO_ = -34,
        ERROR_NO_ADDRESS_ = -35,
        ERROR_NOT_MATCH_ADDRESS_ = -36,
        ERROR_FILE_NOT_FOUND_ = -37,
        ERROR_TEMPLATE_FILE_NOT_MATCH_MODEL_ = -38,
        ERROR_TEMPLATE_NOT_TRANS_MODEL_ = -39,
        ERROR_COVER_OPEN_ = -40,
        ERROR_WRONG_LABEL_ = -41,
        ERROR_PORT_NOT_SUPPORTED_ = -42,
        ERROR_WRONG_TEMPLATE_KEY_ = -43,
        ERROR_BUSY_ = -44,
        ERROR_TEMPLATE_NOT_PRINT_MODEL_ = -45,
        ERROR_CANCEL_ = -46,
        ERROR_PRINTER_SETTING_NOT_SUPPORTED_ = -47,
        ERROR_INVALID_PARAMETER_ = -48,
        ERROR_INTERNAL_ERROR_ = -49,
        ERROR_TEMPLATE_NOT_CONTROL_MODEL_ = -50,
        ERROR_TEMPLATE_NOT_EXIST_ = -51,
        ERROR_BADENCRYPT_ = -52, // This does not occur in iOS
        ERROR_BUFFER_FULL_ = -53,
        ERROR_TUBE_EMPTY_ = -54,
        ERROR_TUBE_RIBON_EMPTY_ = -55,
        ERROR_UPDATE_FRIM_NOT_SUPPORTED_ = -56, // This does not occur in iOS
        ERROR_OS_VERSION_NOT_SUPPORTED_ = -57, // This does not occur in iOS
        ERROR_MINIMUM_LENGTH_LIMIT_ = -58
    }

    public enum PrintFlags : int
    {
        OPTION_AUTOCUT = 0x00000001,
        OPTION_CUTATEND = 0x00000002,

        PRINT_ORIGINAL = 0x00,
        PRINT_FIT = 0x01, // Deprecated
        PRINT_SCALE = 0x02,
        PRINT_FIT_TO_PAGE = 0x03,
        PRINT_FIT_TO_PAPER = 0x04,

        ORI_LANDSCAPE = 0x00,
        ORI_PORTRATE = 0x01,

        // Image processing Setting
        HALFTONE_BINARY = 0x00,
        HALFTONE_DITHER = 0x01,
        HALFTONE_ERRDIF = 0x02,

        ALIGN_LEFT = 0x00,
        ALIGN_CENTER = 0x01,
        ALIGN_RIGHT = 0x02,

        ALIGN_TOP = 0x00,
        ALIGN_MIDDLE = 0x01,
        ALIGN_BOTTOM = 0x02,

        PAPERALIGN_LEFT = 0x00,
        PAPERALIGN_CENTER = 0x01,
        PAPERALIGN_RIGHT = 0x02,

        RET_ERR_PAPERNAME = -1,
        RET_ERR_OPTION = -2,
        RET_ERR_DENSITY = -3,
        RET_ERR_PRINTMODE = -4,
        RET_ERR_ORIENTATION = -5,
        RET_ERR_HALFTONE = -6,
        RET_ERR_HORIZONTAL = -7,
        RET_ERR_VERTICAL = -8,
        RET_ERR_PAPERALIGN = -9,
        RET_ERR_EXTFLAG = -10,

        // Cut Mode
        FLAG_M_AUTOCUT = 0x40,
        FLAG_M_MIRROR = 0x80,

        FLAG_K_DRAFT = 0x01,
        FLAG_K_HALFCUT = 0x04,
        FLAG_K_NOCHAIN = 0x08,
        FLAG_K_SPTAPE = 0x10,
        FLAG_K_AFTERCUT = 0x20,
        FLAG_K_HGPRINT = 0x40,
        FLAG_K_COPY = 0x80,


        EXT_PJ673_ENCRYPT = 0x01,
        EXT_PJ673_CARBON = 0x02,
        EXT_PJ673_DASHPRINT = 0x04,
        EXT_PJ673_NFD = 0x08,
        EXT_PJ673_EOP = 0x10,
        EXT_PJ673_EPR = 0x20,
        EXT_PJ700_FP = 0x40,

        COMPRESS_ID = 0x4D,
        COMPRESS_DISABLED = 0x00,
        COMPRESS_PRESERVED = 0x01,
        COMPRESS_ENABLED = 0x02,

        PJROLLCASE_OFF = 1, //Do not user printer case
        PJROLLCASE_ON = 2, //Use printer case with anti-curling mechanism
        PJROLLCASE_WITH_ANTICURL = 3, // Use printer case without anti-curling mechanism

        PJ_ROLL = 0x01,
        PJ_CUT_PAPER = 0x02,

        //Print Quality
        PRINTQUALITY_LOW_RESOLUTION = 1,
        PRINTQUALITY_NORMAL = 2,
        PRINTQUALITY_DOUBLE_SPEED = 3,
        PRINTQUALITY_HIGH_RESOLUTION = 4,
        PRINTQUALITY_HIGH_RESOLUTION_USING_HR_IMAGE = 5
    }
}

