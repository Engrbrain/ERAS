using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ERAS.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<ERAS.Models.EBOKDailyReport.DailyProductionSummary> DailyProductionSummaries { get; set; }

        public DbSet<ERAS.Models.EBOKDailyReport.DailySafetySummary> DailySafetySummaries { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.DownTimeLossReason> DownTimeLossReasons { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.OperationsSummary> OperationsSummaries { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.CFBWellData> CFBWellData { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.WFBWellData> WFBWellData { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.WellTestResult> WellTestResults { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.CFBGasCompression> CFBGasCompressions { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.CFBGasLiftData> CFBGasLiftDatas { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.WFBGasLiftData> WFBGasLiftData { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.CFBProcessData_GasProduced> CFBProcessData_GasProduced { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.CFBProcessData_GasConsumed> CFBProcessData_GasConsumed { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.WFBProcessData_GasProduced> WFBProcessData_GasProduced { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.WFBProcessData_GasConsumed> WFBProcessData_GasConsumed { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.CFBWaterInjectorMeter> CFBWaterInjectorMeters { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.WFBWaterInjectorMeter> WFBWaterInjectorMeters { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.CFBWaterInjector> CFBWaterInjectors { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.WIJManifoldMeter> WIJManifoldMeters { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.CFBCrudeExportMeter> CFBCrudeExportMeters { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.ProducedWaterData> ProducedWaterData { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.FSCargoWPData> FSCargoWPData { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.FSOOILQUALITY> FSOOILQUALITIES { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.CFBMaintenanceData> CFBMaintenanceData { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.WFBMaintenanceData> WFBMaintenanceData { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.CONSUMABLESANALYSIS> CONSUMABLESANALYSIS { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.FSOSummary> FSOSummaries { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.CFBSummary> CFBSummaries { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.PlantOperationsReport> PlantOperationsReports { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.PlannedMaintenance> PlannedMaintenance { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.UnPlannedMaintenance> UnPlannedMaintenance { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.ProjectActivity> ProjectActivities { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.WFBGeneralReport> WFBGeneralReports { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.PendingProjectWorkReport> PendingProjectWorkReports { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.PendingMaintenanceReport> PendingMaintenanceReports { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.UnPlannedMaintenanceReport> UnPlannedMaintenanceReports { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.InstrumentElectrical> InstrumentElectricals { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.EHSSReport> EHSSReports { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.EHSSVEER> EHSSVEERS { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.EHSSVIRINI> EHSSVIRINIS { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.LastAvialableWellTest> LastAvialableWellTests { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.WFBGasAllocation> WFBGasAllocations { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.E27GasLift> E27GasLifts { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.WellTestEnrichmentData> WellTestEnrichmentData { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.WFBProcessData_Reading> WFBProcessData_Reading { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.CFBProcessData_Reading> CFBProcessData_Reading { get; set; }
        public DbSet<ERAS.Models.EBOKDailyReport.ProductionPotential> ProductionPotential { get; set; }
    }
}