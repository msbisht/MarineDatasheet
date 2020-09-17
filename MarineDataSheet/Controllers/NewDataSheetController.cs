using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;


namespace MarineDataSheet.Controllers
{
    public class NewDataSheetController : Controller
    {
        // GET: NewDataSheet
        MarineDataEntities dbobje = new MarineDataEntities();
        
        private static log4net.ILog Log { get; set; }
        ILog log = log4net.LogManager.GetLogger(typeof(NewDataSheetController));
        public ActionResult Index()
        {
         
            return View();
        }

        [HttpPost]
        public ActionResult Index(Datum model)
        {
            try
            {
                Datum tblobj = new Datum();
                tblobj.Datasivun_numero = model.Datasivun_numero;
                tblobj.STD = model.STD;
                tblobj.Datasivun_numero = "TEST"+ model.Datasivun_numero; 
                tblobj.Datasheet_status = model.Datasheet_status;
                tblobj.Code = model.Code;
                tblobj.Datasheet_created_by = model.Datasheet_created_by;
                tblobj.Model = model.Model;
                tblobj.Maximum_working_pressure_barg = model.Maximum_working_pressure_barg;
                tblobj.Cooling = model.Cooling;
                tblobj.C1_Voltage = model.C1_Voltage;
                tblobj.C1_Frequency = model.C1_Frequency;
                tblobj.C1_Starting_type = model.C1_Starting_type;
                tblobj.C2_Voltage = model.C2_Voltage;
                tblobj.C2_Frequency = model.C2_Frequency;
                tblobj.C2_Starting_type = model.C2_Starting_type;
                tblobj.Normal_working_pressure_barg = model.Normal_working_pressure_barg;
                tblobj.Capacity_at_normal_working_pressure_m_min = model.Capacity_at_normal_working_pressure_m_min;
                tblobj.Capacity_at_normal_working_pressure_m_min_75 = model.Capacity_at_normal_working_pressure_m_min_75;
                tblobj.Capacity_at_normal_working_pressure_m_min_50 = model.Capacity_at_normal_working_pressure_m_min_50;
                tblobj.Capacity_at_normal_working_pressure_m_min_25 = model.Capacity_at_normal_working_pressure_m_min_25;
                tblobj.Capacity_at_normal_working_pressure_m_min_min = model.Capacity_at_normal_working_pressure_m_min_min;
                tblobj.Volumetric_efficiency = model.Volumetric_efficiency; 
                tblobj.Air_end_volume_per_revolution = model.Air_end_volume_per_revolution;
                tblobj.Shaft_power_at_normal_working_pressure_kW = model.Shaft_power_at_normal_working_pressure_kW;
                tblobj.Shaft_power_at_normal_working_pressure_kW_75 = model.Shaft_power_at_normal_working_pressure_kW_75;
                tblobj.Shaft_power_at_normal_working_pressure_kW_50 = model.Shaft_power_at_normal_working_pressure_kW_50;
                tblobj.Shaft_power_at_normal_working_pressure_kW_25 = model.Shaft_power_at_normal_working_pressure_kW_25;
                tblobj.Shaft_power_at_normal_working_pressure_kW_min = model.Shaft_power_at_normal_working_pressure_kW_min;
                tblobj.Specific_power_consumption_kW_m_min = model.Specific_power_consumption_kW_m_min;
                tblobj.Extra_capacity = model.Extra_capacity;
                tblobj.Minimum_working_pressure_barg = model.Minimum_working_pressure_barg;
                tblobj.Frequency_min = model.Frequency_min;
                tblobj.Frequency_max = model.Frequency_max;
                tblobj.Transmission = model.Transmission;
                tblobj.Transmission_Gear_i = model.Transmission_Gear_i;
                tblobj.Motor_pulley = model.Motor_pulley;
                tblobj.Air_end_pulley = model.Air_end_pulley;
                tblobj.Maximum_ambient_temperature_C = model.Maximum_ambient_temperature_C;
                tblobj.Compressed_air_temperature_above_cooling_medium_temperature_C = model.Compressed_air_temperature_above_cooling_medium_temperature_C;
                tblobj.Cooling_air_flow_m_s = model.Cooling_air_flow_m_s;
                tblobj.Cooling_air_flow_m_s_water_cooled = model.Cooling_air_flow_m_s_water_cooled;
                tblobj.Maximum_cooling_air_pressure_drop__Pa_ = model.Maximum_cooling_air_pressure_drop__Pa_;
                tblobj.Water_in_C_Fresh_water_cooled = model.Water_in_C_Fresh_water_cooled;
                //tblobj.Water_out__C____Fresh_water_cooled = model.Water_out__C____Fresh_water_cooled;
                //tblobj.Water_in__C____Sea_water_cooled = model.Water_in__C____Sea_water_cooled;
                //tblobj.Water_out__C____Sea_water_cooled = model.Water_out__C____Sea_water_cooled;
                //tblobj.Extra_factor_for_water_flow_at_60__humidity_fresh = model.Extra_factor_for_water_flow_at_60__humidity_fresh;
                //tblobj.Minimum_water_inlet_pressure_with_zero_back__bar___MPa___Serial_ = model.Minimum_water_inlet_pressure_with_zero_back__bar___MPa___Serial_;
                //tblobj.Minimum_water_inlet_pressure_with_zero_ba__bar___MPa___Parallel_ = model.Minimum_water_inlet_pressure_with_zero_ba__bar___MPa___Parallel_;
                //tblobj.Minimum_water_inlet_pressure_with_zero_back__Serial__sea = model.Minimum_water_inlet_pressure_with_zero_back__Serial__sea;
                //tblobj.Minimum_water_inlet_pressure_with_zero_back__Parallel__sea = model.Minimum_water_inlet_pressure_with_zero_back__Parallel__sea;
                //tblobj.Minimum_water_inlet_pressure_with_zero_back__bar___MPa__Oil = model.Minimum_water_inlet_pressure_with_zero_back__bar___MPa__Oil;
                //tblobj.Minimum_water_inlet_pressure_with_zero_back__bar___MPa__After = model.Minimum_water_inlet_pressure_with_zero_back__bar___MPa__After;
                //tblobj.Maximum_inlet_pressure__barg_ = model.Maximum_inlet_pressure__barg_;
                //tblobj.Water_in___out_T2___T3 = model.Water_in___out_T2___T3;
                //tblobj.Heat_dissipation__kW__EA = model.Heat_dissipation__kW__EA;
                //tblobj.Heat_dissipation__kW__EW = model.Heat_dissipation__kW__EW;
                //tblobj.Main_motor___F_class__IP_55__kW_ = model.Main_motor_max_power;
                //tblobj.Main_motor_protection_details = model.Main_motor_protection_details;
                //tblobj.Main_motor_temperature_rise = model.Main_motor_temperature_rise;
                //tblobj.Speed_of_rotation__rpm_ = model.Speed_of_rotation__rpm_;
                //tblobj.Speed_of_rotation__rpm__min = model.Speed_of_rotation__rpm__min;
                //tblobj.Motor_cos_fii = model.Motor_cos_fii;
                //tblobj.Motor_efficiency = model.Motor_efficiency;
                //tblobj.Fan_motor__kW__EA = model.Fan_motor__kW__EA;
                //tblobj.Fan_motor__kW__EW = model.Fan_motor__kW__EW;
                //tblobj.Speed_of_rotation__rpm____fan_motor = model.Speed_of_rotation__rpm____fan_motor;
                //tblobj.Voltage_tolerance = model.Voltage_tolerance;
                //tblobj.Hydraulic_main_motor = model.Hydraulic_main_motor;
                //tblobj.Hydraulic_motor_speed_of_rotation__Max_ = model.Hydraulic_motor_speed_of_rotation__Max_;
                //tblobj.Hydraulic_motor_speed_of_rotation__Min_ = model.Hydraulic_motor_speed_of_rotation__Min_;
                //tblobj.Hydraulic_oil_flow__l_min_ = model.Hydraulic_oil_flow__l_min_;
                //tblobj.Hydraulic_oil_flow__l_min__min = model.Hydraulic_oil_flow__l_min__min;
                //tblobj.Hydraulic_oil_pressure__bar_ = model.Hydraulic_oil_pressure__bar_;
                //tblobj.Hydraulic_oil_pressure__bar__min = model.Hydraulic_oil_pressure__bar__min;
                //tblobj.Fuse__max___1_Jännite__A = model.Fuse__max___1_Jännite__A;
                //tblobj.Fuse__max___2_Jännite__A = model.Fuse__max___2_Jännite__A;
                //tblobj.Starting_current_Ia_In_DOL___Y_D___SOFT_START = model.Starting_current_Ia_In_DOL___Y_D___SOFT_START;
                //tblobj.Control_voltage__V_ = model.Control_voltage__V_;
                //tblobj.Oil_quantity__I_ = model.Oil_quantity__I_;
                //tblobj.Oil_quantity_EA__I_ = model.Oil_quantity_EA__I_;
                //tblobj.Oil_content__mg_m__ = model.Oil_content__mg_m__;
                tblobj.Air_outlet_T1 = model.Air_outlet_T1;
                tblobj.Air_outlet_T1_water_cooled = model.Air_outlet_T1_water_cooled;
                tblobj.Condensate_drain_T4 = model.Condensate_drain_T4;
                //tblobj.Pressure_Level__LpA__without_canopy_EA = model.Pressure_Level__LpA__without_canopy_EA;
                //tblobj.Pressure_Level__LpA__without_canopy_EW = model.Pressure_Level__LpA__without_canopy_EW;
                //tblobj.Pressure_Level__LpA__with_NOVOX_canopy_EA = model.Pressure_Level__LpA__with_NOVOX_canopy_EA;
                //tblobj.Pressure_Level__LpA__with_NOVOX_canopy_EW = model.Pressure_Level__LpA__with_NOVOX_canopy_EW;
                //tblobj.Uncertainty_Kpa___Kwa = model.Uncertainty_Kpa___Kwa;
                tblobj.Weight_without_canopy = model.Weight_without_canopy;
                tblobj.Weight_with_NOVOX_canopy = model.Weight_with_NOVOX_canopy;
                tblobj.Weight_with_NOVOX_canopy_EA = model.Weight_with_NOVOX_canopy_EA;
                tblobj.General_arrangement_drawing_SW = model.General_arrangement_drawing_SW;
                tblobj.General_arrangement_drawing_FW = model.General_arrangement_drawing_FW;
                tblobj.General_arrangement_drawing_EA = model.General_arrangement_drawing_EA;
                tblobj.General_arrangement_drawing_with_NOVOX_canopy_EA = model.General_arrangement_drawing_with_NOVOX_canopy_EA;
                tblobj.General_arrangement_drawing_with_NOVOX_canopy_EW = model.General_arrangement_drawing_with_NOVOX_canopy_EW;
                tblobj.General_arrangement_drawing_with_NOVOX_canopy_EW_SW = model.General_arrangement_drawing_with_NOVOX_canopy_EW_SW;
                tblobj.Cable_gland__Power = model.Cable_gland__Power;
                //tblobj.Cable_gland__Alarm___Signal = model.Cable_gland__Alarm___Signal;
                tblobj.Lisätietoja = model.Lisätietoja;
                tblobj.Suunnittelun_kommentit = model.Suunnittelun_kommentit;
                

                dbobje.Data.Add(tblobj);
                dbobje.SaveChanges();
            }
            catch (Exception ex)
            {
                log.Info(ex.StackTrace.ToString());
                throw;
            }
           
            return View();
        }
    }
}