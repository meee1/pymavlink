// MESSAGE SENSOR_OFFSETS PACKING
using System;
using System.Runtime.InteropServices;

public partial class Mavlink
{

    public const byte MAVLINK_MSG_ID_SENSOR_OFFSETS = 150;

    [StructLayout(LayoutKind.Sequential,Pack=1)]
    public struct mavlink_sensor_offsets_t
    {
         public  Int16 mag_ofs_x; /// magnetometer X offset
     public  Int16 mag_ofs_y; /// magnetometer Y offset
     public  Int16 mag_ofs_z; /// magnetometer Z offset
     public  Single mag_declination; /// magnetic declination (radians)
     public  Int32 raw_press; /// raw pressure from barometer
     public  Int32 raw_temp; /// raw temperature from barometer
     public  Single gyro_cal_x; /// gyro X calibration
     public  Single gyro_cal_y; /// gyro Y calibration
     public  Single gyro_cal_z; /// gyro Z calibration
     public  Single accel_cal_x; /// accel X calibration
     public  Single accel_cal_y; /// accel Y calibration
     public  Single accel_cal_z; /// accel Z calibration
    
    };

/**
 * @brief Pack a sensor_offsets message
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 *
 * @param mag_ofs_x magnetometer X offset
 * @param mag_ofs_y magnetometer Y offset
 * @param mag_ofs_z magnetometer Z offset
 * @param mag_declination magnetic declination (radians)
 * @param raw_press raw pressure from barometer
 * @param raw_temp raw temperature from barometer
 * @param gyro_cal_x gyro X calibration
 * @param gyro_cal_y gyro Y calibration
 * @param gyro_cal_z gyro Z calibration
 * @param accel_cal_x accel X calibration
 * @param accel_cal_y accel Y calibration
 * @param accel_cal_z accel Z calibration
 * @return length of the message in bytes (excluding serial stream start sign)
 */
 /*
static uint16 mavlink_msg_sensor_offsets_pack(byte system_id, byte component_id, ref byte[] msg,
                               Int16 public mag_ofs_x, Int16 public mag_ofs_y, Int16 public mag_ofs_z, Single public mag_declination, Int32 public raw_press, Int32 public raw_temp, Single public gyro_cal_x, Single public gyro_cal_y, Single public gyro_cal_z, Single public accel_cal_x, Single public accel_cal_y, Single public accel_cal_z)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    byte buf[42];
	_mav_put_Int16(buf, 0, mag_ofs_x);
	_mav_put_Int16(buf, 2, mag_ofs_y);
	_mav_put_Int16(buf, 4, mag_ofs_z);
	_mav_put_Single(buf, 6, mag_declination);
	_mav_put_Int32(buf, 10, raw_press);
	_mav_put_Int32(buf, 14, raw_temp);
	_mav_put_Single(buf, 18, gyro_cal_x);
	_mav_put_Single(buf, 22, gyro_cal_y);
	_mav_put_Single(buf, 26, gyro_cal_z);
	_mav_put_Single(buf, 30, accel_cal_x);
	_mav_put_Single(buf, 34, accel_cal_y);
	_mav_put_Single(buf, 38, accel_cal_z);

        memcpy(_MAV_PAYLOAD(msg), buf, 42);
#else
    mavlink_sensor_offsets_t packet;
	packet.mag_ofs_x = mag_ofs_x;
	packet.mag_ofs_y = mag_ofs_y;
	packet.mag_ofs_z = mag_ofs_z;
	packet.mag_declination = mag_declination;
	packet.raw_press = raw_press;
	packet.raw_temp = raw_temp;
	packet.gyro_cal_x = gyro_cal_x;
	packet.gyro_cal_y = gyro_cal_y;
	packet.gyro_cal_z = gyro_cal_z;
	packet.accel_cal_x = accel_cal_x;
	packet.accel_cal_y = accel_cal_y;
	packet.accel_cal_z = accel_cal_z;

        memcpy(_MAV_PAYLOAD(msg), &packet, 42);
#endif

    msg->msgid = MAVLINK_MSG_ID_SENSOR_OFFSETS;
    return mavlink_finalize_message(msg, system_id, component_id, 42);
}
*/
/**
 * @brief Pack a sensor_offsets message on a channel
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param chan The MAVLink channel this message was sent over
 * @param msg The MAVLink message to compress the data into
 * @param mag_ofs_x magnetometer X offset
 * @param mag_ofs_y magnetometer Y offset
 * @param mag_ofs_z magnetometer Z offset
 * @param mag_declination magnetic declination (radians)
 * @param raw_press raw pressure from barometer
 * @param raw_temp raw temperature from barometer
 * @param gyro_cal_x gyro X calibration
 * @param gyro_cal_y gyro Y calibration
 * @param gyro_cal_z gyro Z calibration
 * @param accel_cal_x accel X calibration
 * @param accel_cal_y accel Y calibration
 * @param accel_cal_z accel Z calibration
 * @return length of the message in bytes (excluding serial stream start sign)
 */
 /*
static inline uint16_t mavlink_msg_sensor_offsets_pack_chan(uint8_t system_id, uint8_t component_id, uint8_t chan,
                               mavlink_message_t* msg,
                                   Int16 public mag_ofs_x,Int16 public mag_ofs_y,Int16 public mag_ofs_z,Single public mag_declination,Int32 public raw_press,Int32 public raw_temp,Single public gyro_cal_x,Single public gyro_cal_y,Single public gyro_cal_z,Single public accel_cal_x,Single public accel_cal_y,Single public accel_cal_z)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    char buf[42];
	_mav_put_Int16(buf, 0, mag_ofs_x);
	_mav_put_Int16(buf, 2, mag_ofs_y);
	_mav_put_Int16(buf, 4, mag_ofs_z);
	_mav_put_Single(buf, 6, mag_declination);
	_mav_put_Int32(buf, 10, raw_press);
	_mav_put_Int32(buf, 14, raw_temp);
	_mav_put_Single(buf, 18, gyro_cal_x);
	_mav_put_Single(buf, 22, gyro_cal_y);
	_mav_put_Single(buf, 26, gyro_cal_z);
	_mav_put_Single(buf, 30, accel_cal_x);
	_mav_put_Single(buf, 34, accel_cal_y);
	_mav_put_Single(buf, 38, accel_cal_z);

        memcpy(_MAV_PAYLOAD(msg), buf, 42);
#else
    mavlink_sensor_offsets_t packet;
	packet.mag_ofs_x = mag_ofs_x;
	packet.mag_ofs_y = mag_ofs_y;
	packet.mag_ofs_z = mag_ofs_z;
	packet.mag_declination = mag_declination;
	packet.raw_press = raw_press;
	packet.raw_temp = raw_temp;
	packet.gyro_cal_x = gyro_cal_x;
	packet.gyro_cal_y = gyro_cal_y;
	packet.gyro_cal_z = gyro_cal_z;
	packet.accel_cal_x = accel_cal_x;
	packet.accel_cal_y = accel_cal_y;
	packet.accel_cal_z = accel_cal_z;

        memcpy(_MAV_PAYLOAD(msg), &packet, 42);
#endif

    msg->msgid = MAVLINK_MSG_ID_SENSOR_OFFSETS;
    return mavlink_finalize_message_chan(msg, system_id, component_id, chan, 42);
}
*/
/**
 * @brief Encode a sensor_offsets struct into a message
 *
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 * @param sensor_offsets C-struct to read the message contents from
 *//*
static inline uint16_t mavlink_msg_sensor_offsets_encode(uint8_t system_id, uint8_t component_id, mavlink_message_t* msg, const mavlink_sensor_offsets_t* sensor_offsets)
{
    return mavlink_msg_sensor_offsets_pack(system_id, component_id, msg, sensor_offsets->mag_ofs_x, sensor_offsets->mag_ofs_y, sensor_offsets->mag_ofs_z, sensor_offsets->mag_declination, sensor_offsets->raw_press, sensor_offsets->raw_temp, sensor_offsets->gyro_cal_x, sensor_offsets->gyro_cal_y, sensor_offsets->gyro_cal_z, sensor_offsets->accel_cal_x, sensor_offsets->accel_cal_y, sensor_offsets->accel_cal_z);
}
*/
/**
 * @brief Send a sensor_offsets message
 * @param chan MAVLink channel to send the message
 *
 * @param mag_ofs_x magnetometer X offset
 * @param mag_ofs_y magnetometer Y offset
 * @param mag_ofs_z magnetometer Z offset
 * @param mag_declination magnetic declination (radians)
 * @param raw_press raw pressure from barometer
 * @param raw_temp raw temperature from barometer
 * @param gyro_cal_x gyro X calibration
 * @param gyro_cal_y gyro Y calibration
 * @param gyro_cal_z gyro Z calibration
 * @param accel_cal_x accel X calibration
 * @param accel_cal_y accel Y calibration
 * @param accel_cal_z accel Z calibration
 *//*
#ifdef MAVLINK_USE_CONVENIENCE_FUNCTIONS

static inline void mavlink_msg_sensor_offsets_send(mavlink_channel_t chan, Int16 public mag_ofs_x, Int16 public mag_ofs_y, Int16 public mag_ofs_z, Single public mag_declination, Int32 public raw_press, Int32 public raw_temp, Single public gyro_cal_x, Single public gyro_cal_y, Single public gyro_cal_z, Single public accel_cal_x, Single public accel_cal_y, Single public accel_cal_z)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    char buf[42];
	_mav_put_Int16(buf, 0, mag_ofs_x);
	_mav_put_Int16(buf, 2, mag_ofs_y);
	_mav_put_Int16(buf, 4, mag_ofs_z);
	_mav_put_Single(buf, 6, mag_declination);
	_mav_put_Int32(buf, 10, raw_press);
	_mav_put_Int32(buf, 14, raw_temp);
	_mav_put_Single(buf, 18, gyro_cal_x);
	_mav_put_Single(buf, 22, gyro_cal_y);
	_mav_put_Single(buf, 26, gyro_cal_z);
	_mav_put_Single(buf, 30, accel_cal_x);
	_mav_put_Single(buf, 34, accel_cal_y);
	_mav_put_Single(buf, 38, accel_cal_z);

    _mav_finalize_message_chan_send(chan, MAVLINK_MSG_ID_SENSOR_OFFSETS, buf, 42);
#else
    mavlink_sensor_offsets_t packet;
	packet.mag_ofs_x = mag_ofs_x;
	packet.mag_ofs_y = mag_ofs_y;
	packet.mag_ofs_z = mag_ofs_z;
	packet.mag_declination = mag_declination;
	packet.raw_press = raw_press;
	packet.raw_temp = raw_temp;
	packet.gyro_cal_x = gyro_cal_x;
	packet.gyro_cal_y = gyro_cal_y;
	packet.gyro_cal_z = gyro_cal_z;
	packet.accel_cal_x = accel_cal_x;
	packet.accel_cal_y = accel_cal_y;
	packet.accel_cal_z = accel_cal_z;

    _mav_finalize_message_chan_send(chan, MAVLINK_MSG_ID_SENSOR_OFFSETS, (const char *)&packet, 42);
#endif
}

#endif
*/
// MESSAGE SENSOR_OFFSETS UNPACKING


/**
 * @brief Get field mag_ofs_x from sensor_offsets message
 *
 * @return magnetometer X offset
 */
public static Int16 mavlink_msg_sensor_offsets_get_mag_ofs_x(byte[] msg)
{
    return BitConverter.ToInt16(msg,  0);
}

/**
 * @brief Get field mag_ofs_y from sensor_offsets message
 *
 * @return magnetometer Y offset
 */
public static Int16 mavlink_msg_sensor_offsets_get_mag_ofs_y(byte[] msg)
{
    return BitConverter.ToInt16(msg,  2);
}

/**
 * @brief Get field mag_ofs_z from sensor_offsets message
 *
 * @return magnetometer Z offset
 */
public static Int16 mavlink_msg_sensor_offsets_get_mag_ofs_z(byte[] msg)
{
    return BitConverter.ToInt16(msg,  4);
}

/**
 * @brief Get field mag_declination from sensor_offsets message
 *
 * @return magnetic declination (radians)
 */
public static Single mavlink_msg_sensor_offsets_get_mag_declination(byte[] msg)
{
    return BitConverter.ToSingle(msg,  6);
}

/**
 * @brief Get field raw_press from sensor_offsets message
 *
 * @return raw pressure from barometer
 */
public static Int32 mavlink_msg_sensor_offsets_get_raw_press(byte[] msg)
{
    return BitConverter.ToInt32(msg,  10);
}

/**
 * @brief Get field raw_temp from sensor_offsets message
 *
 * @return raw temperature from barometer
 */
public static Int32 mavlink_msg_sensor_offsets_get_raw_temp(byte[] msg)
{
    return BitConverter.ToInt32(msg,  14);
}

/**
 * @brief Get field gyro_cal_x from sensor_offsets message
 *
 * @return gyro X calibration
 */
public static Single mavlink_msg_sensor_offsets_get_gyro_cal_x(byte[] msg)
{
    return BitConverter.ToSingle(msg,  18);
}

/**
 * @brief Get field gyro_cal_y from sensor_offsets message
 *
 * @return gyro Y calibration
 */
public static Single mavlink_msg_sensor_offsets_get_gyro_cal_y(byte[] msg)
{
    return BitConverter.ToSingle(msg,  22);
}

/**
 * @brief Get field gyro_cal_z from sensor_offsets message
 *
 * @return gyro Z calibration
 */
public static Single mavlink_msg_sensor_offsets_get_gyro_cal_z(byte[] msg)
{
    return BitConverter.ToSingle(msg,  26);
}

/**
 * @brief Get field accel_cal_x from sensor_offsets message
 *
 * @return accel X calibration
 */
public static Single mavlink_msg_sensor_offsets_get_accel_cal_x(byte[] msg)
{
    return BitConverter.ToSingle(msg,  30);
}

/**
 * @brief Get field accel_cal_y from sensor_offsets message
 *
 * @return accel Y calibration
 */
public static Single mavlink_msg_sensor_offsets_get_accel_cal_y(byte[] msg)
{
    return BitConverter.ToSingle(msg,  34);
}

/**
 * @brief Get field accel_cal_z from sensor_offsets message
 *
 * @return accel Z calibration
 */
public static Single mavlink_msg_sensor_offsets_get_accel_cal_z(byte[] msg)
{
    return BitConverter.ToSingle(msg,  38);
}

/**
 * @brief Decode a sensor_offsets message into a struct
 *
 * @param msg The message to decode
 * @param sensor_offsets C-struct to decode the message contents into
 */
public static void mavlink_msg_sensor_offsets_decode(byte[] msg, ref mavlink_sensor_offsets_t sensor_offsets)
{
if (MAVLINK_NEED_BYTE_SWAP) {
	sensor_offsets.mag_ofs_x = mavlink_msg_sensor_offsets_get_mag_ofs_x(msg);
	sensor_offsets.mag_ofs_y = mavlink_msg_sensor_offsets_get_mag_ofs_y(msg);
	sensor_offsets.mag_ofs_z = mavlink_msg_sensor_offsets_get_mag_ofs_z(msg);
	sensor_offsets.mag_declination = mavlink_msg_sensor_offsets_get_mag_declination(msg);
	sensor_offsets.raw_press = mavlink_msg_sensor_offsets_get_raw_press(msg);
	sensor_offsets.raw_temp = mavlink_msg_sensor_offsets_get_raw_temp(msg);
	sensor_offsets.gyro_cal_x = mavlink_msg_sensor_offsets_get_gyro_cal_x(msg);
	sensor_offsets.gyro_cal_y = mavlink_msg_sensor_offsets_get_gyro_cal_y(msg);
	sensor_offsets.gyro_cal_z = mavlink_msg_sensor_offsets_get_gyro_cal_z(msg);
	sensor_offsets.accel_cal_x = mavlink_msg_sensor_offsets_get_accel_cal_x(msg);
	sensor_offsets.accel_cal_y = mavlink_msg_sensor_offsets_get_accel_cal_y(msg);
	sensor_offsets.accel_cal_z = mavlink_msg_sensor_offsets_get_accel_cal_z(msg);
} else {
    int len = 42; //Marshal.SizeOf(sensor_offsets);
    IntPtr i = Marshal.AllocHGlobal(len);
    Marshal.Copy(msg, 0, i, len);
    sensor_offsets = (mavlink_sensor_offsets_t)Marshal.PtrToStructure(i, ((object)sensor_offsets).GetType());
    Marshal.FreeHGlobal(i);
}
}

}
