// MESSAGE GPS_SET_GLOBAL_ORIGIN PACKING
using System;
using System.Runtime.InteropServices;

public partial class Mavlink
{

    public const byte MAVLINK_MSG_ID_GPS_SET_GLOBAL_ORIGIN = 48;

    [StructLayout(LayoutKind.Sequential,Pack=1)]
    public struct mavlink_gps_set_global_origin_t
    {
         public  Int32 latitude; /// global position * 1E7
     public  Int32 longitude; /// global position * 1E7
     public  Int32 altitude; /// global position * 1000
     public  byte target_system; /// System ID
     public  byte target_component; /// Component ID
    
    };

/**
 * @brief Pack a gps_set_global_origin message
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 *
 * @param target_system System ID
 * @param target_component Component ID
 * @param latitude global position * 1E7
 * @param longitude global position * 1E7
 * @param altitude global position * 1000
 * @return length of the message in bytes (excluding serial stream start sign)
 */
 /*
static uint16 mavlink_msg_gps_set_global_origin_pack(byte system_id, byte component_id, ref byte[] msg,
                               byte public target_system, byte public target_component, Int32 public latitude, Int32 public longitude, Int32 public altitude)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    byte buf[14];
	_mav_put_Int32(buf, 0, latitude);
	_mav_put_Int32(buf, 4, longitude);
	_mav_put_Int32(buf, 8, altitude);
	_mav_put_byte(buf, 12, target_system);
	_mav_put_byte(buf, 13, target_component);

        memcpy(_MAV_PAYLOAD(msg), buf, 14);
#else
    mavlink_gps_set_global_origin_t packet;
	packet.latitude = latitude;
	packet.longitude = longitude;
	packet.altitude = altitude;
	packet.target_system = target_system;
	packet.target_component = target_component;

        memcpy(_MAV_PAYLOAD(msg), &packet, 14);
#endif

    msg->msgid = MAVLINK_MSG_ID_GPS_SET_GLOBAL_ORIGIN;
    return mavlink_finalize_message(msg, system_id, component_id, 14, 170);
}
*/
/**
 * @brief Pack a gps_set_global_origin message on a channel
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param chan The MAVLink channel this message was sent over
 * @param msg The MAVLink message to compress the data into
 * @param target_system System ID
 * @param target_component Component ID
 * @param latitude global position * 1E7
 * @param longitude global position * 1E7
 * @param altitude global position * 1000
 * @return length of the message in bytes (excluding serial stream start sign)
 */
 /*
static inline uint16_t mavlink_msg_gps_set_global_origin_pack_chan(uint8_t system_id, uint8_t component_id, uint8_t chan,
                               mavlink_message_t* msg,
                                   byte public target_system,byte public target_component,Int32 public latitude,Int32 public longitude,Int32 public altitude)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    char buf[14];
	_mav_put_Int32(buf, 0, latitude);
	_mav_put_Int32(buf, 4, longitude);
	_mav_put_Int32(buf, 8, altitude);
	_mav_put_byte(buf, 12, target_system);
	_mav_put_byte(buf, 13, target_component);

        memcpy(_MAV_PAYLOAD(msg), buf, 14);
#else
    mavlink_gps_set_global_origin_t packet;
	packet.latitude = latitude;
	packet.longitude = longitude;
	packet.altitude = altitude;
	packet.target_system = target_system;
	packet.target_component = target_component;

        memcpy(_MAV_PAYLOAD(msg), &packet, 14);
#endif

    msg->msgid = MAVLINK_MSG_ID_GPS_SET_GLOBAL_ORIGIN;
    return mavlink_finalize_message_chan(msg, system_id, component_id, chan, 14, 170);
}
*/
/**
 * @brief Encode a gps_set_global_origin struct into a message
 *
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 * @param gps_set_global_origin C-struct to read the message contents from
 *//*
static inline uint16_t mavlink_msg_gps_set_global_origin_encode(uint8_t system_id, uint8_t component_id, mavlink_message_t* msg, const mavlink_gps_set_global_origin_t* gps_set_global_origin)
{
    return mavlink_msg_gps_set_global_origin_pack(system_id, component_id, msg, gps_set_global_origin->target_system, gps_set_global_origin->target_component, gps_set_global_origin->latitude, gps_set_global_origin->longitude, gps_set_global_origin->altitude);
}
*/
/**
 * @brief Send a gps_set_global_origin message
 * @param chan MAVLink channel to send the message
 *
 * @param target_system System ID
 * @param target_component Component ID
 * @param latitude global position * 1E7
 * @param longitude global position * 1E7
 * @param altitude global position * 1000
 *//*
#ifdef MAVLINK_USE_CONVENIENCE_FUNCTIONS

static inline void mavlink_msg_gps_set_global_origin_send(mavlink_channel_t chan, byte public target_system, byte public target_component, Int32 public latitude, Int32 public longitude, Int32 public altitude)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    char buf[14];
	_mav_put_Int32(buf, 0, latitude);
	_mav_put_Int32(buf, 4, longitude);
	_mav_put_Int32(buf, 8, altitude);
	_mav_put_byte(buf, 12, target_system);
	_mav_put_byte(buf, 13, target_component);

    _mav_finalize_message_chan_send(chan, MAVLINK_MSG_ID_GPS_SET_GLOBAL_ORIGIN, buf, 14, 170);
#else
    mavlink_gps_set_global_origin_t packet;
	packet.latitude = latitude;
	packet.longitude = longitude;
	packet.altitude = altitude;
	packet.target_system = target_system;
	packet.target_component = target_component;

    _mav_finalize_message_chan_send(chan, MAVLINK_MSG_ID_GPS_SET_GLOBAL_ORIGIN, (const char *)&packet, 14, 170);
#endif
}

#endif
*/
// MESSAGE GPS_SET_GLOBAL_ORIGIN UNPACKING


/**
 * @brief Get field target_system from gps_set_global_origin message
 *
 * @return System ID
 */
public static byte mavlink_msg_gps_set_global_origin_get_target_system(byte[] msg)
{
    return getByte(msg,  12);
}

/**
 * @brief Get field target_component from gps_set_global_origin message
 *
 * @return Component ID
 */
public static byte mavlink_msg_gps_set_global_origin_get_target_component(byte[] msg)
{
    return getByte(msg,  13);
}

/**
 * @brief Get field latitude from gps_set_global_origin message
 *
 * @return global position * 1E7
 */
public static Int32 mavlink_msg_gps_set_global_origin_get_latitude(byte[] msg)
{
    return BitConverter.ToInt32(msg,  0);
}

/**
 * @brief Get field longitude from gps_set_global_origin message
 *
 * @return global position * 1E7
 */
public static Int32 mavlink_msg_gps_set_global_origin_get_longitude(byte[] msg)
{
    return BitConverter.ToInt32(msg,  4);
}

/**
 * @brief Get field altitude from gps_set_global_origin message
 *
 * @return global position * 1000
 */
public static Int32 mavlink_msg_gps_set_global_origin_get_altitude(byte[] msg)
{
    return BitConverter.ToInt32(msg,  8);
}

/**
 * @brief Decode a gps_set_global_origin message into a struct
 *
 * @param msg The message to decode
 * @param gps_set_global_origin C-struct to decode the message contents into
 */
public static void mavlink_msg_gps_set_global_origin_decode(byte[] msg, ref mavlink_gps_set_global_origin_t gps_set_global_origin)
{
if (MAVLINK_NEED_BYTE_SWAP) {
	gps_set_global_origin.latitude = mavlink_msg_gps_set_global_origin_get_latitude(msg);
	gps_set_global_origin.longitude = mavlink_msg_gps_set_global_origin_get_longitude(msg);
	gps_set_global_origin.altitude = mavlink_msg_gps_set_global_origin_get_altitude(msg);
	gps_set_global_origin.target_system = mavlink_msg_gps_set_global_origin_get_target_system(msg);
	gps_set_global_origin.target_component = mavlink_msg_gps_set_global_origin_get_target_component(msg);
} else {
    int len = 14; //Marshal.SizeOf(gps_set_global_origin);
    IntPtr i = Marshal.AllocHGlobal(len);
    Marshal.Copy(msg, 0, i, len);
    gps_set_global_origin = (mavlink_gps_set_global_origin_t)Marshal.PtrToStructure(i, ((object)gps_set_global_origin).GetType());
    Marshal.FreeHGlobal(i);
}
}

}
