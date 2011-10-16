// MESSAGE GPS_DATE_TIME PACKING
using System;
using System.Runtime.InteropServices;

public partial class Mavlink
{

    public const byte MAVLINK_MSG_ID_GPS_DATE_TIME = 179;

    [StructLayout(LayoutKind.Sequential,Pack=1)]
    public struct mavlink_gps_date_time_t
    {
         public  byte year; /// Year reported by Gps 
     public  byte month; /// Month reported by Gps 
     public  byte day; /// Day reported by Gps 
     public  byte hour; /// Hour reported by Gps 
     public  byte min; /// Min reported by Gps 
     public  byte sec; /// Sec reported by Gps  
     public  byte visSat; /// Visible sattelites reported by Gps  
    
    };

/**
 * @brief Pack a gps_date_time message
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 *
 * @param year Year reported by Gps 
 * @param month Month reported by Gps 
 * @param day Day reported by Gps 
 * @param hour Hour reported by Gps 
 * @param min Min reported by Gps 
 * @param sec Sec reported by Gps  
 * @param visSat Visible sattelites reported by Gps  
 * @return length of the message in bytes (excluding serial stream start sign)
 */
 /*
static uint16 mavlink_msg_gps_date_time_pack(byte system_id, byte component_id, ref byte[] msg,
                               byte public year, byte public month, byte public day, byte public hour, byte public min, byte public sec, byte public visSat)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    byte buf[7];
	_mav_put_byte(buf, 0, year);
	_mav_put_byte(buf, 1, month);
	_mav_put_byte(buf, 2, day);
	_mav_put_byte(buf, 3, hour);
	_mav_put_byte(buf, 4, min);
	_mav_put_byte(buf, 5, sec);
	_mav_put_byte(buf, 6, visSat);

        memcpy(_MAV_PAYLOAD(msg), buf, 7);
#else
    mavlink_gps_date_time_t packet;
	packet.year = year;
	packet.month = month;
	packet.day = day;
	packet.hour = hour;
	packet.min = min;
	packet.sec = sec;
	packet.visSat = visSat;

        memcpy(_MAV_PAYLOAD(msg), &packet, 7);
#endif

    msg->msgid = MAVLINK_MSG_ID_GPS_DATE_TIME;
    return mavlink_finalize_message(msg, system_id, component_id, 7);
}
*/
/**
 * @brief Pack a gps_date_time message on a channel
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param chan The MAVLink channel this message was sent over
 * @param msg The MAVLink message to compress the data into
 * @param year Year reported by Gps 
 * @param month Month reported by Gps 
 * @param day Day reported by Gps 
 * @param hour Hour reported by Gps 
 * @param min Min reported by Gps 
 * @param sec Sec reported by Gps  
 * @param visSat Visible sattelites reported by Gps  
 * @return length of the message in bytes (excluding serial stream start sign)
 */
 /*
static inline uint16_t mavlink_msg_gps_date_time_pack_chan(uint8_t system_id, uint8_t component_id, uint8_t chan,
                               mavlink_message_t* msg,
                                   byte public year,byte public month,byte public day,byte public hour,byte public min,byte public sec,byte public visSat)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    char buf[7];
	_mav_put_byte(buf, 0, year);
	_mav_put_byte(buf, 1, month);
	_mav_put_byte(buf, 2, day);
	_mav_put_byte(buf, 3, hour);
	_mav_put_byte(buf, 4, min);
	_mav_put_byte(buf, 5, sec);
	_mav_put_byte(buf, 6, visSat);

        memcpy(_MAV_PAYLOAD(msg), buf, 7);
#else
    mavlink_gps_date_time_t packet;
	packet.year = year;
	packet.month = month;
	packet.day = day;
	packet.hour = hour;
	packet.min = min;
	packet.sec = sec;
	packet.visSat = visSat;

        memcpy(_MAV_PAYLOAD(msg), &packet, 7);
#endif

    msg->msgid = MAVLINK_MSG_ID_GPS_DATE_TIME;
    return mavlink_finalize_message_chan(msg, system_id, component_id, chan, 7);
}
*/
/**
 * @brief Encode a gps_date_time struct into a message
 *
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 * @param gps_date_time C-struct to read the message contents from
 *//*
static inline uint16_t mavlink_msg_gps_date_time_encode(uint8_t system_id, uint8_t component_id, mavlink_message_t* msg, const mavlink_gps_date_time_t* gps_date_time)
{
    return mavlink_msg_gps_date_time_pack(system_id, component_id, msg, gps_date_time->year, gps_date_time->month, gps_date_time->day, gps_date_time->hour, gps_date_time->min, gps_date_time->sec, gps_date_time->visSat);
}
*/
/**
 * @brief Send a gps_date_time message
 * @param chan MAVLink channel to send the message
 *
 * @param year Year reported by Gps 
 * @param month Month reported by Gps 
 * @param day Day reported by Gps 
 * @param hour Hour reported by Gps 
 * @param min Min reported by Gps 
 * @param sec Sec reported by Gps  
 * @param visSat Visible sattelites reported by Gps  
 *//*
#ifdef MAVLINK_USE_CONVENIENCE_FUNCTIONS

static inline void mavlink_msg_gps_date_time_send(mavlink_channel_t chan, byte public year, byte public month, byte public day, byte public hour, byte public min, byte public sec, byte public visSat)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    char buf[7];
	_mav_put_byte(buf, 0, year);
	_mav_put_byte(buf, 1, month);
	_mav_put_byte(buf, 2, day);
	_mav_put_byte(buf, 3, hour);
	_mav_put_byte(buf, 4, min);
	_mav_put_byte(buf, 5, sec);
	_mav_put_byte(buf, 6, visSat);

    _mav_finalize_message_chan_send(chan, MAVLINK_MSG_ID_GPS_DATE_TIME, buf, 7);
#else
    mavlink_gps_date_time_t packet;
	packet.year = year;
	packet.month = month;
	packet.day = day;
	packet.hour = hour;
	packet.min = min;
	packet.sec = sec;
	packet.visSat = visSat;

    _mav_finalize_message_chan_send(chan, MAVLINK_MSG_ID_GPS_DATE_TIME, (const char *)&packet, 7);
#endif
}

#endif
*/
// MESSAGE GPS_DATE_TIME UNPACKING


/**
 * @brief Get field year from gps_date_time message
 *
 * @return Year reported by Gps 
 */
public static byte mavlink_msg_gps_date_time_get_year(byte[] msg)
{
    return getByte(msg,  0);
}

/**
 * @brief Get field month from gps_date_time message
 *
 * @return Month reported by Gps 
 */
public static byte mavlink_msg_gps_date_time_get_month(byte[] msg)
{
    return getByte(msg,  1);
}

/**
 * @brief Get field day from gps_date_time message
 *
 * @return Day reported by Gps 
 */
public static byte mavlink_msg_gps_date_time_get_day(byte[] msg)
{
    return getByte(msg,  2);
}

/**
 * @brief Get field hour from gps_date_time message
 *
 * @return Hour reported by Gps 
 */
public static byte mavlink_msg_gps_date_time_get_hour(byte[] msg)
{
    return getByte(msg,  3);
}

/**
 * @brief Get field min from gps_date_time message
 *
 * @return Min reported by Gps 
 */
public static byte mavlink_msg_gps_date_time_get_min(byte[] msg)
{
    return getByte(msg,  4);
}

/**
 * @brief Get field sec from gps_date_time message
 *
 * @return Sec reported by Gps  
 */
public static byte mavlink_msg_gps_date_time_get_sec(byte[] msg)
{
    return getByte(msg,  5);
}

/**
 * @brief Get field visSat from gps_date_time message
 *
 * @return Visible sattelites reported by Gps  
 */
public static byte mavlink_msg_gps_date_time_get_visSat(byte[] msg)
{
    return getByte(msg,  6);
}

/**
 * @brief Decode a gps_date_time message into a struct
 *
 * @param msg The message to decode
 * @param gps_date_time C-struct to decode the message contents into
 */
public static void mavlink_msg_gps_date_time_decode(byte[] msg, ref mavlink_gps_date_time_t gps_date_time)
{
if (MAVLINK_NEED_BYTE_SWAP) {
	gps_date_time.year = mavlink_msg_gps_date_time_get_year(msg);
	gps_date_time.month = mavlink_msg_gps_date_time_get_month(msg);
	gps_date_time.day = mavlink_msg_gps_date_time_get_day(msg);
	gps_date_time.hour = mavlink_msg_gps_date_time_get_hour(msg);
	gps_date_time.min = mavlink_msg_gps_date_time_get_min(msg);
	gps_date_time.sec = mavlink_msg_gps_date_time_get_sec(msg);
	gps_date_time.visSat = mavlink_msg_gps_date_time_get_visSat(msg);
} else {
    int len = 7; //Marshal.SizeOf(gps_date_time);
    IntPtr i = Marshal.AllocHGlobal(len);
    Marshal.Copy(msg, 0, i, len);
    gps_date_time = (mavlink_gps_date_time_t)Marshal.PtrToStructure(i, ((object)gps_date_time).GetType());
    Marshal.FreeHGlobal(i);
}
}

}
