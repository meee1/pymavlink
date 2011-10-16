// MESSAGE WAYPOINT_SET_CURRENT PACKING
using System;
using System.Runtime.InteropServices;

public partial class Mavlink
{

    public const byte MAVLINK_MSG_ID_WAYPOINT_SET_CURRENT = 41;

    [StructLayout(LayoutKind.Sequential,Pack=1)]
    public struct mavlink_waypoint_set_current_t
    {
         public  byte target_system; /// System ID
     public  byte target_component; /// Component ID
     public  UInt16 seq; /// Sequence
    
    };

/**
 * @brief Pack a waypoint_set_current message
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 *
 * @param target_system System ID
 * @param target_component Component ID
 * @param seq Sequence
 * @return length of the message in bytes (excluding serial stream start sign)
 */
 /*
static uint16 mavlink_msg_waypoint_set_current_pack(byte system_id, byte component_id, ref byte[] msg,
                               byte public target_system, byte public target_component, UInt16 public seq)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    byte buf[4];
	_mav_put_byte(buf, 0, target_system);
	_mav_put_byte(buf, 1, target_component);
	_mav_put_UInt16(buf, 2, seq);

        memcpy(_MAV_PAYLOAD(msg), buf, 4);
#else
    mavlink_waypoint_set_current_t packet;
	packet.target_system = target_system;
	packet.target_component = target_component;
	packet.seq = seq;

        memcpy(_MAV_PAYLOAD(msg), &packet, 4);
#endif

    msg->msgid = MAVLINK_MSG_ID_WAYPOINT_SET_CURRENT;
    return mavlink_finalize_message(msg, system_id, component_id, 4);
}
*/
/**
 * @brief Pack a waypoint_set_current message on a channel
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param chan The MAVLink channel this message was sent over
 * @param msg The MAVLink message to compress the data into
 * @param target_system System ID
 * @param target_component Component ID
 * @param seq Sequence
 * @return length of the message in bytes (excluding serial stream start sign)
 */
 /*
static inline uint16_t mavlink_msg_waypoint_set_current_pack_chan(uint8_t system_id, uint8_t component_id, uint8_t chan,
                               mavlink_message_t* msg,
                                   byte public target_system,byte public target_component,UInt16 public seq)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    char buf[4];
	_mav_put_byte(buf, 0, target_system);
	_mav_put_byte(buf, 1, target_component);
	_mav_put_UInt16(buf, 2, seq);

        memcpy(_MAV_PAYLOAD(msg), buf, 4);
#else
    mavlink_waypoint_set_current_t packet;
	packet.target_system = target_system;
	packet.target_component = target_component;
	packet.seq = seq;

        memcpy(_MAV_PAYLOAD(msg), &packet, 4);
#endif

    msg->msgid = MAVLINK_MSG_ID_WAYPOINT_SET_CURRENT;
    return mavlink_finalize_message_chan(msg, system_id, component_id, chan, 4);
}
*/
/**
 * @brief Encode a waypoint_set_current struct into a message
 *
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 * @param waypoint_set_current C-struct to read the message contents from
 *//*
static inline uint16_t mavlink_msg_waypoint_set_current_encode(uint8_t system_id, uint8_t component_id, mavlink_message_t* msg, const mavlink_waypoint_set_current_t* waypoint_set_current)
{
    return mavlink_msg_waypoint_set_current_pack(system_id, component_id, msg, waypoint_set_current->target_system, waypoint_set_current->target_component, waypoint_set_current->seq);
}
*/
/**
 * @brief Send a waypoint_set_current message
 * @param chan MAVLink channel to send the message
 *
 * @param target_system System ID
 * @param target_component Component ID
 * @param seq Sequence
 *//*
#ifdef MAVLINK_USE_CONVENIENCE_FUNCTIONS

static inline void mavlink_msg_waypoint_set_current_send(mavlink_channel_t chan, byte public target_system, byte public target_component, UInt16 public seq)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    char buf[4];
	_mav_put_byte(buf, 0, target_system);
	_mav_put_byte(buf, 1, target_component);
	_mav_put_UInt16(buf, 2, seq);

    _mav_finalize_message_chan_send(chan, MAVLINK_MSG_ID_WAYPOINT_SET_CURRENT, buf, 4);
#else
    mavlink_waypoint_set_current_t packet;
	packet.target_system = target_system;
	packet.target_component = target_component;
	packet.seq = seq;

    _mav_finalize_message_chan_send(chan, MAVLINK_MSG_ID_WAYPOINT_SET_CURRENT, (const char *)&packet, 4);
#endif
}

#endif
*/
// MESSAGE WAYPOINT_SET_CURRENT UNPACKING


/**
 * @brief Get field target_system from waypoint_set_current message
 *
 * @return System ID
 */
public static byte mavlink_msg_waypoint_set_current_get_target_system(byte[] msg)
{
    return getByte(msg,  0);
}

/**
 * @brief Get field target_component from waypoint_set_current message
 *
 * @return Component ID
 */
public static byte mavlink_msg_waypoint_set_current_get_target_component(byte[] msg)
{
    return getByte(msg,  1);
}

/**
 * @brief Get field seq from waypoint_set_current message
 *
 * @return Sequence
 */
public static UInt16 mavlink_msg_waypoint_set_current_get_seq(byte[] msg)
{
    return BitConverter.ToUInt16(msg,  2);
}

/**
 * @brief Decode a waypoint_set_current message into a struct
 *
 * @param msg The message to decode
 * @param waypoint_set_current C-struct to decode the message contents into
 */
public static void mavlink_msg_waypoint_set_current_decode(byte[] msg, ref mavlink_waypoint_set_current_t waypoint_set_current)
{
if (MAVLINK_NEED_BYTE_SWAP) {
	waypoint_set_current.target_system = mavlink_msg_waypoint_set_current_get_target_system(msg);
	waypoint_set_current.target_component = mavlink_msg_waypoint_set_current_get_target_component(msg);
	waypoint_set_current.seq = mavlink_msg_waypoint_set_current_get_seq(msg);
} else {
    int len = 4; //Marshal.SizeOf(waypoint_set_current);
    IntPtr i = Marshal.AllocHGlobal(len);
    Marshal.Copy(msg, 0, i, len);
    waypoint_set_current = (mavlink_waypoint_set_current_t)Marshal.PtrToStructure(i, ((object)waypoint_set_current).GetType());
    Marshal.FreeHGlobal(i);
}
}

}
