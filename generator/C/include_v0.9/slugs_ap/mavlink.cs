using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace ArdupilotMega
{
    #if MAVLINK10
    partial class MAVLink
    {
        public const string MAVLINK_BUILD_DATE = "Fri Apr  6 21:10:58 2012";
        public const string MAVLINK_WIRE_PROTOCOL_VERSION = "0.9";
        public const int MAVLINK_MAX_DIALECT_PAYLOAD_SIZE = 36;

        public const int MAVLINK_LITTLE_ENDIAN = 1;
        public const int MAVLINK_BIG_ENDIAN = 0;

        public const byte MAVLINK_STX = 85;

        public const byte MAVLINK_ENDIAN = MAVLINK_BIG_ENDIAN;

        public const bool MAVLINK_ALIGNED_FIELDS = (0 == 1);

        public const byte MAVLINK_CRC_EXTRA = 0;
        
        public const bool MAVLINK_NEED_BYTE_SWAP = (MAVLINK_ENDIAN == MAVLINK_LITTLE_ENDIAN);
        
        public byte[] MAVLINK_MESSAGE_LENGTHS = new byte[] {2, 4, 8, 14, 0, 0, 0, 0, 0, 0, 3, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 101, 26, 16, 32, 32, 37, 0, 8, 0, 0, 0, 0, 36, 4, 4, 2, 0, 4, 2, 2, 3, 34, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 10, 24, 18, 10, 20, 30, 24, 36, 7, 13, 3, 14, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 51, 5};

        public byte[] MAVLINK_MESSAGE_CRCS = new byte[] {115, 39, 190, 92, 0, 0, 0, 0, 0, 0, 60, 186, 10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 110, 179, 136, 66, 126, 185, 0, 146, 0, 0, 0, 0, 171, 9, 106, 101, 0, 4, 229, 21, 214, 147, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 219, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 150, 232, 168, 2, 51, 24, 120, 167, 135, 16, 2, 52, 233, 202, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 106, 7};

        public Type[] MAVLINK_MESSAGE_INFO = new Type[] {typeof( mavlink_heartbeat_t ), typeof( mavlink_boot_t ), typeof( mavlink_system_time_t ), typeof( mavlink_ping_t ), null, null, null, null, null, null, typeof( mavlink_action_t ), typeof( mavlink_set_mode_t ), typeof( mavlink_set_nav_mode_t ), null, null, null, null, null, null, null, null, null, null, null, null, null, null, typeof( mavlink_gps_status_t ), typeof( mavlink_raw_imu_t ), typeof( mavlink_raw_pressure_t ), typeof( mavlink_attitude_t ), typeof( mavlink_local_position_t ), typeof( mavlink_gps_raw_t ), null, typeof( mavlink_sys_status_t ), null, null, null, null, typeof( mavlink_waypoint_t ), typeof( mavlink_waypoint_request_t ), typeof( mavlink_waypoint_set_current_t ), typeof( mavlink_waypoint_current_t ), null, typeof( mavlink_waypoint_count_t ), typeof( mavlink_waypoint_clear_all_t ), typeof( mavlink_waypoint_reached_t ), typeof( mavlink_waypoint_ack_t ), typeof( mavlink_waypoint_set_global_reference_t ), null, null, null, null, null, null, null, null, null, null, null, null, null, typeof( mavlink_action_ack_t ), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, typeof( mavlink_cpu_load_t ), typeof( mavlink_air_data_t ), typeof( mavlink_sensor_bias_t ), typeof( mavlink_diagnostic_t ), typeof( mavlink_pilot_console_t ), typeof( mavlink_pwm_commands_t ), typeof( mavlink_slugs_navigation_t ), typeof( mavlink_data_log_t ), typeof( mavlink_filtered_data_t ), typeof( mavlink_gps_date_time_t ), typeof( mavlink_mid_lvl_cmds_t ), typeof( mavlink_ctrl_srfc_pt_t ), typeof( mavlink_pid_t ), typeof( mavlink_slugs_action_t ), null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, typeof( mavlink_statustext_t ), typeof( mavlink_debug_t )};

        public const byte MAVLINK_VERSION = 2;
    
        
    
        

    public const byte MAVLINK_MSG_ID_CPU_LOAD = 170;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=4)]
    public struct mavlink_cpu_load_t
    {
        /// <summary> Sensor DSC Load </summary>
        public  byte sensLoad;
            /// <summary> Control DSC Load </summary>
        public  byte ctrlLoad;
            /// <summary> Battery Voltage in millivolts </summary>
        public  UInt16 batVolt;
    
    };


    public const byte MAVLINK_MSG_ID_AIR_DATA = 171;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=10)]
    public struct mavlink_air_data_t
    {
        /// <summary> Dynamic pressure (Pa) </summary>
        public  Single dynamicPressure;
            /// <summary> Static pressure (Pa) </summary>
        public  Single staticPressure;
            /// <summary> Board temperature </summary>
        public  UInt16 temperature;
    
    };


    public const byte MAVLINK_MSG_ID_SENSOR_BIAS = 172;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=24)]
    public struct mavlink_sensor_bias_t
    {
        /// <summary> Accelerometer X bias (m/s) </summary>
        public  Single axBias;
            /// <summary> Accelerometer Y bias (m/s) </summary>
        public  Single ayBias;
            /// <summary> Accelerometer Z bias (m/s) </summary>
        public  Single azBias;
            /// <summary> Gyro X bias (rad/s) </summary>
        public  Single gxBias;
            /// <summary> Gyro Y bias (rad/s) </summary>
        public  Single gyBias;
            /// <summary> Gyro Z bias (rad/s) </summary>
        public  Single gzBias;
    
    };


    public const byte MAVLINK_MSG_ID_DIAGNOSTIC = 173;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=18)]
    public struct mavlink_diagnostic_t
    {
        /// <summary> Diagnostic float 1 </summary>
        public  Single diagFl1;
            /// <summary> Diagnostic float 2 </summary>
        public  Single diagFl2;
            /// <summary> Diagnostic float 3 </summary>
        public  Single diagFl3;
            /// <summary> Diagnostic short 1 </summary>
        public  Int16 diagSh1;
            /// <summary> Diagnostic short 2 </summary>
        public  Int16 diagSh2;
            /// <summary> Diagnostic short 3 </summary>
        public  Int16 diagSh3;
    
    };


    public const byte MAVLINK_MSG_ID_PILOT_CONSOLE = 174;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=10)]
    public struct mavlink_pilot_console_t
    {
        /// <summary> Pilot's console throttle command  </summary>
        public  UInt16 dt;
            /// <summary> Pilot's console left aileron command  </summary>
        public  UInt16 dla;
            /// <summary> Pilot's console right aileron command  </summary>
        public  UInt16 dra;
            /// <summary> Pilot's console rudder command  </summary>
        public  UInt16 dr;
            /// <summary> Pilot's console elevator command  </summary>
        public  UInt16 de;
    
    };


    public const byte MAVLINK_MSG_ID_PWM_COMMANDS = 175;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=20)]
    public struct mavlink_pwm_commands_t
    {
        /// <summary> AutoPilot's throttle command  </summary>
        public  UInt16 dt_c;
            /// <summary> AutoPilot's left aileron command  </summary>
        public  UInt16 dla_c;
            /// <summary> AutoPilot's right aileron command  </summary>
        public  UInt16 dra_c;
            /// <summary> AutoPilot's rudder command  </summary>
        public  UInt16 dr_c;
            /// <summary> AutoPilot's left elevator command  </summary>
        public  UInt16 dle_c;
            /// <summary> AutoPilot's right elevator command  </summary>
        public  UInt16 dre_c;
            /// <summary> AutoPilot's left  flap command  </summary>
        public  UInt16 dlf_c;
            /// <summary> AutoPilot's right flap command  </summary>
        public  UInt16 drf_c;
            /// <summary> AutoPilot's aux1 command  </summary>
        public  UInt16 aux1;
            /// <summary> AutoPilot's aux2 command  </summary>
        public  UInt16 aux2;
    
    };


    public const byte MAVLINK_MSG_ID_SLUGS_NAVIGATION = 176;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=30)]
    public struct mavlink_slugs_navigation_t
    {
        /// <summary> Measured Airspeed prior to the Nav Filter </summary>
        public  Single u_m;
            /// <summary> Commanded Roll </summary>
        public  Single phi_c;
            /// <summary> Commanded Pitch </summary>
        public  Single theta_c;
            /// <summary> Commanded Turn rate </summary>
        public  Single psiDot_c;
            /// <summary> Y component of the body acceleration </summary>
        public  Single ay_body;
            /// <summary> Total Distance to Run on this leg of Navigation </summary>
        public  Single totalDist;
            /// <summary> Remaining distance to Run on this leg of Navigation </summary>
        public  Single dist2Go;
            /// <summary> Origin WP </summary>
        public  byte fromWP;
            /// <summary> Destination WP </summary>
        public  byte toWP;
    
    };


    public const byte MAVLINK_MSG_ID_DATA_LOG = 177;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=24)]
    public struct mavlink_data_log_t
    {
        /// <summary> Log value 1  </summary>
        public  Single fl_1;
            /// <summary> Log value 2  </summary>
        public  Single fl_2;
            /// <summary> Log value 3  </summary>
        public  Single fl_3;
            /// <summary> Log value 4  </summary>
        public  Single fl_4;
            /// <summary> Log value 5  </summary>
        public  Single fl_5;
            /// <summary> Log value 6  </summary>
        public  Single fl_6;
    
    };


    public const byte MAVLINK_MSG_ID_FILTERED_DATA = 178;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=36)]
    public struct mavlink_filtered_data_t
    {
        /// <summary> Accelerometer X value (m/s^2)  </summary>
        public  Single aX;
            /// <summary> Accelerometer Y value (m/s^2) </summary>
        public  Single aY;
            /// <summary> Accelerometer Z value (m/s^2) </summary>
        public  Single aZ;
            /// <summary> Gyro X value (rad/s)  </summary>
        public  Single gX;
            /// <summary> Gyro Y value (rad/s) </summary>
        public  Single gY;
            /// <summary> Gyro Z value (rad/s) </summary>
        public  Single gZ;
            /// <summary> Magnetometer X (normalized to 1)  </summary>
        public  Single mX;
            /// <summary> Magnetometer Y (normalized to 1)  </summary>
        public  Single mY;
            /// <summary> Magnetometer Z (normalized to 1)  </summary>
        public  Single mZ;
    
    };


    public const byte MAVLINK_MSG_ID_GPS_DATE_TIME = 179;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=7)]
    public struct mavlink_gps_date_time_t
    {
        /// <summary> Year reported by Gps  </summary>
        public  byte year;
            /// <summary> Month reported by Gps  </summary>
        public  byte month;
            /// <summary> Day reported by Gps  </summary>
        public  byte day;
            /// <summary> Hour reported by Gps  </summary>
        public  byte hour;
            /// <summary> Min reported by Gps  </summary>
        public  byte min;
            /// <summary> Sec reported by Gps   </summary>
        public  byte sec;
            /// <summary> Visible sattelites reported by Gps   </summary>
        public  byte visSat;
    
    };


    public const byte MAVLINK_MSG_ID_MID_LVL_CMDS = 180;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=13)]
    public struct mavlink_mid_lvl_cmds_t
    {
        /// <summary> The system setting the commands </summary>
        public  byte target;
            /// <summary> Commanded Airspeed </summary>
        public  Single hCommand;
            /// <summary> Log value 2  </summary>
        public  Single uCommand;
            /// <summary> Log value 3  </summary>
        public  Single rCommand;
    
    };


    public const byte MAVLINK_MSG_ID_CTRL_SRFC_PT = 181;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=3)]
    public struct mavlink_ctrl_srfc_pt_t
    {
        /// <summary> The system setting the commands </summary>
        public  byte target;
            /// <summary> Bitfield containing the PT configuration </summary>
        public  UInt16 bitfieldPt;
    
    };


    public const byte MAVLINK_MSG_ID_PID = 182;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=14)]
    public struct mavlink_pid_t
    {
        /// <summary> The system setting the PID values </summary>
        public  byte target;
            /// <summary> Proportional gain </summary>
        public  Single pVal;
            /// <summary> Integral gain </summary>
        public  Single iVal;
            /// <summary> Derivative gain </summary>
        public  Single dVal;
            /// <summary> PID loop index </summary>
        public  byte idx;
    
    };


    public const byte MAVLINK_MSG_ID_SLUGS_ACTION = 183;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=4)]
    public struct mavlink_slugs_action_t
    {
        /// <summary> The system reporting the action </summary>
        public  byte target;
            /// <summary> Action ID. See apDefinitions.h in the SLUGS /clib directory for the ID names </summary>
        public  byte actionId;
            /// <summary> Value associated with the action </summary>
        public  UInt16 actionVal;
    
    };


    public const byte MAVLINK_MSG_ID_HEARTBEAT = 0;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=2)]
    public struct mavlink_heartbeat_t
    {
        /// <summary> Type of the MAV (quadrotor, helicopter, etc., up to 15 types, defined in MAV_TYPE ENUM) </summary>
        public  byte type;
            /// <summary> Type of the Autopilot: 0: Generic, 1: PIXHAWK, 2: SLUGS, 3: Ardupilot (up to 15 types), defined in MAV_AUTOPILOT_TYPE ENUM </summary>
        public  byte autopilot;
    
    };


    public const byte MAVLINK_MSG_ID_BOOT = 1;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=4)]
    public struct mavlink_boot_t
    {
        /// <summary> The onboard software version </summary>
        public  UInt32 version;
    
    };


    public const byte MAVLINK_MSG_ID_SYSTEM_TIME = 2;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=8)]
    public struct mavlink_system_time_t
    {
        /// <summary> Timestamp of the master clock in microseconds since UNIX epoch. </summary>
        public  UInt64 time_usec;
    
    };


    public const byte MAVLINK_MSG_ID_PING = 3;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=14)]
    public struct mavlink_ping_t
    {
        /// <summary> PING sequence </summary>
        public  UInt32 seq;
            /// <summary> 0: request ping from all receiving systems, if greater than 0: message is a ping response and number is the system id of the requesting system </summary>
        public  byte target_system;
            /// <summary> 0: request ping from all receiving components, if greater than 0: message is a ping response and number is the system id of the requesting system </summary>
        public  byte target_component;
            /// <summary> Unix timestamp in microseconds </summary>
        public  UInt64 time;
    
    };


    public const byte MAVLINK_MSG_ID_ACTION = 10;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=3)]
    public struct mavlink_action_t
    {
        /// <summary> The system executing the action </summary>
        public  byte target;
            /// <summary> The component executing the action </summary>
        public  byte target_component;
            /// <summary> The action id </summary>
        public  byte action;
    
    };


    public const byte MAVLINK_MSG_ID_ACTION_ACK = 62;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=2)]
    public struct mavlink_action_ack_t
    {
        /// <summary> The action id </summary>
        public  byte action;
            /// <summary> 0: Action DENIED, 1: Action executed </summary>
        public  byte result;
    
    };


    public const byte MAVLINK_MSG_ID_SET_MODE = 11;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=2)]
    public struct mavlink_set_mode_t
    {
        /// <summary> The system setting the mode </summary>
        public  byte target;
            /// <summary> The new mode </summary>
        public  byte mode;
    
    };


    public const byte MAVLINK_MSG_ID_SET_NAV_MODE = 12;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=2)]
    public struct mavlink_set_nav_mode_t
    {
        /// <summary> The system setting the mode </summary>
        public  byte target;
            /// <summary> The new navigation mode </summary>
        public  byte nav_mode;
    
    };


    public const byte MAVLINK_MSG_ID_RAW_IMU = 28;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=26)]
    public struct mavlink_raw_imu_t
    {
        /// <summary> Timestamp (microseconds since UNIX epoch) </summary>
        public  UInt64 usec;
            /// <summary> X acceleration (mg raw) </summary>
        public  Int16 xacc;
            /// <summary> Y acceleration (mg raw) </summary>
        public  Int16 yacc;
            /// <summary> Z acceleration (mg raw) </summary>
        public  Int16 zacc;
            /// <summary> Angular speed around X axis (adc units) </summary>
        public  Int16 xgyro;
            /// <summary> Angular speed around Y axis (adc units) </summary>
        public  Int16 ygyro;
            /// <summary> Angular speed around Z axis (adc units) </summary>
        public  Int16 zgyro;
            /// <summary> X Magnetic field (milli tesla) </summary>
        public  Int16 xmag;
            /// <summary> Y Magnetic field (milli tesla) </summary>
        public  Int16 ymag;
            /// <summary> Z Magnetic field (milli tesla) </summary>
        public  Int16 zmag;
    
    };


    public const byte MAVLINK_MSG_ID_RAW_PRESSURE = 29;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=16)]
    public struct mavlink_raw_pressure_t
    {
        /// <summary> Timestamp (microseconds since UNIX epoch) </summary>
        public  UInt64 usec;
            /// <summary> Absolute pressure (hectopascal) </summary>
        public  Int16 press_abs;
            /// <summary> Differential pressure 1 (hectopascal) </summary>
        public  Int16 press_diff1;
            /// <summary> Differential pressure 2 (hectopascal) </summary>
        public  Int16 press_diff2;
            /// <summary> Raw Temperature measurement  </summary>
        public  Int16 temperature;
    
    };


    public const byte MAVLINK_MSG_ID_ATTITUDE = 30;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=32)]
    public struct mavlink_attitude_t
    {
        /// <summary> Timestamp (microseconds) </summary>
        public  UInt64 usec;
            /// <summary> Roll angle (rad) </summary>
        public  Single roll;
            /// <summary> Pitch angle (rad) </summary>
        public  Single pitch;
            /// <summary> Yaw angle (rad) </summary>
        public  Single yaw;
            /// <summary> Roll angular speed (rad/s) </summary>
        public  Single rollspeed;
            /// <summary> Pitch angular speed (rad/s) </summary>
        public  Single pitchspeed;
            /// <summary> Yaw angular speed (rad/s) </summary>
        public  Single yawspeed;
    
    };


    public const byte MAVLINK_MSG_ID_LOCAL_POSITION = 31;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=32)]
    public struct mavlink_local_position_t
    {
        /// <summary> Timestamp (microseconds since unix epoch) </summary>
        public  UInt64 usec;
            /// <summary> X Position </summary>
        public  Single x;
            /// <summary> Y Position </summary>
        public  Single y;
            /// <summary> Z Position </summary>
        public  Single z;
            /// <summary> X Speed </summary>
        public  Single vx;
            /// <summary> Y Speed </summary>
        public  Single vy;
            /// <summary> Z Speed </summary>
        public  Single vz;
    
    };


    public const byte MAVLINK_MSG_ID_GPS_RAW = 32;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=37)]
    public struct mavlink_gps_raw_t
    {
        /// <summary> Timestamp (microseconds since unix epoch) </summary>
        public  UInt64 usec;
            /// <summary> 0-1: no fix, 2: 2D fix, 3: 3D fix </summary>
        public  byte fix_type;
            /// <summary> X Position </summary>
        public  Single lat;
            /// <summary> Y Position </summary>
        public  Single lon;
            /// <summary> Z Position in meters </summary>
        public  Single alt;
            /// <summary> Uncertainty in meters of latitude </summary>
        public  Single eph;
            /// <summary> Uncertainty in meters of longitude </summary>
        public  Single epv;
            /// <summary> Overall speed </summary>
        public  Single v;
            /// <summary> Heading, in FIXME </summary>
        public  Single hdg;
    
    };


    public const byte MAVLINK_MSG_ID_GPS_STATUS = 27;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=101)]
    public struct mavlink_gps_status_t
    {
        /// <summary> Number of satellites visible </summary>
        public  byte satellites_visible;
            /// <summary> Global satellite ID </summary>
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=20)]
		public byte[] satellite_prn;
            /// <summary> 0: Satellite not used, 1: used for localization </summary>
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=20)]
		public byte[] satellite_used;
            /// <summary> Elevation (0: right on top of receiver, 90: on the horizon) of satellite </summary>
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=20)]
		public byte[] satellite_elevation;
            /// <summary> Direction of satellite, 0: 0 deg, 255: 360 deg. </summary>
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=20)]
		public byte[] satellite_azimuth;
            /// <summary> Signal to noise ratio of satellite </summary>
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=20)]
		public byte[] satellite_snr;
    
    };


    public const byte MAVLINK_MSG_ID_SYS_STATUS = 34;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=8)]
    public struct mavlink_sys_status_t
    {
        /// <summary> System mode, see MAV_MODE ENUM in mavlink/include/mavlink_types.h </summary>
        public  byte mode;
            /// <summary> Navigation mode, see MAV_NAV_MODE ENUM </summary>
        public  byte nav_mode;
            /// <summary> System status flag, see MAV_STATUS ENUM </summary>
        public  byte status;
            /// <summary> Battery voltage, in millivolts (1 = 1 millivolt) </summary>
        public  UInt16 vbat;
            /// <summary> Motor block status flag, 0: Motors can be switched on (and could be either off or on), 1: Mechanical motor block switch is on, motors cannot be switched on (and are definitely off) </summary>
        public  byte motor_block;
            /// <summary> Dropped packets (packets that were corrupted on reception on the MAV) </summary>
        public  UInt16 packet_drop;
    
    };


    public const byte MAVLINK_MSG_ID_WAYPOINT = 39;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=36)]
    public struct mavlink_waypoint_t
    {
        /// <summary> System ID </summary>
        public  byte target_system;
            /// <summary> Component ID </summary>
        public  byte target_component;
            /// <summary> Sequence </summary>
        public  UInt16 seq;
            /// <summary> 0: global (GPS), 1: local, 2: global orbit, 3: local orbit </summary>
        public  byte type;
            /// <summary> Orbit to circle around the waypoint, in meters. Set to 0 to fly straight through the waypoint </summary>
        public  Single orbit;
            /// <summary> Direction of the orbit circling: 0: clockwise, 1: counter-clockwise </summary>
        public  byte orbit_direction;
            /// <summary> For waypoints of type 0 and 1: Radius in which the waypoint is accepted as reached, in meters </summary>
        public  Single param1;
            /// <summary> For waypoints of type 0 and 1: Time that the MAV should stay inside the orbit before advancing, in milliseconds </summary>
        public  Single param2;
            /// <summary> false:0, true:1 </summary>
        public  byte current;
            /// <summary> local: x position, global: longitude </summary>
        public  Single x;
            /// <summary> y position: global: latitude </summary>
        public  Single y;
            /// <summary> z position: global: altitude </summary>
        public  Single z;
            /// <summary> yaw orientation in radians, 0 = NORTH </summary>
        public  Single yaw;
            /// <summary> autocontinue to next wp </summary>
        public  byte autocontinue;
    
    };


    public const byte MAVLINK_MSG_ID_WAYPOINT_REQUEST = 40;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=4)]
    public struct mavlink_waypoint_request_t
    {
        /// <summary> System ID </summary>
        public  byte target_system;
            /// <summary> Component ID </summary>
        public  byte target_component;
            /// <summary> Sequence </summary>
        public  UInt16 seq;
    
    };


    public const byte MAVLINK_MSG_ID_WAYPOINT_SET_CURRENT = 41;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=4)]
    public struct mavlink_waypoint_set_current_t
    {
        /// <summary> System ID </summary>
        public  byte target_system;
            /// <summary> Component ID </summary>
        public  byte target_component;
            /// <summary> Sequence </summary>
        public  UInt16 seq;
    
    };


    public const byte MAVLINK_MSG_ID_WAYPOINT_CURRENT = 42;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=2)]
    public struct mavlink_waypoint_current_t
    {
        /// <summary> Sequence </summary>
        public  UInt16 seq;
    
    };


    public const byte MAVLINK_MSG_ID_WAYPOINT_COUNT = 44;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=4)]
    public struct mavlink_waypoint_count_t
    {
        /// <summary> System ID </summary>
        public  byte target_system;
            /// <summary> Component ID </summary>
        public  byte target_component;
            /// <summary> Number of Waypoints in the Sequence </summary>
        public  UInt16 count;
    
    };


    public const byte MAVLINK_MSG_ID_WAYPOINT_CLEAR_ALL = 45;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=2)]
    public struct mavlink_waypoint_clear_all_t
    {
        /// <summary> System ID </summary>
        public  byte target_system;
            /// <summary> Component ID </summary>
        public  byte target_component;
    
    };


    public const byte MAVLINK_MSG_ID_WAYPOINT_REACHED = 46;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=2)]
    public struct mavlink_waypoint_reached_t
    {
        /// <summary> Sequence </summary>
        public  UInt16 seq;
    
    };


    public const byte MAVLINK_MSG_ID_WAYPOINT_ACK = 47;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=3)]
    public struct mavlink_waypoint_ack_t
    {
        /// <summary> System ID </summary>
        public  byte target_system;
            /// <summary> Component ID </summary>
        public  byte target_component;
            /// <summary> 0: OK, 1: Error </summary>
        public  byte type;
    
    };


    public const byte MAVLINK_MSG_ID_WAYPOINT_SET_GLOBAL_REFERENCE = 48;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=34)]
    public struct mavlink_waypoint_set_global_reference_t
    {
        /// <summary> System ID </summary>
        public  byte target_system;
            /// <summary> Component ID </summary>
        public  byte target_component;
            /// <summary> global x position </summary>
        public  Single global_x;
            /// <summary> global y position </summary>
        public  Single global_y;
            /// <summary> global z position </summary>
        public  Single global_z;
            /// <summary> global yaw orientation in radians, 0 = NORTH </summary>
        public  Single global_yaw;
            /// <summary> local x position that matches the global x position </summary>
        public  Single local_x;
            /// <summary> local y position that matches the global y position </summary>
        public  Single local_y;
            /// <summary> local z position that matches the global z position </summary>
        public  Single local_z;
            /// <summary> local yaw that matches the global yaw orientation </summary>
        public  Single local_yaw;
    
    };


    public const byte MAVLINK_MSG_ID_STATUSTEXT = 254;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=51)]
    public struct mavlink_statustext_t
    {
        /// <summary> Severity of status, 0 = info message, 255 = critical fault </summary>
        public  byte severity;
            /// <summary> Status text message, without null termination character </summary>
        [MarshalAs(UnmanagedType.ByValArray,SizeConst=50)]
		public byte[] text;
    
    };


    public const byte MAVLINK_MSG_ID_DEBUG = 255;
    [StructLayout(LayoutKind.Sequential,Pack=1,Size=5)]
    public struct mavlink_debug_t
    {
        /// <summary> index of debug variable </summary>
        public  byte ind;
            /// <summary> DEBUG value </summary>
        public  Single value;
    
    };

     }
     #endif
}