// MESSAGE ROLL_PITCH_YAW_THRUST_SETPOINT PACKING

#define MAVLINK_MSG_ID_ROLL_PITCH_YAW_THRUST_SETPOINT 57

typedef struct __mavlink_roll_pitch_yaw_thrust_setpoint_t
{
 uint32_t time_ms; ///< Timestamp in milliseconds since system boot
 float roll; ///< Desired roll angle in radians
 float pitch; ///< Desired pitch angle in radians
 float yaw; ///< Desired yaw angle in radians
 float thrust; ///< Collective thrust, normalized to 0 .. 1
} mavlink_roll_pitch_yaw_thrust_setpoint_t;

/**
 * @brief Pack a roll_pitch_yaw_thrust_setpoint message
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 *
 * @param time_ms Timestamp in milliseconds since system boot
 * @param roll Desired roll angle in radians
 * @param pitch Desired pitch angle in radians
 * @param yaw Desired yaw angle in radians
 * @param thrust Collective thrust, normalized to 0 .. 1
 * @return length of the message in bytes (excluding serial stream start sign)
 */
static inline uint16_t mavlink_msg_roll_pitch_yaw_thrust_setpoint_pack(uint8_t system_id, uint8_t component_id, mavlink_message_t* msg,
						       uint32_t time_ms, float roll, float pitch, float yaw, float thrust)
{
	msg->msgid = MAVLINK_MSG_ID_ROLL_PITCH_YAW_THRUST_SETPOINT;

	put_uint32_t_by_index(time_ms, 0,  MAVLINK_PAYLOAD(msg)); // Timestamp in milliseconds since system boot
	put_float_by_index(roll, 4,  MAVLINK_PAYLOAD(msg)); // Desired roll angle in radians
	put_float_by_index(pitch, 8,  MAVLINK_PAYLOAD(msg)); // Desired pitch angle in radians
	put_float_by_index(yaw, 12,  MAVLINK_PAYLOAD(msg)); // Desired yaw angle in radians
	put_float_by_index(thrust, 16,  MAVLINK_PAYLOAD(msg)); // Collective thrust, normalized to 0 .. 1

	return mavlink_finalize_message(msg, system_id, component_id, 20, 1);
}

/**
 * @brief Pack a roll_pitch_yaw_thrust_setpoint message on a channel
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param chan The MAVLink channel this message was sent over
 * @param msg The MAVLink message to compress the data into
 * @param time_ms Timestamp in milliseconds since system boot
 * @param roll Desired roll angle in radians
 * @param pitch Desired pitch angle in radians
 * @param yaw Desired yaw angle in radians
 * @param thrust Collective thrust, normalized to 0 .. 1
 * @return length of the message in bytes (excluding serial stream start sign)
 */
static inline uint16_t mavlink_msg_roll_pitch_yaw_thrust_setpoint_pack_chan(uint8_t system_id, uint8_t component_id, uint8_t chan,
							   mavlink_message_t* msg,
						           uint32_t time_ms,float roll,float pitch,float yaw,float thrust)
{
	msg->msgid = MAVLINK_MSG_ID_ROLL_PITCH_YAW_THRUST_SETPOINT;

	put_uint32_t_by_index(time_ms, 0,  MAVLINK_PAYLOAD(msg)); // Timestamp in milliseconds since system boot
	put_float_by_index(roll, 4,  MAVLINK_PAYLOAD(msg)); // Desired roll angle in radians
	put_float_by_index(pitch, 8,  MAVLINK_PAYLOAD(msg)); // Desired pitch angle in radians
	put_float_by_index(yaw, 12,  MAVLINK_PAYLOAD(msg)); // Desired yaw angle in radians
	put_float_by_index(thrust, 16,  MAVLINK_PAYLOAD(msg)); // Collective thrust, normalized to 0 .. 1

	return mavlink_finalize_message_chan(msg, system_id, component_id, chan, 20, 1);
}

#ifdef MAVLINK_USE_CONVENIENCE_FUNCTIONS

/**
 * @brief Pack a roll_pitch_yaw_thrust_setpoint message on a channel and send
 * @param chan The MAVLink channel this message was sent over
 * @param msg The MAVLink message to compress the data into
 * @param time_ms Timestamp in milliseconds since system boot
 * @param roll Desired roll angle in radians
 * @param pitch Desired pitch angle in radians
 * @param yaw Desired yaw angle in radians
 * @param thrust Collective thrust, normalized to 0 .. 1
 */
static inline void mavlink_msg_roll_pitch_yaw_thrust_setpoint_pack_chan_send(mavlink_channel_t chan,
							   mavlink_message_t* msg,
						           uint32_t time_ms,float roll,float pitch,float yaw,float thrust)
{
	msg->msgid = MAVLINK_MSG_ID_ROLL_PITCH_YAW_THRUST_SETPOINT;

	put_uint32_t_by_index(time_ms, 0,  MAVLINK_PAYLOAD(msg)); // Timestamp in milliseconds since system boot
	put_float_by_index(roll, 4,  MAVLINK_PAYLOAD(msg)); // Desired roll angle in radians
	put_float_by_index(pitch, 8,  MAVLINK_PAYLOAD(msg)); // Desired pitch angle in radians
	put_float_by_index(yaw, 12,  MAVLINK_PAYLOAD(msg)); // Desired yaw angle in radians
	put_float_by_index(thrust, 16,  MAVLINK_PAYLOAD(msg)); // Collective thrust, normalized to 0 .. 1

	mavlink_finalize_message_chan_send(msg, chan, 20, 1);
}
#endif // MAVLINK_USE_CONVENIENCE_FUNCTIONS


