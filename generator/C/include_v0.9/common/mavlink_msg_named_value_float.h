// MESSAGE NAMED_VALUE_FLOAT PACKING

#define MAVLINK_MSG_ID_NAMED_VALUE_FLOAT 252

typedef struct __mavlink_named_value_float_t
{
 char name[10]; ///< Name of the debug variable
 float value; ///< Floating point value
} mavlink_named_value_float_t;

/**
 * @brief Pack a named_value_float message
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 *
 * @param name Name of the debug variable
 * @param value Floating point value
 * @return length of the message in bytes (excluding serial stream start sign)
 */
static inline uint16_t mavlink_msg_named_value_float_pack(uint8_t system_id, uint8_t component_id, mavlink_message_t* msg,
						       const char name[10], float value)
{
	msg->msgid = MAVLINK_MSG_ID_NAMED_VALUE_FLOAT;

	put_char_array_by_index(name, 0, 10,  msg->payload); // Name of the debug variable
	put_float_by_index(value, 10,  msg->payload); // Floating point value

	return mavlink_finalize_message(msg, system_id, component_id, 14, 6);
}

/**
 * @brief Pack a named_value_float message on a channel
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param chan The MAVLink channel this message was sent over
 * @param msg The MAVLink message to compress the data into
 * @param name Name of the debug variable
 * @param value Floating point value
 * @return length of the message in bytes (excluding serial stream start sign)
 */
static inline uint16_t mavlink_msg_named_value_float_pack_chan(uint8_t system_id, uint8_t component_id, uint8_t chan,
							   mavlink_message_t* msg,
						           const char name[10],float value)
{
	msg->msgid = MAVLINK_MSG_ID_NAMED_VALUE_FLOAT;

	put_char_array_by_index(name, 0, 10,  msg->payload); // Name of the debug variable
	put_float_by_index(value, 10,  msg->payload); // Floating point value

	return mavlink_finalize_message_chan(msg, system_id, component_id, chan, 14, 6);
}

#ifdef MAVLINK_USE_CONVENIENCE_FUNCTIONS

/**
 * @brief Pack a named_value_float message on a channel and send
 * @param chan The MAVLink channel this message was sent over
 * @param msg The MAVLink message to compress the data into
 * @param name Name of the debug variable
 * @param value Floating point value
 */
static inline void mavlink_msg_named_value_float_pack_chan_send(mavlink_channel_t chan,
							   mavlink_message_t* msg,
						           const char name[10],float value)
{
	msg->msgid = MAVLINK_MSG_ID_NAMED_VALUE_FLOAT;

	put_char_array_by_index(name, 0, 10,  msg->payload); // Name of the debug variable
	put_float_by_index(value, 10,  msg->payload); // Floating point value

	mavlink_finalize_message_chan_send(msg, chan, 14, 6);
}
#endif // MAVLINK_USE_CONVENIENCE_FUNCTIONS


/**
 * @brief Encode a named_value_float struct into a message
 *
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 * @param named_value_float C-struct to read the message contents from
 */
static inline uint16_t mavlink_msg_named_value_float_encode(uint8_t system_id, uint8_t component_id, mavlink_message_t* msg, const mavlink_named_value_float_t* named_value_float)
{
	return mavlink_msg_named_value_float_pack(system_id, component_id, msg, named_value_float->name, named_value_float->value);
}

/**
 * @brief Send a named_value_float message
 * @param chan MAVLink channel to send the message
 *
 * @param name Name of the debug variable
 * @param value Floating point value
 */
#ifdef MAVLINK_USE_CONVENIENCE_FUNCTIONS

static inline void mavlink_msg_named_value_float_send(mavlink_channel_t chan, const char name[10], float value)
{
	MAVLINK_ALIGNED_MESSAGE(msg, 14);
	mavlink_msg_named_value_float_pack_chan_send(chan, msg, name, value);
}

#endif

// MESSAGE NAMED_VALUE_FLOAT UNPACKING


/**
 * @brief Get field name from named_value_float message
 *
 * @return Name of the debug variable
 */
static inline uint16_t mavlink_msg_named_value_float_get_name(const mavlink_message_t* msg, char *name)
{
	return MAVLINK_MSG_RETURN_char_array(msg, name, 10,  0);
}

/**
 * @brief Get field value from named_value_float message
 *
 * @return Floating point value
 */
static inline float mavlink_msg_named_value_float_get_value(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_float(msg,  10);
}

/**
 * @brief Decode a named_value_float message into a struct
 *
 * @param msg The message to decode
 * @param named_value_float C-struct to decode the message contents into
 */
static inline void mavlink_msg_named_value_float_decode(const mavlink_message_t* msg, mavlink_named_value_float_t* named_value_float)
{
#if MAVLINK_NEED_BYTE_SWAP
	mavlink_msg_named_value_float_get_name(msg, named_value_float->name);
	named_value_float->value = mavlink_msg_named_value_float_get_value(msg);
#else
	memcpy(named_value_float, msg->payload, 14);
#endif
}