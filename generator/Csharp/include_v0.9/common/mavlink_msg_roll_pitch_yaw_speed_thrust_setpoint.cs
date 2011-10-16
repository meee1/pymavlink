// MESSAGE ROLL_PITCH_YAW_SPEED_THRUST_SETPOINT PACKING
using System;
using System.Runtime.InteropServices;

public partial class Mavlink
{

    public const byte MAVLINK_MSG_ID_ROLL_PITCH_YAW_SPEED_THRUST_SETPOINT = 58;

    [StructLayout(LayoutKind.Sequential,Pack=1)]
    public struct mavlink_roll_pitch_yaw_speed_thrust_setpoint_t
    {
         public  UInt64 time_us; /// Timestamp in micro seconds since unix epoch
     public  Single roll_speed; /// Desired roll angular speed in rad/s
     public  Single pitch_speed; /// Desired pitch angular speed in rad/s
     public  Single yaw_speed; /// Desired yaw angular speed in rad/s
     public  Single thrust; /// Collective thrust, normalized to 0 .. 1
    
    };

/**
 * @brief Pack a roll_pitch_yaw_speed_thrust_setpoint message
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 *
 * @param time_us Timestamp in micro seconds since unix epoch
 * @param roll_speed Desired roll angular speed in rad/s
 * @param pitch_speed Desired pitch angular speed in rad/s
 * @param yaw_speed Desired yaw angular speed in rad/s
 * @param thrust Collective thrust, normalized to 0 .. 1
 * @return length of the message in bytes (excluding serial stream start sign)
 */
 /*
static uint16 mavlink_msg_roll_pitch_yaw_speed_thrust_setpoint_pack(byte system_id, byte component_id, ref byte[] msg,
                               UInt64 public time_us, Single public roll_speed, Single public pitch_speed, Single public yaw_speed, Single public thrust)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    byte buf[24];
	_mav_put_UInt64(buf, 0, time_us);
	_mav_put_Single(buf, 8, roll_speed);
	_mav_put_Single(buf, 12, pitch_speed);
	_mav_put_Single(buf, 16, yaw_speed);
	_mav_put_Single(buf, 20, thrust);

        memcpy(_MAV_PAYLOAD(msg), buf, 24);
#else
    mavlink_roll_pitch_yaw_speed_thrust_setpoint_t packet;
	packet.time_us = time_us;
	packet.roll_speed = roll_speed;
	packet.pitch_speed = pitch_speed;
	packet.yaw_speed = yaw_speed;
	packet.thrust = thrust;

        memcpy(_MAV_PAYLOAD(msg), &packet, 24);
#endif

    msg->msgid = MAVLINK_MSG_ID_ROLL_PITCH_YAW_SPEED_THRUST_SETPOINT;
    return mavlink_finalize_message(msg, system_id, component_id, 24);
}
*/
/**
 * @brief Pack a roll_pitch_yaw_speed_thrust_setpoint message on a channel
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param chan The MAVLink channel this message was sent over
 * @param msg The MAVLink message to compress the data into
 * @param time_us Timestamp in micro seconds since unix epoch
 * @param roll_speed Desired roll angular speed in rad/s
 * @param pitch_speed Desired pitch angular speed in rad/s
 * @param yaw_speed Desired yaw angular speed in rad/s
 * @param thrust Collective thrust, normalized to 0 .. 1
 * @return length of the message in bytes (excluding serial stream start sign)
 */
 /*
static inline uint16_t mavlink_msg_roll_pitch_yaw_speed_thrust_setpoint_pack_chan(uint8_t system_id, uint8_t component_id, uint8_t chan,
                               mavlink_message_t* msg,
                                   UInt64 public time_us,Single public roll_speed,Single public pitch_speed,Single public yaw_speed,Single public thrust)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    char buf[24];
	_mav_put_UInt64(buf, 0, time_us);
	_mav_put_Single(buf, 8, roll_speed);
	_mav_put_Single(buf, 12, pitch_speed);
	_mav_put_Single(buf, 16, yaw_speed);
	_mav_put_Single(buf, 20, thrust);

        memcpy(_MAV_PAYLOAD(msg), buf, 24);
#else
    mavlink_roll_pitch_yaw_speed_thrust_setpoint_t packet;
	packet.time_us = time_us;
	packet.roll_speed = roll_speed;
	packet.pitch_speed = pitch_speed;
	packet.yaw_speed = yaw_speed;
	packet.thrust = thrust;

        memcpy(_MAV_PAYLOAD(msg), &packet, 24);
#endif

    msg->msgid = MAVLINK_MSG_ID_ROLL_PITCH_YAW_SPEED_THRUST_SETPOINT;
    return mavlink_finalize_message_chan(msg, system_id, component_id, chan, 24);
}
*/
/**
 * @brief Encode a roll_pitch_yaw_speed_thrust_setpoint struct into a message
 *
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 * @param roll_pitch_yaw_speed_thrust_setpoint C-struct to read the message contents from
 *//*
static inline uint16_t mavlink_msg_roll_pitch_yaw_speed_thrust_setpoint_encode(uint8_t system_id, uint8_t component_id, mavlink_message_t* msg, const mavlink_roll_pitch_yaw_speed_thrust_setpoint_t* roll_pitch_yaw_speed_thrust_setpoint)
{
    return mavlink_msg_roll_pitch_yaw_speed_thrust_setpoint_pack(system_id, component_id, msg, roll_pitch_yaw_speed_thrust_setpoint->time_us, roll_pitch_yaw_speed_thrust_setpoint->roll_speed, roll_pitch_yaw_speed_thrust_setpoint->pitch_speed, roll_pitch_yaw_speed_thrust_setpoint->yaw_speed, roll_pitch_yaw_speed_thrust_setpoint->thrust);
}
*/
/**
 * @brief Send a roll_pitch_yaw_speed_thrust_setpoint message
 * @param chan MAVLink channel to send the message
 *
 * @param time_us Timestamp in micro seconds since unix epoch
 * @param roll_speed Desired roll angular speed in rad/s
 * @param pitch_speed Desired pitch angular speed in rad/s
 * @param yaw_speed Desired yaw angular speed in rad/s
 * @param thrust Collective thrust, normalized to 0 .. 1
 *//*
#ifdef MAVLINK_USE_CONVENIENCE_FUNCTIONS

static inline void mavlink_msg_roll_pitch_yaw_speed_thrust_setpoint_send(mavlink_channel_t chan, UInt64 public time_us, Single public roll_speed, Single public pitch_speed, Single public yaw_speed, Single public thrust)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    char buf[24];
	_mav_put_UInt64(buf, 0, time_us);
	_mav_put_Single(buf, 8, roll_speed);
	_mav_put_Single(buf, 12, pitch_speed);
	_mav_put_Single(buf, 16, yaw_speed);
	_mav_put_Single(buf, 20, thrust);

    _mav_finalize_message_chan_send(chan, MAVLINK_MSG_ID_ROLL_PITCH_YAW_SPEED_THRUST_SETPOINT, buf, 24);
#else
    mavlink_roll_pitch_yaw_speed_thrust_setpoint_t packet;
	packet.time_us = time_us;
	packet.roll_speed = roll_speed;
	packet.pitch_speed = pitch_speed;
	packet.yaw_speed = yaw_speed;
	packet.thrust = thrust;

    _mav_finalize_message_chan_send(chan, MAVLINK_MSG_ID_ROLL_PITCH_YAW_SPEED_THRUST_SETPOINT, (const char *)&packet, 24);
#endif
}

#endif
*/
// MESSAGE ROLL_PITCH_YAW_SPEED_THRUST_SETPOINT UNPACKING


/**
 * @brief Get field time_us from roll_pitch_yaw_speed_thrust_setpoint message
 *
 * @return Timestamp in micro seconds since unix epoch
 */
public static UInt64 mavlink_msg_roll_pitch_yaw_speed_thrust_setpoint_get_time_us(byte[] msg)
{
    return BitConverter.ToUInt64(msg,  0);
}

/**
 * @brief Get field roll_speed from roll_pitch_yaw_speed_thrust_setpoint message
 *
 * @return Desired roll angular speed in rad/s
 */
public static Single mavlink_msg_roll_pitch_yaw_speed_thrust_setpoint_get_roll_speed(byte[] msg)
{
    return BitConverter.ToSingle(msg,  8);
}

/**
 * @brief Get field pitch_speed from roll_pitch_yaw_speed_thrust_setpoint message
 *
 * @return Desired pitch angular speed in rad/s
 */
public static Single mavlink_msg_roll_pitch_yaw_speed_thrust_setpoint_get_pitch_speed(byte[] msg)
{
    return BitConverter.ToSingle(msg,  12);
}

/**
 * @brief Get field yaw_speed from roll_pitch_yaw_speed_thrust_setpoint message
 *
 * @return Desired yaw angular speed in rad/s
 */
public static Single mavlink_msg_roll_pitch_yaw_speed_thrust_setpoint_get_yaw_speed(byte[] msg)
{
    return BitConverter.ToSingle(msg,  16);
}

/**
 * @brief Get field thrust from roll_pitch_yaw_speed_thrust_setpoint message
 *
 * @return Collective thrust, normalized to 0 .. 1
 */
public static Single mavlink_msg_roll_pitch_yaw_speed_thrust_setpoint_get_thrust(byte[] msg)
{
    return BitConverter.ToSingle(msg,  20);
}

/**
 * @brief Decode a roll_pitch_yaw_speed_thrust_setpoint message into a struct
 *
 * @param msg The message to decode
 * @param roll_pitch_yaw_speed_thrust_setpoint C-struct to decode the message contents into
 */
public static void mavlink_msg_roll_pitch_yaw_speed_thrust_setpoint_decode(byte[] msg, ref mavlink_roll_pitch_yaw_speed_thrust_setpoint_t roll_pitch_yaw_speed_thrust_setpoint)
{
if (MAVLINK_NEED_BYTE_SWAP) {
	roll_pitch_yaw_speed_thrust_setpoint.time_us = mavlink_msg_roll_pitch_yaw_speed_thrust_setpoint_get_time_us(msg);
	roll_pitch_yaw_speed_thrust_setpoint.roll_speed = mavlink_msg_roll_pitch_yaw_speed_thrust_setpoint_get_roll_speed(msg);
	roll_pitch_yaw_speed_thrust_setpoint.pitch_speed = mavlink_msg_roll_pitch_yaw_speed_thrust_setpoint_get_pitch_speed(msg);
	roll_pitch_yaw_speed_thrust_setpoint.yaw_speed = mavlink_msg_roll_pitch_yaw_speed_thrust_setpoint_get_yaw_speed(msg);
	roll_pitch_yaw_speed_thrust_setpoint.thrust = mavlink_msg_roll_pitch_yaw_speed_thrust_setpoint_get_thrust(msg);
} else {
    int len = 24; //Marshal.SizeOf(roll_pitch_yaw_speed_thrust_setpoint);
    IntPtr i = Marshal.AllocHGlobal(len);
    Marshal.Copy(msg, 0, i, len);
    roll_pitch_yaw_speed_thrust_setpoint = (mavlink_roll_pitch_yaw_speed_thrust_setpoint_t)Marshal.PtrToStructure(i, ((object)roll_pitch_yaw_speed_thrust_setpoint).GetType());
    Marshal.FreeHGlobal(i);
}
}

}
