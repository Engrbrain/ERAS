namespace ERAS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CFBCrudeExportMeters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MeterName = c.String(),
                        CurrentEightHours = c.String(),
                        MeterFactor = c.String(),
                        GrossCorr = c.String(),
                        BSW = c.DateTime(nullable: false),
                        NetOil = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CFBGasCompressions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Compressor = c.String(),
                        SuctionPressure = c.String(),
                        DischargePressure = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CFBGasLiftDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Well = c.String(),
                        Parameter = c.String(),
                        ParameterValue = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CFBMaintenanceDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Parameters = c.String(),
                        DailyTotal = c.String(),
                        PreviousTotal = c.String(),
                        Cummulative = c.DateTime(nullable: false),
                        Comment = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CFBProcessData_GasConsumed",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GasSource = c.String(),
                        GasFlow = c.Double(nullable: false),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CFBProcessData_GasProduced",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GasSource = c.String(),
                        Pressure = c.String(),
                        Temperature = c.String(),
                        GasFlowParameter = c.String(),
                        GasFlow = c.Double(nullable: false),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CFBSummaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Report = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CFBWaterInjectorMeters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MeterName = c.String(),
                        CurrentEightHours = c.String(),
                        PreviousEightHours = c.String(),
                        TwentyFourHours = c.String(),
                        Press = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CFBWaterInjectors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WaterInjector = c.String(),
                        Choke = c.String(),
                        D_Time = c.String(),
                        THP = c.String(),
                        FLP = c.String(),
                        VolumeInjected = c.String(),
                        Remarks = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CFBWellDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rsv = c.String(),
                        Well = c.String(),
                        CHOKE = c.String(),
                        HOURS = c.String(),
                        THP = c.String(),
                        FLP = c.String(),
                        BSW = c.String(),
                        Ps = c.String(),
                        Pwf = c.String(),
                        BHT = c.String(),
                        DP = c.String(),
                        OIL = c.Double(nullable: false),
                        GAS = c.Double(nullable: false),
                        WATER = c.Double(nullable: false),
                        API = c.String(),
                        PumpFrequency = c.String(),
                        Comment = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CONSUMABLESANALYSIS",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category = c.String(),
                        Parameters = c.String(),
                        PrevROB = c.String(),
                        Produced = c.DateTime(nullable: false),
                        Received = c.String(),
                        DailyConsumption = c.DateTime(nullable: false),
                        ROB = c.String(),
                        ConsumptionYTD = c.DateTime(nullable: false),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DailyProductionSummaries",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ReportParameter = c.String(),
                        MopuMeter = c.String(),
                        WaterInjection = c.String(),
                        Oilinventory = c.String(),
                        GasProduced = c.String(),
                        GasUtilized = c.String(),
                        GasFlared = c.String(),
                        ProducedWater = c.String(),
                        WfbUptime = c.String(),
                        MopuUptime = c.String(),
                        WaterInjectionUptime = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.DailySafetySummaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SafetyReport = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DownTimeLossReasons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DownTimeReport = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.E27GasLift",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GasLift = c.String(),
                        Blpd = c.String(),
                        InterpolationResult = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EHSSReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ReportCategory = c.String(),
                        ReportParameter = c.String(),
                        ReportValue = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EHSSVEERs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParameterCategory = c.String(),
                        Parameter = c.String(),
                        Today = c.String(),
                        CurrentWeek = c.String(),
                        Month = c.String(),
                        Cummulative = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EHSSVIRINIs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParameterCategory = c.String(),
                        Parameter = c.String(),
                        Today = c.String(),
                        CurrentWeek = c.String(),
                        Month = c.String(),
                        Cummulative = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FSCargoWPDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Parameters = c.String(),
                        ParameterValue = c.String(),
                        ParameterUnit = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FSOOILQUALITies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Parameters = c.String(),
                        ParameterValue = c.String(),
                        ParameterUnit = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FSOSummaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Report = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.InstrumentElectricals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Report = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LastAvialableWellTests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Well = c.String(),
                        GrossLiquid = c.String(),
                        Oil = c.String(),
                        Gas = c.String(),
                        Water = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OperationsSummaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DownTimeReport = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PendingMaintenanceReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Report = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PendingProjectWorkReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Report = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlannedMaintenances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Report = c.String(),
                        ReportCategory = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlantOperationsReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Report = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProducedWaterDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Parameters = c.String(),
                        TwentyFourHourReading = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProjectActivities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Report = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.UnPlannedMaintenances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Report = c.String(),
                        ReportCategory = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UnPlannedMaintenanceReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Report = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.WellTestResults",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rsv = c.String(),
                        Well = c.String(),
                        TestDate = c.String(),
                        Choke = c.String(),
                        Hours = c.String(),
                        THP = c.String(),
                        FLP = c.String(),
                        BSW = c.String(),
                        API = c.String(),
                        GROSSLIQUID = c.Double(nullable: false),
                        OIL = c.Double(nullable: false),
                        GAS = c.Double(nullable: false),
                        WATER = c.Double(nullable: false),
                        GOR = c.String(),
                        GLR = c.String(),
                        Ps = c.String(),
                        Pwf = c.String(),
                        FREQ = c.String(),
                        Comment = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WFBGasAllocations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Well = c.String(),
                        GOR = c.String(),
                        GAS = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WFBGasLiftDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Well = c.String(),
                        Parameter = c.String(),
                        ParameterValue = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WFBGeneralReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Report = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WFBMaintenanceDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Parameters = c.String(),
                        DailyTotal = c.String(),
                        PreviousTotal = c.String(),
                        Cummulative = c.DateTime(nullable: false),
                        Comment = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WFBProcessData_GasConsumed",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GasSource = c.String(),
                        GasFlow = c.Double(nullable: false),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WFBProcessData_GasProduced",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GasSource = c.String(),
                        Pressure = c.String(),
                        Temperature = c.String(),
                        GasFlowParameter = c.String(),
                        GasFlow = c.Double(nullable: false),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WFBWaterInjectorMeters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MeterName = c.String(),
                        CurrentEightHours = c.String(),
                        PreviousEightHours = c.String(),
                        TwentyFourHours = c.String(),
                        LFP = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WFBWellDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Rsv = c.String(),
                        Well = c.String(),
                        CHOKE = c.String(),
                        HOURS = c.String(),
                        THP = c.String(),
                        FLP = c.String(),
                        BSW = c.String(),
                        Ps = c.String(),
                        Pwf = c.String(),
                        BHT = c.String(),
                        DP = c.String(),
                        OIL = c.Double(nullable: false),
                        GAS = c.Double(nullable: false),
                        WATER = c.Double(nullable: false),
                        API = c.String(),
                        PumpFrequency = c.String(),
                        Comment = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WIJManifoldMeters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MeterName = c.String(),
                        CurrentEightHours = c.String(),
                        PreviousEightHours = c.String(),
                        TwentyFourHours = c.String(),
                        ReportDate = c.DateTime(nullable: false),
                        UploadTime = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        DayOftheWeek = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropTable("dbo.WIJManifoldMeters");
            DropTable("dbo.WFBWellDatas");
            DropTable("dbo.WFBWaterInjectorMeters");
            DropTable("dbo.WFBProcessData_GasProduced");
            DropTable("dbo.WFBProcessData_GasConsumed");
            DropTable("dbo.WFBMaintenanceDatas");
            DropTable("dbo.WFBGeneralReports");
            DropTable("dbo.WFBGasLiftDatas");
            DropTable("dbo.WFBGasAllocations");
            DropTable("dbo.WellTestResults");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.UnPlannedMaintenanceReports");
            DropTable("dbo.UnPlannedMaintenances");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.ProjectActivities");
            DropTable("dbo.ProducedWaterDatas");
            DropTable("dbo.PlantOperationsReports");
            DropTable("dbo.PlannedMaintenances");
            DropTable("dbo.PendingProjectWorkReports");
            DropTable("dbo.PendingMaintenanceReports");
            DropTable("dbo.OperationsSummaries");
            DropTable("dbo.LastAvialableWellTests");
            DropTable("dbo.InstrumentElectricals");
            DropTable("dbo.FSOSummaries");
            DropTable("dbo.FSOOILQUALITies");
            DropTable("dbo.FSCargoWPDatas");
            DropTable("dbo.EHSSVIRINIs");
            DropTable("dbo.EHSSVEERs");
            DropTable("dbo.EHSSReports");
            DropTable("dbo.E27GasLift");
            DropTable("dbo.DownTimeLossReasons");
            DropTable("dbo.DailySafetySummaries");
            DropTable("dbo.DailyProductionSummaries");
            DropTable("dbo.CONSUMABLESANALYSIS");
            DropTable("dbo.CFBWellDatas");
            DropTable("dbo.CFBWaterInjectors");
            DropTable("dbo.CFBWaterInjectorMeters");
            DropTable("dbo.CFBSummaries");
            DropTable("dbo.CFBProcessData_GasProduced");
            DropTable("dbo.CFBProcessData_GasConsumed");
            DropTable("dbo.CFBMaintenanceDatas");
            DropTable("dbo.CFBGasLiftDatas");
            DropTable("dbo.CFBGasCompressions");
            DropTable("dbo.CFBCrudeExportMeters");
        }
    }
}
