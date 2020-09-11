using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarineDataSheet.Models
{
   

    public partial class Datasheet
    {
        public int Laskuri { get; set; }
        public bool STD { get; set; }
        public string Datasivun_numero { get; set; }
        public string Datasheet_revision { get; set; }
        public System.DateTime Valid_from { get; set; }
        public string Datasheet_status { get; set; }
        public string Code { get; set; }
        public string Datasheet_created_by { get; set; }
        public string Model { get; set; }
        public Nullable<double> Maximum_working_pressure__barg_ { get; set; }
        public string Cooling { get; set; }
        public string C1_Voltage { get; set; }
        public string C1_Frequency { get; set; }
        public string C1_Starting_type { get; set; }
        public string C2_Voltage { get; set; }
        public string C2_Frequency { get; set; }
        public string C2_Starting_type { get; set; }
        public Nullable<double> Normal_working_pressure__barg_ { get; set; }
        public Nullable<double> Capacity_at_normal_working_pressure__m__min_ { get; set; }
        public Nullable<double> Capacity_at_normal_working_pressure__m__min__75_ { get; set; }
        public Nullable<double> Capacity_at_normal_working_pressure__m__min__50_ { get; set; }
        public Nullable<double> Capacity_at_normal_working_pressure__m__min__25_ { get; set; }
        public Nullable<double> Capacity_at_normal_working_pressure__m__min__min { get; set; }
        public string Volumetric_efficiency__ { get; set; }
        public string Air_end_volume_per_revolution { get; set; }
        public Nullable<double> Shaft_power_at_normal_working_pressure__kW_ { get; set; }
        public Nullable<double> Shaft_power_at_normal_working_pressure__kW__75_ { get; set; }
        public Nullable<double> Shaft_power_at_normal_working_pressure__kW__50_ { get; set; }
        public Nullable<double> Shaft_power_at_normal_working_pressure__kW__25_ { get; set; }
        public Nullable<double> Shaft_power_at_normal_working_pressure__kW__min { get; set; }
        public string Specific_power_consumption__kW_m3_min_ { get; set; }
        public string Extra_capacity__ { get; set; }
        public Nullable<double> Minimum_working_pressure__barg_ { get; set; }
        public string Frequency_min { get; set; }
        public string Frequency_max { get; set; }
        public string Transmission_ { get; set; }
        public Nullable<double> Transmission__Gear__i_ { get; set; }
        public Nullable<int> Motor_pulley_ { get; set; }
        public Nullable<int> Air_end_pulley_ { get; set; }
        public Nullable<double> Maximum_ambient_temperature__C__ { get; set; }
        public Nullable<double> Compressed_air_temperature_above_cooling_medium_temperature__C__ { get; set; }
        public Nullable<double> Cooling_air_flow__m__s_ { get; set; }
        public Nullable<double> Cooling_air_flow__m__s__water_cooled { get; set; }
        public Nullable<double> Maximum_cooling_air_pressure_drop__Pa_ { get; set; }
        public Nullable<double> Water_in__C____Fresh_water_cooled { get; set; }
        public Nullable<double> Water_out__C____Fresh_water_cooled { get; set; }
        public Nullable<double> Water_in__C____Sea_water_cooled { get; set; }
        public Nullable<double> Water_out__C____Sea_water_cooled { get; set; }
        public string Extra_factor_for_water_flow_at_60__humidity_fresh { get; set; }
        public Nullable<double> Minimum_water_inlet_pressure_with_zero_back__bar___MPa___Serial_ { get; set; }
        public Nullable<double> Minimum_water_inlet_pressure_with_zero_ba__bar___MPa___Parallel_ { get; set; }
        public Nullable<double> Minimum_water_inlet_pressure_with_zero_back__Serial__sea { get; set; }
        public Nullable<double> Minimum_water_inlet_pressure_with_zero_back__Parallel__sea { get; set; }
        public Nullable<double> Minimum_water_inlet_pressure_with_zero_back__bar___MPa__Oil { get; set; }
        public Nullable<double> Minimum_water_inlet_pressure_with_zero_back__bar___MPa__After { get; set; }
        public Nullable<double> Maximum_inlet_pressure__barg_ { get; set; }
        public string Water_in___out_T2___T3 { get; set; }
        public string Heat_dissipation__kW__EA { get; set; }
        public string Heat_dissipation__kW__EW { get; set; }
        public Nullable<double> Main_motor___F_class__IP_55__kW_ { get; set; }
        public Nullable<double> Main_motor_max_power { get; set; }
        public string Main_motor_protection_details { get; set; }
        public string Main_motor_temperature_rise { get; set; }
        public Nullable<double> Speed_of_rotation__rpm_ { get; set; }
        public Nullable<double> Speed_of_rotation__rpm__min { get; set; }
        public Nullable<double> Motor_cos_fii { get; set; }
        public Nullable<double> Motor_efficiency { get; set; }
        public Nullable<double> Fan_motor__kW__EA { get; set; }
        public Nullable<double> Fan_motor__kW__EW { get; set; }
        public string Speed_of_rotation__rpm____fan_motor { get; set; }
        public string Voltage_tolerance { get; set; }
        public string Hydraulic_main_motor { get; set; }
        public string Hydraulic_motor_speed_of_rotation__Max_ { get; set; }
        public string Hydraulic_motor_speed_of_rotation__Min_ { get; set; }
        public string Hydraulic_oil_flow__l_min_ { get; set; }
        public string Hydraulic_oil_flow__l_min__min { get; set; }
        public string Hydraulic_oil_pressure__bar_ { get; set; }
        public string Hydraulic_oil_pressure__bar__min { get; set; }
        public string Fuse__max___1_Jännite__A { get; set; }
        public string Fuse__max___2_Jännite__A { get; set; }
        public string Starting_current_Ia_In_DOL___Y_D___SOFT_START { get; set; }
        public string Control_voltage__V_ { get; set; }
        public Nullable<double> Oil_quantity__I_ { get; set; }
        public Nullable<double> Oil_quantity_EA__I_ { get; set; }
        public Nullable<double> Oil_content__mg_m__ { get; set; }
        public string Air_outlet_T1 { get; set; }
        public string Air_outlet_T1_water_cooled { get; set; }
        public string Condensate_drain_T4 { get; set; }
        public string Pressure_Level__LpA__without_canopy_EA { get; set; }
        public string Pressure_Level__LpA__without_canopy_EW { get; set; }
        public string Pressure_Level__LpA__with_NOVOX_canopy_EA { get; set; }
        public string Pressure_Level__LpA__with_NOVOX_canopy_EW { get; set; }
        public string Uncertainty_Kpa___Kwa { get; set; }
        public string Weight_without_canopy { get; set; }
        public string Weight_with_NOVOX_canopy { get; set; }
        public string Weight_with_NOVOX_canopy_EA { get; set; }
        public string General_arrangement_drawing_SW { get; set; }
        public string General_arrangement_drawing_FW { get; set; }
        public string General_arrangement_drawing_EA { get; set; }
        public string General_arrangement_drawing_with_NOVOX_canopy_EA { get; set; }
        public string General_arrangement_drawing_with_NOVOX_canopy_EW { get; set; }
        public string General_arrangement_drawing_with_NOVOX_canopy_EW_SW { get; set; }
        public string Cable_gland__Power { get; set; }
        public string Cable_gland__Alarm___Signal { get; set; }
        public string Lisätietoja { get; set; }
        public string Suunnittelun_kommentit { get; set; }
    }
}