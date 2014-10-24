//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CicOData
{
    using System;
    using System.Collections.Generic;
    
    public partial class IWrkgrpQueueStats
    {
        public int StatisticsSet { get; set; }
        public string cName { get; set; }
        public string cReportGroup { get; set; }
        public string cHKey3 { get; set; }
        public string cHKey4 { get; set; }
        public string cType { get; set; }
        public System.DateTime dIntervalStart { get; set; }
        public System.DateTime dIntervalStartUTC { get; set; }
        public int nDuration { get; set; }
        public Nullable<int> nEnteredAcd { get; set; }
        public Nullable<int> nAbandonedAcd { get; set; }
        public Nullable<int> nGrabbedAcd { get; set; }
        public Nullable<int> nLocalDisconnectAcd { get; set; }
        public Nullable<int> nLocalDisconnectAgentAlertAcd { get; set; }
        public Nullable<int> nLocalDisconnectAgentAcd { get; set; }
        public Nullable<int> nAlertedAcd { get; set; }
        public Nullable<int> nAnsweredAcd { get; set; }
        public Nullable<int> nAnswered { get; set; }
        public Nullable<int> nAcdSvcLvl { get; set; }
        public Nullable<int> nAnsweredAcdSvcLvl { get; set; }
        public Nullable<int> nAnsweredAcdSvcLvl1 { get; set; }
        public Nullable<int> nAnsweredAcdSvcLvl2 { get; set; }
        public Nullable<int> nAnsweredAcdSvcLvl3 { get; set; }
        public Nullable<int> nAnsweredAcdSvcLvl4 { get; set; }
        public Nullable<int> nAnsweredAcdSvcLvl5 { get; set; }
        public Nullable<int> nAnsweredAcdSvcLvl6 { get; set; }
        public Nullable<int> nAbandonAcdSvcLvl { get; set; }
        public Nullable<int> nAbandonAcdSvcLvl1 { get; set; }
        public Nullable<int> nAbandonAcdSvcLvl2 { get; set; }
        public Nullable<int> nAbandonAcdSvcLvl3 { get; set; }
        public Nullable<int> nAbandonAcdSvcLvl4 { get; set; }
        public Nullable<int> nAbandonAcdSvcLvl5 { get; set; }
        public Nullable<int> nAbandonAcdSvcLvl6 { get; set; }
        public Nullable<int> tGrabbedAcd { get; set; }
        public Nullable<int> tAnsweredAcd { get; set; }
        public Nullable<int> mtAnsweredAcd { get; set; }
        public Nullable<int> tAbandonedAcd { get; set; }
        public Nullable<int> tTalkAcd { get; set; }
        public Nullable<int> tTalkCompleteAcd { get; set; }
        public Nullable<int> nHoldAcd { get; set; }
        public Nullable<int> tHoldAcd { get; set; }
        public Nullable<int> nSuspendedAcd { get; set; }
        public Nullable<int> tSuspendedAcd { get; set; }
        public Nullable<int> nHeldSpanAcd { get; set; }
        public Nullable<int> nAcw { get; set; }
        public Nullable<int> tAcw { get; set; }
        public Nullable<int> tAcwComplete { get; set; }
        public Nullable<int> nExternToInternCalls { get; set; }
        public Nullable<int> nExternToInternAcdCalls { get; set; }
        public Nullable<int> nInternToExternCalls { get; set; }
        public Nullable<int> nInternToExternAcdCalls { get; set; }
        public Nullable<int> nInternToInternCalls { get; set; }
        public Nullable<int> nInternToInternAcdCalls { get; set; }
        public Nullable<int> tExternToInternCalls { get; set; }
        public Nullable<int> tExternToInternAcdCalls { get; set; }
        public Nullable<int> tInternToExternCalls { get; set; }
        public Nullable<int> tInternToExternAcdCalls { get; set; }
        public Nullable<int> tInternToInternCalls { get; set; }
        public Nullable<int> tInternToInternAcdCalls { get; set; }
        public Nullable<int> nAcwCalls { get; set; }
        public Nullable<int> tAcwCalls { get; set; }
        public Nullable<int> nTransferedAcd { get; set; }
        public Nullable<int> nNotAnsweredAcd { get; set; }
        public Nullable<int> tAlertedAcd { get; set; }
        public Nullable<int> nFlowOutAcd { get; set; }
        public Nullable<int> tFlowOutAcd { get; set; }
        public Nullable<int> nStartWaitAlertAcdCalls { get; set; }
        public Nullable<int> nStartActiveAcdCalls { get; set; }
        public Nullable<int> nStartHeldAcdCalls { get; set; }
        public Nullable<int> nEndWaitAlertAcdCalls { get; set; }
        public Nullable<int> nEndActiveAcdCalls { get; set; }
        public Nullable<int> nEndHeldAcdCalls { get; set; }
        public Nullable<int> nTransferWithinAcdCalls { get; set; }
        public Nullable<int> nTransferOutAcdCalls { get; set; }
        public Nullable<int> nDisconnectAcd { get; set; }
        public Nullable<int> tAgentLoggedIn { get; set; }
        public Nullable<int> tAgentAvailable { get; set; }
        public Nullable<int> tAgentTalk { get; set; }
        public Nullable<int> tAgentOtherBusy { get; set; }
        public Nullable<int> tAgentOnAcdCall { get; set; }
        public Nullable<int> tAgentOnOtherAcdCall { get; set; }
        public Nullable<int> tAgentInAcw { get; set; }
        public Nullable<int> tAgentOnNonAcdCall { get; set; }
        public Nullable<int> tAgentDnd { get; set; }
        public Nullable<int> tAgentNotAvailable { get; set; }
        public Nullable<int> tAgentAcdLoggedIn { get; set; }
        public Nullable<int> tAgentAcdLoggedIn2 { get; set; }
        public Nullable<int> tAgentStatusDnd { get; set; }
        public Nullable<int> tAgentStatusAcw { get; set; }
        public Nullable<int> tAgentLoggedInDiluted { get; set; }
        public Nullable<int> tStatusGroupFollowup { get; set; }
        public Nullable<int> tStatusGroupBreak { get; set; }
        public Nullable<int> tStatusGroupTraining { get; set; }
        public Nullable<int> CustomValue1 { get; set; }
        public Nullable<int> CustomValue2 { get; set; }
        public Nullable<int> CustomValue3 { get; set; }
        public Nullable<int> CustomValue4 { get; set; }
        public Nullable<int> CustomValue5 { get; set; }
        public Nullable<int> CustomValue6 { get; set; }
        public short SiteId { get; set; }
        public int SubSiteId { get; set; }
        public System.DateTime I3TimeStampGMT { get; set; }
        public int DimensionSet { get; set; }
        public Nullable<int> SummDimensionSet { get; set; }
        public int ConfigurationSet { get; set; }
        public int nServiceLevel { get; set; }
        public string cServiceLevels { get; set; }
        public byte SchemaMajorVersion { get; set; }
        public byte SchemaMinorVersion { get; set; }
    }
}
