// MESSAGE GPS_STATUS PACKING

#define MAVLINK_MSG_ID_GPS_STATUS 27

typedef struct __mavlink_gps_status_t
{
 uint8_t satellites_visible; ///< Number of satellites visible
 int8_t satellite_prn[20]; ///< Global satellite ID
 int8_t satellite_used[20]; ///< 0: Satellite not used, 1: used for localization
 int8_t satellite_elevation[20]; ///< Elevation (0: right on top of receiver, 90: on the horizon) of satellite
 int8_t satellite_azimuth[20]; ///< Direction of satellite, 0: 0 deg, 255: 360 deg.
 int8_t satellite_snr[20]; ///< Signal to noise ratio of satellite
} mavlink_gps_status_t;

/**
 * @brief Pack a gps_status message
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 *
 * @param satellites_visible Number of satellites visible
 * @param satellite_prn Global satellite ID
 * @param satellite_used 0: Satellite not used, 1: used for localization
 * @param satellite_elevation Elevation (0: right on top of receiver, 90: on the horizon) of satellite
 * @param satellite_azimuth Direction of satellite, 0: 0 deg, 255: 360 deg.
 * @param satellite_snr Signal to noise ratio of satellite
 * @return length of the message in bytes (excluding serial stream start sign)
 */
static inline uint16_t mavlink_msg_gps_status_pack(uint8_t system_id, uint8_t component_id, mavlink_message_t* msg,
						       uint8_t satellites_visible, const int8_t satellite_prn[20], const int8_t satellite_used[20], const int8_t satellite_elevation[20], const int8_t satellite_azimuth[20], const int8_t satellite_snr[20])
{
	msg->msgid = MAVLINK_MSG_ID_GPS_STATUS;

	put_uint8_t_by_index(satellites_visible, 0,  msg->payload); // Number of satellites visible
	put_int8_t_array_by_index(satellite_prn, 1, 20,  msg->payload); // Global satellite ID
	put_int8_t_array_by_index(satellite_used, 21, 20,  msg->payload); // 0: Satellite not used, 1: used for localization
	put_int8_t_array_by_index(satellite_elevation, 41, 20,  msg->payload); // Elevation (0: right on top of receiver, 90: on the horizon) of satellite
	put_int8_t_array_by_index(satellite_azimuth, 61, 20,  msg->payload); // Direction of satellite, 0: 0 deg, 255: 360 deg.
	put_int8_t_array_by_index(satellite_snr, 81, 20,  msg->payload); // Signal to noise ratio of satellite

	return mavlink_finalize_message(msg, system_id, component_id, 101, 101);
}

/**
 * @brief Pack a gps_status message on a channel
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param chan The MAVLink channel this message was sent over
 * @param msg The MAVLink message to compress the data into
 * @param satellites_visible Number of satellites visible
 * @param satellite_prn Global satellite ID
 * @param satellite_used 0: Satellite not used, 1: used for localization
 * @param satellite_elevation Elevation (0: right on top of receiver, 90: on the horizon) of satellite
 * @param satellite_azimuth Direction of satellite, 0: 0 deg, 255: 360 deg.
 * @param satellite_snr Signal to noise ratio of satellite
 * @return length of the message in bytes (excluding serial stream start sign)
 */
