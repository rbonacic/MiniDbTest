//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiniDbTest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblConsumerHistory
    {
        public int ConsumerHistoryID { get; set; }
        public int ConsumerID { get; set; }
        public Nullable<int> EventID { get; set; }
        public Nullable<byte> bArth { get; set; }
        public Nullable<byte> bAsthma { get; set; }
        public Nullable<byte> bDiabetes { get; set; }
        public Nullable<byte> bHD { get; set; }
        public Nullable<byte> bHighBldPrs { get; set; }
        public Nullable<byte> bTobac { get; set; }
        public Nullable<short> cdPhysEx { get; set; }
        public Nullable<short> cdPap { get; set; }
        public Nullable<short> cdMam { get; set; }
        public Nullable<short> cdPros { get; set; }
        public Nullable<byte> Exer { get; set; }
        public Nullable<short> Sys { get; set; }
        public Nullable<short> Dia { get; set; }
        public Nullable<short> HDL { get; set; }
        public short LDL { get; set; }
        public Nullable<short> Trigl { get; set; }
        public Nullable<short> CholLvl { get; set; }
        public Nullable<double> BodyFat { get; set; }
        public Nullable<short> Glucose { get; set; }
        public Nullable<byte> bGlucoseFasting { get; set; }
        public Nullable<short> WeightInLbs { get; set; }
        public Nullable<short> HeightInInches { get; set; }
        public int DEBatchID { get; set; }
        public Nullable<int> CreatedByID { get; set; }
        public Nullable<int> ModifiedByID { get; set; }
        public Nullable<System.DateTime> CreateDT { get; set; }
        public Nullable<System.DateTime> LastModDt { get; set; }
        public Nullable<byte> bHighBldPrsTreated { get; set; }
        public Nullable<byte> bSeasonalAllergies { get; set; }
        public Nullable<byte> bDepressed { get; set; }
        public Nullable<byte> bLostInterest { get; set; }
        public Nullable<byte> C_bStressed { get; set; }
        public Nullable<byte> Heartburn { get; set; }
        public Nullable<byte> Headaches { get; set; }
        public Nullable<byte> Seatbelts { get; set; }
        public Nullable<double> PSA { get; set; }
        public Nullable<double> Osteo { get; set; }
        public Nullable<byte> bSpanish { get; set; }
        public Nullable<byte> bBPChk { get; set; }
        public Nullable<byte> bCholChk { get; set; }
        public Nullable<byte> DiabetesType { get; set; }
        public Nullable<byte> C_bSpanishPHP { get; set; }
        public Nullable<byte> stress { get; set; }
        public Nullable<byte> bsmokelesstobac { get; set; }
        public Nullable<byte> bglucose { get; set; }
        public Nullable<short> restingpulse { get; set; }
        public Nullable<double> hip { get; set; }
        public Nullable<double> waist { get; set; }
        public Nullable<double> vo2 { get; set; }
        public Nullable<int> C_vo2type { get; set; }
        public Nullable<short> C_diamax { get; set; }
        public Nullable<short> C_sysmax { get; set; }
        public Nullable<short> C_heartratemax { get; set; }
        public Nullable<double> grip { get; set; }
        public Nullable<int> griptypeID { get; set; }
        public Nullable<short> curlup { get; set; }
        public Nullable<int> abstypeID { get; set; }
        public Nullable<short> pushup { get; set; }
        public Nullable<double> flexibility { get; set; }
        public Nullable<int> flexibilitytypeID { get; set; }
        public Nullable<int> cholesterolrange { get; set; }
        public Nullable<int> hdlrange { get; set; }
        public Nullable<int> ldlrange { get; set; }
        public Nullable<int> cholesterolratiorange { get; set; }
        public Nullable<int> triglrange { get; set; }
        public Nullable<int> glucoserange { get; set; }
        public Nullable<int> vo2maxrange { get; set; }
        public Nullable<int> griprange { get; set; }
        public Nullable<int> flexibilityrange { get; set; }
        public Nullable<int> absrange { get; set; }
        public Nullable<int> pushuprange { get; set; }
        public Nullable<int> weightrange { get; set; }
        public Nullable<int> bprange { get; set; }
        public Nullable<int> hbdrange { get; set; }
        public Nullable<int> bodyfatrange { get; set; }
        public Nullable<int> waisttohiprange { get; set; }
        public Nullable<int> psarange { get; set; }
        public Nullable<int> ScanID { get; set; }
        public Nullable<byte> CompletedOnlineSurvey { get; set; }
        public Nullable<int> OriginalScanID { get; set; }
        public Nullable<int> waistcircumferencerange { get; set; }
    }
}