﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TombLib.Scripting.Resources.Syntaxes {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class NewCommandSyntaxes {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal NewCommandSyntaxes() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("TombLib.Scripting.Resources.Syntaxes.NewCommandSyntaxes", typeof(NewCommandSyntaxes).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Any] #DEFINE {CONSTANT_NAME} {VALUE}.
        /// </summary>
        public static string _DEFINE {
            get {
                return ResourceManager.GetString("#DEFINE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] #FIRST_ID {COMMAND_NAME}={FIRST_ID}.
        /// </summary>
        public static string _FIRST_ID {
            get {
                return ResourceManager.GetString("#FIRST_ID", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Any] #INCLUDE &quot;{FILE_NAME}.TXT&quot;.
        /// </summary>
        public static string _INCLUDE {
            get {
                return ResourceManager.GetString("#INCLUDE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] AddEffect= {ID}, {Effect Type (ADD_...)}, {Effect Flag (FADD_...)}, {Joint Type (JOINT_...)}, {ORIGIN_X_DISTANCE}, {ORIGIN_Y_DISTANCE}, {ORIGIN_Z_DISTANCE}, {EMIT_DURATION}, {PAUSE_DURATION}, {Extra Params (*Array*)}.
        /// </summary>
        public static string AddEffect {
            get {
                return ResourceManager.GetString("AddEffect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] Animation= AnimIndex, (KEY1_...), (KEY2_...), (FAN_...) flags, (ENV_...) Environment, Distance for Env, Extra, StateId (STATE_...) or (-)AnimationIndex (*Array*).
        /// </summary>
        public static string Animation {
            get {
                return ResourceManager.GetString("Animation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] AnimationSlot= Slot, AnimSlotFlags (ASF_...), AnimIndex, (KEY1_...), (KEY2_...), (FAN_...) flags, (ENV_...) Environment, Distance for Env, Extra, StateId (STATE_...) or (-)AnimationIndex (*Array*).
        /// </summary>
        public static string AnimationSlot {
            get {
                return ResourceManager.GetString("AnimationSlot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] AssignSlot= MyUsedSlot, OBJ_Type.
        /// </summary>
        public static string AssignSlot {
            get {
                return ResourceManager.GetString("AssignSlot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] ColorRGB= IdColor, Red, Green, Blue.
        /// </summary>
        public static string ColorRGB {
            get {
                return ResourceManager.GetString("ColorRGB", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] CombineItems= FirstItem (slot), SecondItem (slot), FinalItem (slot).
        /// </summary>
        public static string CombineItems {
            get {
                return ResourceManager.GetString("CombineItems", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Options] CRS= ENABLED / DISABLED.
        /// </summary>
        public static string CRS {
            get {
                return ResourceManager.GetString("CRS", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] Customize= {TYPE (CUST_...)}, {Arguments (*Array*)}.
        /// </summary>
        public static string Customize {
            get {
                return ResourceManager.GetString("Customize", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] CutScene= ENABLED.
        /// </summary>
        public static string CutScene {
            get {
                return ResourceManager.GetString("CutScene", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] Damage= Flags (DMG_...), SecondsForDeath, SecondsForBarRestore, BarColor, BarName, BlinkPercentage.
        /// </summary>
        public static string Damage {
            get {
                return ResourceManager.GetString("Damage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Title] DefaultWindowsFont= IdWindowsFont, FLAGS (DWF_...), LineSpacing, MainMenuOffsets, NewGameTitle, LoadGameTitle, NewGameList, LoadGameList, OptionSettings, OptionCmdList, PauseScreen, StatList, InventoryItemName, ExamineText.
        /// </summary>
        public static string DefaultWindowsFont {
            get {
                return ResourceManager.GetString("DefaultWindowsFont", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] Demo= DemoFlags (DEMF_...), Parameter, InfoText , DemoLegendText, WaitingTime, DemoIndex (*Array*).
        /// </summary>
        public static string Demo {
            get {
                return ResourceManager.GetString("Demo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] Detector= Flags (DTF_...), MetricScale, MetersOfRange, Target Items (*Array*).
        /// </summary>
        public static string Detector {
            get {
                return ResourceManager.GetString("Detector", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Options] Diagnostic= ENABLED / DISABLED.
        /// </summary>
        public static string Diagnostic {
            get {
                return ResourceManager.GetString("Diagnostic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Options] DiagnosticType= DiagnosticType (DGX_...), Extra Dgx flags (EDGX_...).
        /// </summary>
        public static string DiagnosticType {
            get {
                return ResourceManager.GetString("DiagnosticType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] Diary= Id Diary, SlotDiaryItem, LaraDiaryFlags (LDF_...), BackGroundImageID, Default PageLayout (PL_...), FirstString, TitleWFontId, CommonTextWFontId.
        /// </summary>
        public static string Diary {
            get {
                return ResourceManager.GetString("Diary", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] Elevator= ElevatorIndex, ClickFloorDistance, NumberOfFloors, Elevator flags (EF_...), FirstDoorIndex, InnerKeyPadIndex, Speed, Frame items (*Array*).
        /// </summary>
        public static string Elevator {
            get {
                return ResourceManager.GetString("Elevator", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] Enemy= Slot, HP (vitality), (NEF_...) flags, TombFlags (TCF_...), (EXTRA_...) flags, Damage1, Damage2, Damage3.
        /// </summary>
        public static string Enemy {
            get {
                return ResourceManager.GetString("Enemy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] Equipment= SLOT item, Amount.
        /// </summary>
        public static string Equipment {
            get {
                return ResourceManager.GetString("Equipment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] FMV= NumberFmv, EnableEscape.
        /// </summary>
        public static string FMVLevel {
            get {
                return ResourceManager.GetString("FMVLevel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] FogRange= StartLimitDistanceFog, EndLimitDistanceFog.
        /// </summary>
        public static string FogRange {
            get {
                return ResourceManager.GetString("FogRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Options] ForceBumpMapping= ENABLED / DISABLED.
        /// </summary>
        public static string ForceBumpMapping {
            get {
                return ResourceManager.GetString("ForceBumpMapping", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] ForceVolumetricFX= ENABLED / DISABLED.
        /// </summary>
        public static string ForceVolumetricFX {
            get {
                return ResourceManager.GetString("ForceVolumetricFX", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] GlobalTrigger= IdGlobalTrigger, Flags Global Trigger (FGT_...), Global Trigger (GT_...), Parameter, IdConditionTriggerGroup, IdPerformTriggerGroup, IdOnFalseTriggerGroup.
        /// </summary>
        public static string GlobalTrigger {
            get {
                return ResourceManager.GetString("GlobalTrigger", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] Image= IdImageCommand, IdImageFile, ImageFlags (IF_...), EffectTime, AudioTrack, XPosition, YPosition, SizeX, SizeY.
        /// </summary>
        public static string Image {
            get {
                return ResourceManager.GetString("Image", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Options] ImportFile= IdImport, PathFile, FileType (FTYPE_...), ImportType (IMPORT_...).
        /// </summary>
        public static string ImportFile {
            get {
                return ResourceManager.GetString("ImportFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] ItemGroup= IdGroup, FirstIndexItem, {Other indices for items (*Array*)}.
        /// </summary>
        public static string ItemGroup {
            get {
                return ResourceManager.GetString("ItemGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] KeyPad= AtStartAnimation, FrameStartPopUp, AtEndAnimation, ClickSound.
        /// </summary>
        public static string KeyPad {
            get {
                return ResourceManager.GetString("KeyPad", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] LaraStartPos= RoomOfLSP, OcbOfLSP.
        /// </summary>
        public static string LaraStartPos {
            get {
                return ResourceManager.GetString("LaraStartPos", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] LevelFarView= NumberOfBlocks.
        /// </summary>
        public static string LevelFarView {
            get {
                return ResourceManager.GetString("LevelFarView", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Options] LogItem= FlagsLogItem (FLI_...), IndexOfItem.
        /// </summary>
        public static string LogItem {
            get {
                return ResourceManager.GetString("LogItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] MirrorEffect= InFrontRoom, HiddenRoom, MirrorType (MIR_...), {Animating array + (FMIR_...) flags (*Array*)}.
        /// </summary>
        public static string MirrorEffect {
            get {
                return ResourceManager.GetString("MirrorEffect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] MultEnvCondition= IdMultCondition, (ENV_...) condition, DistanceForEnv, Extra field, array of tripled of {(ENV_...) Condition, DistanceForEnv, Extra field}.
        /// </summary>
        public static string MultEnvCondition {
            get {
                return ResourceManager.GetString("MultEnvCondition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Options] NewSoundEngine= ENABLED / DISABLED.
        /// </summary>
        public static string NewSoundEngine {
            get {
                return ResourceManager.GetString("NewSoundEngine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] Organizer= IdOrganizer, Flags Organizer (FO_...), Parameter, FirstTime, PerformFirstIdTriggerGroup, SecondTime, PerformSecondIdTriggerGroup, {Time and TriggerGroup (*Array*)}.
        /// </summary>
        public static string Organizer {
            get {
                return ResourceManager.GetString("Organizer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] Parameters= {TYPE (PARAM_...)}, {PARAM_LIST_ID}, {Parameters (*Array*)}.
        /// </summary>
        public static string Parameters {
            get {
                return ResourceManager.GetString("Parameters", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Options] Plugin= PluginId, PluginName, MainPluginSettings (MPS_...), {DisableFeature (*Array*)}.
        /// </summary>
        public static string Plugin {
            get {
                return ResourceManager.GetString("Plugin", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] PreserveInventory= ENABLED / DISABLED.
        /// </summary>
        public static string PreserveInventory {
            get {
                return ResourceManager.GetString("PreserveInventory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] Rain= (RAIN_...) constant.
        /// </summary>
        public static string Rain {
            get {
                return ResourceManager.GetString("Rain", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] SavegamePanel= SavegamePanelFlags (SPF_...), BackGroundImageId, NumberOfSave, NumberOfVisibleSave, SavegamePanelLayout (SPL_...), InfoFormatString, IdListWindowsFont, IdInfoWindowsFont, InTitleWindowsFont.
        /// </summary>
        public static string SavegamePanel {
            get {
                return ResourceManager.GetString("SavegamePanel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Options] Settings= (SET_...) constants.
        /// </summary>
        public static string Settings {
            get {
                return ResourceManager.GetString("Settings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Options] ShowLaraInTitle= ENABLED / DISABLED.
        /// </summary>
        public static string ShowLaraInTitle {
            get {
                return ResourceManager.GetString("ShowLaraInTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] Snow= (SNOW_...) constant.
        /// </summary>
        public static string Snow {
            get {
                return ResourceManager.GetString("Snow", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Options] SoundSettings= Sound Quality (SQ_...), MusicVolume, SoundEffectVolume.
        /// </summary>
        public static string SoundSettings {
            get {
                return ResourceManager.GetString("SoundSettings", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] StandBy= IdStandBY, Type StandBy (TSB_...), WaitTime, Flags StandBy (FSB_...), Text, NumTexts, AudioTrack, VAngle, RotateSpeed, Distance, IdTriggerGroupBegin, IdTriggerGroupEnd.
        /// </summary>
        public static string StandBy {
            get {
                return ResourceManager.GetString("StandBy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] StaticMIP= MainStaticSlot, BStaticLimit, BStaticSlot, CStaticLimit, CStaticSlot.
        /// </summary>
        public static string StaticMIP {
            get {
                return ResourceManager.GetString("StaticMIP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] Switch= SwitchId, VariablePlaceFolder, FlagsSwitch (SWT_...), {Trigger Group Indices (*Array*)}.
        /// </summary>
        public static string Switch {
            get {
                return ResourceManager.GetString("Switch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] TestPosition= IdTestPosition, Flags (TPOS_...), Slot Moveable, XDistanceMin, XDistanceMax, YDistanceMin, YDistanceMax, ZDistanceMin, ZDistanceMax,  HOrientDiffMin, HOrientDiffMax, VOrientDiffMin, VOrientDiffMax, ROrientDiffMin, ROrientDiffMax.
        /// </summary>
        public static string TestPosition {
            get {
                return ResourceManager.GetString("TestPosition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] TextFormat= Color (CL_...), FormatFlags (FT_...), BlinkTime, SizeCharacterMenu (SC_...).
        /// </summary>
        public static string TextFormat {
            get {
                return ResourceManager.GetString("TextFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] TextureSequence= IdTexSeq, FramePerSec, (SEQ_...) flags, {Tex Indices (*Array*)}.
        /// </summary>
        public static string TextureSequence {
            get {
                return ResourceManager.GetString("TextureSequence", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] TriggerGroup= IdGroup, ExportValue1 + (TGROUP_...) flags, ExportValue2, ExportValue3, {Other Values 1/2/3 of exported triggers or conditions (*Array*)}.
        /// </summary>
        public static string TriggerGroup {
            get {
                return ResourceManager.GetString("TriggerGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] Turbo= Flags (TRB_...), FPStoKeep.
        /// </summary>
        public static string Turbo {
            get {
                return ResourceManager.GetString("Turbo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] WindowsFont= IdWindowFont, WindowFontName, WindowsFontFlags (WFF_...), SizeFont, ColorRbgId, ShadowColorRgbId.
        /// </summary>
        public static string WindowsFont {
            get {
                return ResourceManager.GetString("WindowsFont", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Level] WindowTitle= NameOfCurrentLevel.
        /// </summary>
        public static string WindowTitle {
            get {
                return ResourceManager.GetString("WindowTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [Options] WorldFarView= MaxSectorDistance.
        /// </summary>
        public static string WorldFarView {
            get {
                return ResourceManager.GetString("WorldFarView", resourceCulture);
            }
        }
    }
}