static inline uint16_t mavlink_msg_gps_status_pack_chan(uint8_t system_id, uint8_t component_id, uint8_t chan,
							   mavlink_message_t* msg,
						           uint8_t satellites_visible,const int8_t satellite_prn[20],const int8_t satellite_used[20],const int8_t satellite_elevation[20],const int8_t satellite_azimuth[20],const int8_t satellite_snr[20])
{
	msg->msgid = MAVLINK_MSG_ID_GPS_STATUS;

	put_uint8_t_by_index(satellites_visible, 0,  msg->payload); // Number of satellites visible
	put_int8_t_array_by_index(satellite_prn, 1, 20,  msg->payload); // Global satellite ID
	put_int8_t_array_by_index(satellite_used, 21, 20,  msg->payload); // 0: Satellite not used, 1: used for localization
	put_int8_t_array_by_index(satellite_elevation, 41, 20,  msg->payload); // Elevation (0: right on top of receiver, 90: on the horizon) of satellite
	put_int8_t_array_by_index(satellite_azimuth, 61, 20,  msg->payload); // Direction of satellite, 0: 0 deg, 255: 360 deg.
	put_int8_t_array_by_index(satellite_snr, 81, 20,  msg->payload); // Signal to noise ratio of satellite

	return mavlink_finalize_message_chan(msg, system_id, component_id, chan, 101, 101);
}

#ifdef MAVLINK_USE_CONVENIENCE_FUNCTIONS

/**
 * @brief Pack a gps_status message on a channel and send
 * @param chan The MAVLink channel this message was sent over
 * @param msg The MAVLink message to compress the data into
 * @param satellites_visible Number of satellites visible
 * @param satellite_prn Global satellite ID
 * @param satellite_used 0: Satellite not used, 1: used for localization
 * @param satellite_elevation Elevation (0: right on top of receiver, 90: on the horizon) of satellite
 * @param satellite_azimuth Direction of satellite, 0: 0 deg, 255: 360 deg.
 * @param satellite_snr Signal to noise ratio of satellite
 */
static inline void mavlink_msg_gps_status_pack_chan_send(mavlink_channel_t chan,
							   mavlink_message_t* msg,
						           uint8_t satellites_visible,const int8_t satellite_prn[20],const int8_t satellite_used[20],const int8_t satellite_elevation[20],const int8_t satellite_azimuth[20],const int8_t satellite_snr[20])
{
	msg->msgid = MAVLINK_MSG_ID_GPS_STATUS;

	put_uint8_t_by_index(satellites_visible, 0,  msg->payload); // Number of satellites visible
	put_int8_t_array_by_index(satellite_prn, 1, 20,  msg->payload); // Global satellite ID
	put_int8_t_array_by_index(satellite_used, 21, 20,  msg->payload); // 0: Satellite not used, 1: used for localization
	put_int8_t_array_by_index(satellite_elevation, 41, 20,  msg->payload); // Elevation (0: right on top of receiver, 90: on the horizon) of satellite
	put_int8_t_array_by_index(satellite_azimuth, 61, 20,  msg->payload); // Direction of satellite, 0: 0 deg, 255: 360 deg.
	put_int8_t_array_by_index(satellite_snr, 81, 20,  msg->payload); // Signal to noise ratio of satellite

	mavlink_finalize_message_chan_send(msg, chan, 101, 101);
}
#endif // MAVLINK_USE_CONVENIENCE_FUNCTIONS


/**
 * @brief Encode a gps_status struct into a message
 *
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 * @param gps_status C-struct to read the message contents from
 */
static inline uint16_t mavlink_msg_gps_status_encode(uint8_t system_id, uint8_t component_id, mavlink_message_t* msg, const mavlink_gps_status_t* gps_status)
{
	return mavlink_msg_gps_status_pack(system_id, component_id, msg, gps_status->satellites_visible, gps_status->satellite_prn, gps_status->satellite_used, gps_status->satellite_elevation, gps_status->satellite_azimuth, gps_status->satellite_snr);
}

/**
 * @brief Send a gps_status message
 * @param chan MAVLink channel to send the message
 *
 * @param satellites_visible Number of satellites visible
 * @param satellite_prn Global satellite ID
 * @param satellite_used 0: Satellite not used, 1: used for localization
 * @param satellite_elevation Elevation (0: right on top of receiver, 90: on the horizon) of satellite
 * @param satellite_azimuth Direction of satellite, 0: 0 deg, 255: 360 deg.
 * @param satellite_snr Signal to noise ratio of satellite
 */
