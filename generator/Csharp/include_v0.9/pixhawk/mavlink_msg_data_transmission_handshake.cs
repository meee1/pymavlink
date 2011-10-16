// MESSAGE DATA_TRANSMISSION_HANDSHAKE PACKING
using System;
using System.Runtime.InteropServices;

public partial class Mavlink
{

    public const byte MAVLINK_MSG_ID_DATA_TRANSMISSION_HANDSHAKE = 193;

    [StructLayout(LayoutKind.Sequential,Pack=1)]
    public struct mavlink_data_transmission_handshake_t
    {
         public  byte type; /// type of requested/acknowledged data (as defined in ENUM DATA_TYPES in mavlink/include/mavlink_types.h)
     public  UInt32 size; /// total data size in bytes (set on ACK only)
     public  byte packets; /// number of packets beeing sent (set on ACK only)
     public  byte payload; /// payload size per packet (normally 253 byte, see DATA field size in message ENCAPSULATED_DATA) (set on ACK only)
     public  byte jpg_quality; /// JPEG quality out of [1,100]
    
    };

/**
 * @brief Pack a data_transmission_handshake message
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 *
 * @param type type of requested/acknowledged data (as defined in ENUM DATA_TYPES in mavlink/include/mavlink_types.h)
 * @param size total data size in bytes (set on ACK only)
 * @param packets number of packets beeing sent (set on ACK only)
 * @param payload payload size per packet (normally 253 byte, see DATA field size in message ENCAPSULATED_DATA) (set on ACK only)
 * @param jpg_quality JPEG quality out of [1,100]
 * @return length of the message in bytes (excluding serial stream start sign)
 */
 /*
static uint16 mavlink_msg_data_transmission_handshake_pack(byte system_id, byte component_id, ref byte[] msg,
                               byte public type, UInt32 public size, byte public packets, byte public payload, byte public jpg_quality)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    byte buf[8];
	_mav_put_byte(buf, 0, type);
	_mav_put_UInt32(buf, 1, size);
	_mav_put_byte(buf, 5, packets);
	_mav_put_byte(buf, 6, payload);
	_mav_put_byte(buf, 7, jpg_quality);

        memcpy(_MAV_PAYLOAD(msg), buf, 8);
#else
    mavlink_data_transmission_handshake_t packet;
	packet.type = type;
	packet.size = size;
	packet.packets = packets;
	packet.payload = payload;
	packet.jpg_quality = jpg_quality;

        memcpy(_MAV_PAYLOAD(msg), &packet, 8);
#endif

    msg->msgid = MAVLINK_MSG_ID_DATA_TRANSMISSION_HANDSHAKE;
    return mavlink_finalize_message(msg, system_id, component_id, 8);
}
*/
/**
 * @brief Pack a data_transmission_handshake message on a channel
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param chan The MAVLink channel this message was sent over
 * @param msg The MAVLink message to compress the data into
 * @param type type of requested/acknowledged data (as defined in ENUM DATA_TYPES in mavlink/include/mavlink_types.h)
 * @param size total data size in bytes (set on ACK only)
 * @param packets number of packets beeing sent (set on ACK only)
 * @param payload payload size per packet (normally 253 byte, see DATA field size in message ENCAPSULATED_DATA) (set on ACK only)
 * @param jpg_quality JPEG quality out of [1,100]
 * @return length of the message in bytes (excluding serial stream start sign)
 */
 /*
static inline uint16_t mavlink_msg_data_transmission_handshake_pack_chan(uint8_t system_id, uint8_t component_id, uint8_t chan,
                               mavlink_message_t* msg,
                                   byte public type,UInt32 public size,byte public packets,byte public payload,byte public jpg_quality)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    char buf[8];
	_mav_put_byte(buf, 0, type);
	_mav_put_UInt32(buf, 1, size);
	_mav_put_byte(buf, 5, packets);
	_mav_put_byte(buf, 6, payload);
	_mav_put_byte(buf, 7, jpg_quality);

        memcpy(_MAV_PAYLOAD(msg), buf, 8);
#else
    mavlink_data_transmission_handshake_t packet;
	packet.type = type;
	packet.size = size;
	packet.packets = packets;
	packet.payload = payload;
	packet.jpg_quality = jpg_quality;

        memcpy(_MAV_PAYLOAD(msg), &packet, 8);
#endif

    msg->msgid = MAVLINK_MSG_ID_DATA_TRANSMISSION_HANDSHAKE;
    return mavlink_finalize_message_chan(msg, system_id, component_id, chan, 8);
}
*/
/**
 * @brief Encode a data_transmission_handshake struct into a message
 *
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 * @param data_transmission_handshake C-struct to read the message contents from
 *//*
static inline uint16_t mavlink_msg_data_transmission_handshake_encode(uint8_t system_id, uint8_t component_id, mavlink_message_t* msg, const mavlink_data_transmission_handshake_t* data_transmission_handshake)
{
    return mavlink_msg_data_transmission_handshake_pack(system_id, component_id, msg, data_transmission_handshake->type, data_transmission_handshake->size, data_transmission_handshake->packets, data_transmission_handshake->payload, data_transmission_handshake->jpg_quality);
}
*/
/**
 * @brief Send a data_transmission_handshake message
 * @param chan MAVLink channel to send the message
 *
 * @param type type of requested/acknowledged data (as defined in ENUM DATA_TYPES in mavlink/include/mavlink_types.h)
 * @param size total data size in bytes (set on ACK only)
 * @param packets number of packets beeing sent (set on ACK only)
 * @param payload payload size per packet (normally 253 byte, see DATA field size in message ENCAPSULATED_DATA) (set on ACK only)
 * @param jpg_quality JPEG quality out of [1,100]
 *//*
#ifdef MAVLINK_USE_CONVENIENCE_FUNCTIONS

static inline void mavlink_msg_data_transmission_handshake_send(mavlink_channel_t chan, byte public type, UInt32 public size, byte public packets, byte public payload, byte public jpg_quality)
{
#if MAVLINK_NEED_BYTE_SWAP || !MAVLINK_ALIGNED_FIELDS
    char buf[8];
	_mav_put_byte(buf, 0, type);
	_mav_put_UInt32(buf, 1, size);
	_mav_put_byte(buf, 5, packets);
	_mav_put_byte(buf, 6, payload);
	_mav_put_byte(buf, 7, jpg_quality);

    _mav_finalize_message_chan_send(chan, MAVLINK_MSG_ID_DATA_TRANSMISSION_HANDSHAKE, buf, 8);
#else
    mavlink_data_transmission_handshake_t packet;
	packet.type = type;
	packet.size = size;
	packet.packets = packets;
	packet.payload = payload;
	packet.jpg_quality = jpg_quality;

    _mav_finalize_message_chan_send(chan, MAVLINK_MSG_ID_DATA_TRANSMISSION_HANDSHAKE, (const char *)&packet, 8);
#endif
}

#endif
*/
// MESSAGE DATA_TRANSMISSION_HANDSHAKE UNPACKING


/**
 * @brief Get field type from data_transmission_handshake message
 *
 * @return type of requested/acknowledged data (as defined in ENUM DATA_TYPES in mavlink/include/mavlink_types.h)
 */
public static byte mavlink_msg_data_transmission_handshake_get_type(byte[] msg)
{
    return getByte(msg,  0);
}

/**
 * @brief Get field size from data_transmission_handshake message
 *
 * @return total data size in bytes (set on ACK only)
 */
public static UInt32 mavlink_msg_data_transmission_handshake_get_size(byte[] msg)
{
    return BitConverter.ToUInt32(msg,  1);
}

/**
 * @brief Get field packets from data_transmission_handshake message
 *
 * @return number of packets beeing sent (set on ACK only)
 */
public static byte mavlink_msg_data_transmission_handshake_get_packets(byte[] msg)
{
    return getByte(msg,  5);
}

/**
 * @brief Get field payload from data_transmission_handshake message
 *
 * @return payload size per packet (normally 253 byte, see DATA field size in message ENCAPSULATED_DATA) (set on ACK only)
 */
public static byte mavlink_msg_data_transmission_handshake_get_payload(byte[] msg)
{
    return getByte(msg,  6);
}

/**
 * @brief Get field jpg_quality from data_transmission_handshake message
 *
 * @return JPEG quality out of [1,100]
 */
public static byte mavlink_msg_data_transmission_handshake_get_jpg_quality(byte[] msg)
{
    return getByte(msg,  7);
}

/**
 * @brief Decode a data_transmission_handshake message into a struct
 *
 * @param msg The message to decode
 * @param data_transmission_handshake C-struct to decode the message contents into
 */
public static void mavlink_msg_data_transmission_handshake_decode(byte[] msg, ref mavlink_data_transmission_handshake_t data_transmission_handshake)
{
if (MAVLINK_NEED_BYTE_SWAP) {
	data_transmission_handshake.type = mavlink_msg_data_transmission_handshake_get_type(msg);
	data_transmission_handshake.size = mavlink_msg_data_transmission_handshake_get_size(msg);
	data_transmission_handshake.packets = mavlink_msg_data_transmission_handshake_get_packets(msg);
	data_transmission_handshake.payload = mavlink_msg_data_transmission_handshake_get_payload(msg);
	data_transmission_handshake.jpg_quality = mavlink_msg_data_transmission_handshake_get_jpg_quality(msg);
} else {
    int len = 8; //Marshal.SizeOf(data_transmission_handshake);
    IntPtr i = Marshal.AllocHGlobal(len);
    Marshal.Copy(msg, 0, i, len);
    data_transmission_handshake = (mavlink_data_transmission_handshake_t)Marshal.PtrToStructure(i, ((object)data_transmission_handshake).GetType());
    Marshal.FreeHGlobal(i);
}
}

}