/**
 * @brief Encode a roll_pitch_yaw_thrust_setpoint struct into a message
 *
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 * @param roll_pitch_yaw_thrust_setpoint C-struct to read the message contents from
 */
static inline uint16_t mavlink_msg_roll_pitch_yaw_thrust_setpoint_encode(uint8_t system_id, uint8_t component_id, mavlink_message_t* msg, const mavlink_roll_pitch_yaw_thrust_setpoint_t* roll_pitch_yaw_thrust_setpoint)
{
	return mavlink_msg_roll_pitch_yaw_thrust_setpoint_pack(system_id, component_id, msg, roll_pitch_yaw_thrust_setpoint->time_ms, roll_pitch_yaw_thrust_setpoint->roll, roll_pitch_yaw_thrust_setpoint->pitch, roll_pitch_yaw_thrust_setpoint->yaw, roll_pitch_yaw_thrust_setpoint->thrust);
}

/**
 * @brief Send a roll_pitch_yaw_thrust_setpoint message
 * @param chan MAVLink channel to send the message
 *
 * @param time_ms Timestamp in milliseconds since system boot
 * @param roll Desired roll angle in radians
 * @param pitch Desired pitch angle in radians
 * @param yaw Desired yaw angle in radians
 * @param thrust Collective thrust, normalized to 0 .. 1
 */
#ifdef MAVLINK_USE_CONVENIENCE_FUNCTIONS

static inline void mavlink_msg_roll_pitch_yaw_thrust_setpoint_send(mavlink_channel_t chan, uint32_t time_ms, float roll, float pitch, float yaw, float thrust)
{
	MAVLINK_ALIGNED_MESSAGE(msg, 20);
	mavlink_msg_roll_pitch_yaw_thrust_setpoint_pack_chan_send(chan, msg, time_ms, roll, pitch, yaw, thrust);
}

#endif

// MESSAGE ROLL_PITCH_YAW_THRUST_SETPOINT UNPACKING


/**
 * @brief Get field time_ms from roll_pitch_yaw_thrust_setpoint message
 *
 * @return Timestamp in milliseconds since system boot
 */
static inline uint32_t mavlink_msg_roll_pitch_yaw_thrust_setpoint_get_time_ms(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_uint32_t(msg,  0);
}

/**
 * @brief Get field roll from roll_pitch_yaw_thrust_setpoint message
 *
 * @return Desired roll angle in radians
 */
static inline float mavlink_msg_roll_pitch_yaw_thrust_setpoint_get_roll(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_float(msg,  4);
}

/**
 * @brief Get field pitch from roll_pitch_yaw_thrust_setpoint message
 *
 * @return Desired pitch angle in radians
 */
static inline float mavlink_msg_roll_pitch_yaw_thrust_setpoint_get_pitch(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_float(msg,  8);
}

/**
 * @brief Get field yaw from roll_pitch_yaw_thrust_setpoint message
 *
 * @return Desired yaw angle in radians
 */
static inline float mavlink_msg_roll_pitch_yaw_thrust_setpoint_get_yaw(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_float(msg,  12);
}

/**
 * @brief Get field thrust from roll_pitch_yaw_thrust_setpoint message
 *
 * @return Collective thrust, normalized to 0 .. 1
 */
static inline float mavlink_msg_roll_pitch_yaw_thrust_setpoint_get_thrust(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_float(msg,  16);
}

/**
 * @brief Decode a roll_pitch_yaw_thrust_setpoint message into a struct
 *
 * @param msg The message to decode
 * @param roll_pitch_yaw_thrust_setpoint C-struct to decode the message contents into
 */
static inline void mavlink_msg_roll_pitch_yaw_thrust_setpoint_decode(const mavlink_message_t* msg, mavlink_roll_pitch_yaw_thrust_setpoint_t* roll_pitch_yaw_thrust_setpoint)
{
#if MAVLINK_NEED_BYTE_SWAP
	roll_pitch_yaw_thrust_setpoint->time_ms = mavlink_msg_roll_pitch_yaw_thrust_setpoint_get_time_ms(msg);
	roll_pitch_yaw_thrust_setpoint->roll = mavlink_msg_roll_pitch_yaw_thrust_setpoint_get_roll(msg);
	roll_pitch_yaw_thrust_setpoint->pitch = mavlink_msg_roll_pitch_yaw_thrust_setpoint_get_pitch(msg);
	roll_pitch_yaw_thrust_setpoint->yaw = mavlink_msg_roll_pitch_yaw_thrust_setpoint_get_yaw(msg);
	roll_pitch_yaw_thrust_setpoint->thrust = mavlink_msg_roll_pitch_yaw_thrust_setpoint_get_thrust(msg);
#else
	memcpy(roll_pitch_yaw_thrust_setpoint, MAVLINK_PAYLOAD(msg), 20);
#endif
}