#ifdef MAVLINK_USE_CONVENIENCE_FUNCTIONS

static inline void mavlink_msg_gps_status_send(mavlink_channel_t chan, uint8_t satellites_visible, const int8_t satellite_prn[20], const int8_t satellite_used[20], const int8_t satellite_elevation[20], const int8_t satellite_azimuth[20], const int8_t satellite_snr[20])
{
	MAVLINK_ALIGNED_MESSAGE(msg, 101);
	mavlink_msg_gps_status_pack_chan_send(chan, msg, satellites_visible, satellite_prn, satellite_used, satellite_elevation, satellite_azimuth, satellite_snr);
}

#endif

// MESSAGE GPS_STATUS UNPACKING


/**
 * @brief Get field satellites_visible from gps_status message
 *
 * @return Number of satellites visible
 */
static inline uint8_t mavlink_msg_gps_status_get_satellites_visible(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_uint8_t(msg,  0);
}

/**
 * @brief Get field satellite_prn from gps_status message
 *
 * @return Global satellite ID
 */
static inline uint16_t mavlink_msg_gps_status_get_satellite_prn(const mavlink_message_t* msg, int8_t *satellite_prn)
{
	return MAVLINK_MSG_RETURN_int8_t_array(msg, satellite_prn, 20,  1);
}

/**
 * @brief Get field satellite_used from gps_status message
 *
 * @return 0: Satellite not used, 1: used for localization
 */
static inline uint16_t mavlink_msg_gps_status_get_satellite_used(const mavlink_message_t* msg, int8_t *satellite_used)
{
	return MAVLINK_MSG_RETURN_int8_t_array(msg, satellite_used, 20,  21);
}

/**
 * @brief Get field satellite_elevation from gps_status message
 *
 * @return Elevation (0: right on top of receiver, 90: on the horizon) of satellite
 */
static inline uint16_t mavlink_msg_gps_status_get_satellite_elevation(const mavlink_message_t* msg, int8_t *satellite_elevation)
{
	return MAVLINK_MSG_RETURN_int8_t_array(msg, satellite_elevation, 20,  41);
}

/**
 * @brief Get field satellite_azimuth from gps_status message
 *
 * @return Direction of satellite, 0: 0 deg, 255: 360 deg.
 */
static inline uint16_t mavlink_msg_gps_status_get_satellite_azimuth(const mavlink_message_t* msg, int8_t *satellite_azimuth)
{
	return MAVLINK_MSG_RETURN_int8_t_array(msg, satellite_azimuth, 20,  61);
}

/**
 * @brief Get field satellite_snr from gps_status message
 *
 * @return Signal to noise ratio of satellite
 */
static inline uint16_t mavlink_msg_gps_status_get_satellite_snr(const mavlink_message_t* msg, int8_t *satellite_snr)
{
	return MAVLINK_MSG_RETURN_int8_t_array(msg, satellite_snr, 20,  81);
}

/**
 * @brief Decode a gps_status message into a struct
 *
 * @param msg The message to decode
 * @param gps_status C-struct to decode the message contents into
 */
static inline void mavlink_msg_gps_status_decode(const mavlink_message_t* msg, mavlink_gps_status_t* gps_status)
{
#if MAVLINK_NEED_BYTE_SWAP
	gps_status->satellites_visible = mavlink_msg_gps_status_get_satellites_visible(msg);
	mavlink_msg_gps_status_get_satellite_prn(msg, gps_status->satellite_prn);
	mavlink_msg_gps_status_get_satellite_used(msg, gps_status->satellite_used);
	mavlink_msg_gps_status_get_satellite_elevation(msg, gps_status->satellite_elevation);
	mavlink_msg_gps_status_get_satellite_azimuth(msg, gps_status->satellite_azimuth);
	mavlink_msg_gps_status_get_satellite_snr(msg, gps_status->satellite_snr);
#else
	memcpy(gps_status, msg->payload, 101);
#endif
}