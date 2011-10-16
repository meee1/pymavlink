// MESSAGE WAYPOINT_REACHED PACKING
using System;
using System.Runtime.InteropServices;

public partial class Mavlink
{

    public const byte MAVLINK_MSG_ID_WAYPOINT_REACHED = 46;

    [StructLayout(LayoutKind.Sequential,Pack=1)]
    public struct mavlink_waypoint_reached_t
    {
         public  UInt16 seq; /// Sequence
    
    };

/**
 * @brief Pack a waypoint_reached message
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 *
 * @param seq Sequence
 * @return length of the message in bytes (excluding serial stream start sign)
 */
 /*
static uint16 mavlink_msg_waypoint_reached_pack(byte system_id, byte component_id, ref byte[] msg,
                               UInt16 public seq)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    byte buf[2];
	_mav_put_UInt16(buf, 0, seq);

        memcpy(_MAV_PAYLOAD(msg), buf, 2);
#else
    mavlink_waypoint_reached_t packet;
	packet.seq = seq;

        memcpy(_MAV_PAYLOAD(msg), &packet, 2);
#endif

    msg->msgid = MAVLINK_MSG_ID_WAYPOINT_REACHED;
    return mavlink_finalize_message(msg, system_id, component_id, 2, 21);
}
*/
/**
 * @brief Pack a waypoint_reached message on a channel
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param chan The MAVLink channel this message was sent over
 * @param msg The MAVLink message to compress the data into
 * @param seq Sequence
 * @return length of the message in bytes (excluding serial stream start sign)
 */
 /*
static inline uint16_t mavlink_msg_waypoint_reached_pack_chan(uint8_t system_id, uint8_t component_id, uint8_t chan,
                               mavlink_message_t* msg,
                                   UInt16 public seq)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    char buf[2];
	_mav_put_UInt16(buf, 0, seq);

        memcpy(_MAV_PAYLOAD(msg), buf, 2);
#else
    mavlink_waypoint_reached_t packet;
	packet.seq = seq;

        memcpy(_MAV_PAYLOAD(msg), &packet, 2);
#endif

    msg->msgid = MAVLINK_MSG_ID_WAYPOINT_REACHED;
    return mavlink_finalize_message_chan(msg, system_id, component_id, chan, 2, 21);
}
*/
/**
 * @brief Encode a waypoint_reached struct into a message
 *
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 * @param waypoint_reached C-struct to read the message contents from
 *//*
static inline uint16_t mavlink_msg_waypoint_reached_encode(uint8_t system_id, uint8_t component_id, mavlink_message_t* msg, const mavlink_waypoint_reached_t* waypoint_reached)
{
    return mavlink_msg_waypoint_reached_pack(system_id, component_id, msg, waypoint_reached->seq);
}
*/
/**
 * @brief Send a waypoint_reached message
 * @param chan MAVLink channel to send the message
 *
 * @param seq Sequence
 *//*
#ifdef MAVLINK_USE_CONVENIENCE_FUNCTIONS

static inline void mavlink_msg_waypoint_reached_send(mavlink_channel_t chan, UInt16 public seq)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    char buf[2];
	_mav_put_UInt16(buf, 0, seq);

    _mav_finalize_message_chan_send(chan, MAVLINK_MSG_ID_WAYPOINT_REACHED, buf, 2, 21);
#else
    mavlink_waypoint_reached_t packet;
	packet.seq = seq;

    _mav_finalize_message_chan_send(chan, MAVLINK_MSG_ID_WAYPOINT_REACHED, (const char *)&packet, 2, 21);
#endif
}

#endif
*/
// MESSAGE WAYPOINT_REACHED UNPACKING


/**
 * @brief Get field seq from waypoint_reached message
 *
 * @return Sequence
 */
public static UInt16 mavlink_msg_waypoint_reached_get_seq(byte[] msg)
{
    return BitConverter.ToUInt16(msg,  0);
}

/**
 * @brief Decode a waypoint_reached message into a struct
 *
 * @param msg The message to decode
 * @param waypoint_reached C-struct to decode the message contents into
 */
public static void mavlink_msg_waypoint_reached_decode(byte[] msg, ref mavlink_waypoint_reached_t waypoint_reached)
{
if (MAVLINK_NEED_BYTE_SWAP) {
	waypoint_reached.seq = mavlink_msg_waypoint_reached_get_seq(msg);
} else {
    int len = 2; //Marshal.SizeOf(waypoint_reached);
    IntPtr i = Marshal.AllocHGlobal(len);
    Marshal.Copy(msg, 0, i, len);
    waypoint_reached = (mavlink_waypoint_reached_t)Marshal.PtrToStructure(i, ((object)waypoint_reached).GetType());
    Marshal.FreeHGlobal(i);
}
}

}
