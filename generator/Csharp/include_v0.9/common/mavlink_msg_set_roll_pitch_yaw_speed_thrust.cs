// MESSAGE SET_ROLL_PITCH_YAW_SPEED_THRUST PACKING
using System;
using System.Runtime.InteropServices;

public partial class Mavlink
{

    public const byte MAVLINK_MSG_ID_SET_ROLL_PITCH_YAW_SPEED_THRUST = 56;

    [StructLayout(LayoutKind.Sequential,Pack=1)]
    public struct mavlink_set_roll_pitch_yaw_speed_thrust_t
    {
         public  byte target_system; /// System ID
     public  byte target_component; /// Component ID
     public  Single roll_speed; /// Desired roll angular speed in rad/s
     public  Single pitch_speed; /// Desired pitch angular speed in rad/s
     public  Single yaw_speed; /// Desired yaw angular speed in rad/s
     public  Single thrust; /// Collective thrust, normalized to 0 .. 1
    
    };

/**
 * @brief Pack a set_roll_pitch_yaw_speed_thrust message
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 *
 * @param target_system System ID
 * @param target_component Component ID
 * @param roll_speed Desired roll angular speed in rad/s
 * @param pitch_speed Desired pitch angular speed in rad/s
 * @param yaw_speed Desired yaw angular speed in rad/s
 * @param thrust Collective thrust, normalized to 0 .. 1
 * @return length of the message in bytes (excluding serial stream start sign)
 */
 /*
static uint16 mavlink_msg_set_roll_pitch_yaw_speed_thrust_pack(byte system_id, byte component_id, ref byte[] msg,
                               byte public target_system, byte public target_component, Single public roll_speed, Single public pitch_speed, Single public yaw_speed, Single public thrust)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    byte buf[18];
	_mav_put_byte(buf, 0, target_system);
	_mav_put_byte(buf, 1, target_component);
	_mav_put_Single(buf, 2, roll_speed);
	_mav_put_Single(buf, 6, pitch_speed);
	_mav_put_Single(buf, 10, yaw_speed);
	_mav_put_Single(buf, 14, thrust);

        memcpy(_MAV_PAYLOAD(msg), buf, 18);
#else
    mavlink_set_roll_pitch_yaw_speed_thrust_t packet;
	packet.target_system = target_system;
	packet.target_component = target_component;
	packet.roll_speed = roll_speed;
	packet.pitch_speed = pitch_speed;
	packet.yaw_speed = yaw_speed;
	packet.thrust = thrust;

        memcpy(_MAV_PAYLOAD(msg), &packet, 18);
#endif

    msg->msgid = MAVLINK_MSG_ID_SET_ROLL_PITCH_YAW_SPEED_THRUST;
    return mavlink_finalize_message(msg, system_id, component_id, 18);
}
*/
/**
 * @brief Pack a set_roll_pitch_yaw_speed_thrust message on a channel
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param chan The MAVLink channel this message was sent over
 * @param msg The MAVLink message to compress the data into
 * @param target_system System ID
 * @param target_component Component ID
 * @param roll_speed Desired roll angular speed in rad/s
 * @param pitch_speed Desired pitch angular speed in rad/s
 * @param yaw_speed Desired yaw angular speed in rad/s
 * @param thrust Collective thrust, normalized to 0 .. 1
 * @return length of the message in bytes (excluding serial stream start sign)
 */
 /*
static inline uint16_t mavlink_msg_set_roll_pitch_yaw_speed_thrust_pack_chan(uint8_t system_id, uint8_t component_id, uint8_t chan,
                               mavlink_message_t* msg,
                                   byte public target_system,byte public target_component,Single public roll_speed,Single public pitch_speed,Single public yaw_speed,Single public thrust)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    char buf[18];
	_mav_put_byte(buf, 0, target_system);
	_mav_put_byte(buf, 1, target_component);
	_mav_put_Single(buf, 2, roll_speed);
	_mav_put_Single(buf, 6, pitch_speed);
	_mav_put_Single(buf, 10, yaw_speed);
	_mav_put_Single(buf, 14, thrust);

        memcpy(_MAV_PAYLOAD(msg), buf, 18);
#else
    mavlink_set_roll_pitch_yaw_speed_thrust_t packet;
	packet.target_system = target_system;
	packet.target_component = target_component;
	packet.roll_speed = roll_speed;
	packet.pitch_speed = pitch_speed;
	packet.yaw_speed = yaw_speed;
	packet.thrust = thrust;

        memcpy(_MAV_PAYLOAD(msg), &packet, 18);
#endif

    msg->msgid = MAVLINK_MSG_ID_SET_ROLL_PITCH_YAW_SPEED_THRUST;
    return mavlink_finalize_message_chan(msg, system_id, component_id, chan, 18);
}
*/
/**
 * @brief Encode a set_roll_pitch_yaw_speed_thrust struct into a message
 *
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 * @param set_roll_pitch_yaw_speed_thrust C-struct to read the message contents from
 *//*
static inline uint16_t mavlink_msg_set_roll_pitch_yaw_speed_thrust_encode(uint8_t system_id, uint8_t component_id, mavlink_message_t* msg, const mavlink_set_roll_pitch_yaw_speed_thrust_t* set_roll_pitch_yaw_speed_thrust)
{
    return mavlink_msg_set_roll_pitch_yaw_speed_thrust_pack(system_id, component_id, msg, set_roll_pitch_yaw_speed_thrust->target_system, set_roll_pitch_yaw_speed_thrust->target_component, set_roll_pitch_yaw_speed_thrust->roll_speed, set_roll_pitch_yaw_speed_thrust->pitch_speed, set_roll_pitch_yaw_speed_thrust->yaw_speed, set_roll_pitch_yaw_speed_thrust->thrust);
}
*/
/**
 * @brief Send a set_roll_pitch_yaw_speed_thrust message
 * @param chan MAVLink channel to send the message
 *
 * @param target_system System ID
 * @param target_component Component ID
 * @param roll_speed Desired roll angular speed in rad/s
 * @param pitch_speed Desired pitch angular speed in rad/s
 * @param yaw_speed Desired yaw angular speed in rad/s
 * @param thrust Collective thrust, normalized to 0 .. 1
 *//*
#ifdef MAVLINK_USE_CONVENIENCE_FUNCTIONS

static inline void mavlink_msg_set_roll_pitch_yaw_speed_thrust_send(mavlink_channel_t chan, byte public target_system, byte public target_component, Single public roll_speed, Single public pitch_speed, Single public yaw_speed, Single public thrust)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    char buf[18];
	_mav_put_byte(buf, 0, target_system);
	_mav_put_byte(buf, 1, target_component);
	_mav_put_Single(buf, 2, roll_speed);
	_mav_put_Single(buf, 6, pitch_speed);
	_mav_put_Single(buf, 10, yaw_speed);
	_mav_put_Single(buf, 14, thrust);

    _mav_finalize_message_chan_send(chan, MAVLINK_MSG_ID_SET_ROLL_PITCH_YAW_SPEED_THRUST, buf, 18);
#else
    mavlink_set_roll_pitch_yaw_speed_thrust_t packet;
	packet.target_system = target_system;
	packet.target_component = target_component;
	packet.roll_speed = roll_speed;
	packet.pitch_speed = pitch_speed;
	packet.yaw_speed = yaw_speed;
	packet.thrust = thrust;

    _mav_finalize_message_chan_send(chan, MAVLINK_MSG_ID_SET_ROLL_PITCH_YAW_SPEED_THRUST, (const char *)&packet, 18);
#endif
}

#endif
*/
// MESSAGE SET_ROLL_PITCH_YAW_SPEED_THRUST UNPACKING


/**
 * @brief Get field target_system from set_roll_pitch_yaw_speed_thrust message
 *
 * @return System ID
 */
public static byte mavlink_msg_set_roll_pitch_yaw_speed_thrust_get_target_system(byte[] msg)
{
    return getByte(msg,  0);
}

/**
 * @brief Get field target_component from set_roll_pitch_yaw_speed_thrust message
 *
 * @return Component ID
 */
public static byte mavlink_msg_set_roll_pitch_yaw_speed_thrust_get_target_component(byte[] msg)
{
    return getByte(msg,  1);
}

/**
 * @brief Get field roll_speed from set_roll_pitch_yaw_speed_thrust message
 *
 * @return Desired roll angular speed in rad/s
 */
public static Single mavlink_msg_set_roll_pitch_yaw_speed_thrust_get_roll_speed(byte[] msg)
{
    return BitConverter.ToSingle(msg,  2);
}

/**
 * @brief Get field pitch_speed from set_roll_pitch_yaw_speed_thrust message
 *
 * @return Desired pitch angular speed in rad/s
 */
public static Single mavlink_msg_set_roll_pitch_yaw_speed_thrust_get_pitch_speed(byte[] msg)
{
    return BitConverter.ToSingle(msg,  6);
}

/**
 * @brief Get field yaw_speed from set_roll_pitch_yaw_speed_thrust message
 *
 * @return Desired yaw angular speed in rad/s
 */
public static Single mavlink_msg_set_roll_pitch_yaw_speed_thrust_get_yaw_speed(byte[] msg)
{
    return BitConverter.ToSingle(msg,  10);
}

/**
 * @brief Get field thrust from set_roll_pitch_yaw_speed_thrust message
 *
 * @return Collective thrust, normalized to 0 .. 1
 */
public static Single mavlink_msg_set_roll_pitch_yaw_speed_thrust_get_thrust(byte[] msg)
{
    return BitConverter.ToSingle(msg,  14);
}

/**
 * @brief Decode a set_roll_pitch_yaw_speed_thrust message into a struct
 *
 * @param msg The message to decode
 * @param set_roll_pitch_yaw_speed_thrust C-struct to decode the message contents into
 */
public static void mavlink_msg_set_roll_pitch_yaw_speed_thrust_decode(byte[] msg, ref mavlink_set_roll_pitch_yaw_speed_thrust_t set_roll_pitch_yaw_speed_thrust)
{
if (MAVLINK_NEED_BYTE_SWAP) {
	set_roll_pitch_yaw_speed_thrust.target_system = mavlink_msg_set_roll_pitch_yaw_speed_thrust_get_target_system(msg);
	set_roll_pitch_yaw_speed_thrust.target_component = mavlink_msg_set_roll_pitch_yaw_speed_thrust_get_target_component(msg);
	set_roll_pitch_yaw_speed_thrust.roll_speed = mavlink_msg_set_roll_pitch_yaw_speed_thrust_get_roll_speed(msg);
	set_roll_pitch_yaw_speed_thrust.pitch_speed = mavlink_msg_set_roll_pitch_yaw_speed_thrust_get_pitch_speed(msg);
	set_roll_pitch_yaw_speed_thrust.yaw_speed = mavlink_msg_set_roll_pitch_yaw_speed_thrust_get_yaw_speed(msg);
	set_roll_pitch_yaw_speed_thrust.thrust = mavlink_msg_set_roll_pitch_yaw_speed_thrust_get_thrust(msg);
} else {
    int len = 18; //Marshal.SizeOf(set_roll_pitch_yaw_speed_thrust);
    IntPtr i = Marshal.AllocHGlobal(len);
    Marshal.Copy(msg, 0, i, len);
    set_roll_pitch_yaw_speed_thrust = (mavlink_set_roll_pitch_yaw_speed_thrust_t)Marshal.PtrToStructure(i, ((object)set_roll_pitch_yaw_speed_thrust).GetType());
    Marshal.FreeHGlobal(i);
}
}

}
