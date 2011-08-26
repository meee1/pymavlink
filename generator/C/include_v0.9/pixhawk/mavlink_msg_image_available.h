// MESSAGE IMAGE_AVAILABLE PACKING

#define MAVLINK_MSG_ID_IMAGE_AVAILABLE 154

typedef struct __mavlink_image_available_t
{
 uint64_t cam_id; ///< Camera id
 uint8_t cam_no; ///< Camera # (starts with 0)
 uint64_t timestamp; ///< Timestamp
 uint64_t valid_until; ///< Until which timestamp this buffer will stay valid
 uint32_t img_seq; ///< The image sequence number
 uint32_t img_buf_index; ///< Position of the image in the buffer, starts with 0
 uint16_t width; ///< Image width
 uint16_t height; ///< Image height
 uint16_t depth; ///< Image depth
 uint8_t channels; ///< Image channels
 uint32_t key; ///< Shared memory area key
 uint32_t exposure; ///< Exposure time, in microseconds
 float gain; ///< Camera gain
 float roll; ///< Roll angle in rad
 float pitch; ///< Pitch angle in rad
 float yaw; ///< Yaw angle in rad
 float local_z; ///< Local frame Z coordinate (height over ground)
 float lat; ///< GPS X coordinate
 float lon; ///< GPS Y coordinate
 float alt; ///< Global frame altitude
 float ground_x; ///< Ground truth X
 float ground_y; ///< Ground truth Y
 float ground_z; ///< Ground truth Z
} mavlink_image_available_t;

#define MAVLINK_MSG_ID_IMAGE_AVAILABLE_LEN 92
#define MAVLINK_MSG_ID_154_LEN 92



#define MAVLINK_MESSAGE_INFO_IMAGE_AVAILABLE { \
	"IMAGE_AVAILABLE", \
	23, \
	{  { "cam_id", MAVLINK_TYPE_UINT64_T, 0, 0, offsetof(mavlink_image_available_t, cam_id) }, \
         { "cam_no", MAVLINK_TYPE_UINT8_T, 0, 8, offsetof(mavlink_image_available_t, cam_no) }, \
         { "timestamp", MAVLINK_TYPE_UINT64_T, 0, 9, offsetof(mavlink_image_available_t, timestamp) }, \
         { "valid_until", MAVLINK_TYPE_UINT64_T, 0, 17, offsetof(mavlink_image_available_t, valid_until) }, \
         { "img_seq", MAVLINK_TYPE_UINT32_T, 0, 25, offsetof(mavlink_image_available_t, img_seq) }, \
         { "img_buf_index", MAVLINK_TYPE_UINT32_T, 0, 29, offsetof(mavlink_image_available_t, img_buf_index) }, \
         { "width", MAVLINK_TYPE_UINT16_T, 0, 33, offsetof(mavlink_image_available_t, width) }, \
         { "height", MAVLINK_TYPE_UINT16_T, 0, 35, offsetof(mavlink_image_available_t, height) }, \
         { "depth", MAVLINK_TYPE_UINT16_T, 0, 37, offsetof(mavlink_image_available_t, depth) }, \
         { "channels", MAVLINK_TYPE_UINT8_T, 0, 39, offsetof(mavlink_image_available_t, channels) }, \
         { "key", MAVLINK_TYPE_UINT32_T, 0, 40, offsetof(mavlink_image_available_t, key) }, \
         { "exposure", MAVLINK_TYPE_UINT32_T, 0, 44, offsetof(mavlink_image_available_t, exposure) }, \
         { "gain", MAVLINK_TYPE_FLOAT, 0, 48, offsetof(mavlink_image_available_t, gain) }, \
         { "roll", MAVLINK_TYPE_FLOAT, 0, 52, offsetof(mavlink_image_available_t, roll) }, \
         { "pitch", MAVLINK_TYPE_FLOAT, 0, 56, offsetof(mavlink_image_available_t, pitch) }, \
         { "yaw", MAVLINK_TYPE_FLOAT, 0, 60, offsetof(mavlink_image_available_t, yaw) }, \
         { "local_z", MAVLINK_TYPE_FLOAT, 0, 64, offsetof(mavlink_image_available_t, local_z) }, \
         { "lat", MAVLINK_TYPE_FLOAT, 0, 68, offsetof(mavlink_image_available_t, lat) }, \
         { "lon", MAVLINK_TYPE_FLOAT, 0, 72, offsetof(mavlink_image_available_t, lon) }, \
         { "alt", MAVLINK_TYPE_FLOAT, 0, 76, offsetof(mavlink_image_available_t, alt) }, \
         { "ground_x", MAVLINK_TYPE_FLOAT, 0, 80, offsetof(mavlink_image_available_t, ground_x) }, \
         { "ground_y", MAVLINK_TYPE_FLOAT, 0, 84, offsetof(mavlink_image_available_t, ground_y) }, \
         { "ground_z", MAVLINK_TYPE_FLOAT, 0, 88, offsetof(mavlink_image_available_t, ground_z) }, \
         } \
}


/**
 * @brief Pack a image_available message
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 *
 * @param cam_id Camera id
 * @param cam_no Camera # (starts with 0)
 * @param timestamp Timestamp
 * @param valid_until Until which timestamp this buffer will stay valid
 * @param img_seq The image sequence number
 * @param img_buf_index Position of the image in the buffer, starts with 0
 * @param width Image width
 * @param height Image height
 * @param depth Image depth
 * @param channels Image channels
 * @param key Shared memory area key
 * @param exposure Exposure time, in microseconds
 * @param gain Camera gain
 * @param roll Roll angle in rad
 * @param pitch Pitch angle in rad
 * @param yaw Yaw angle in rad
 * @param local_z Local frame Z coordinate (height over ground)
 * @param lat GPS X coordinate
 * @param lon GPS Y coordinate
 * @param alt Global frame altitude
 * @param ground_x Ground truth X
 * @param ground_y Ground truth Y
 * @param ground_z Ground truth Z
 * @return length of the message in bytes (excluding serial stream start sign)
 */
static inline uint16_t mavlink_msg_image_available_pack(uint8_t system_id, uint8_t component_id, mavlink_message_t* msg,
						       uint64_t cam_id, uint8_t cam_no, uint64_t timestamp, uint64_t valid_until, uint32_t img_seq, uint32_t img_buf_index, uint16_t width, uint16_t height, uint16_t depth, uint8_t channels, uint32_t key, uint32_t exposure, float gain, float roll, float pitch, float yaw, float local_z, float lat, float lon, float alt, float ground_x, float ground_y, float ground_z)
{
	msg->msgid = MAVLINK_MSG_ID_IMAGE_AVAILABLE;

	put_uint64_t_by_index(msg, 0, cam_id); // Camera id
	put_uint8_t_by_index(msg, 8, cam_no); // Camera # (starts with 0)
	put_uint64_t_by_index(msg, 9, timestamp); // Timestamp
	put_uint64_t_by_index(msg, 17, valid_until); // Until which timestamp this buffer will stay valid
	put_uint32_t_by_index(msg, 25, img_seq); // The image sequence number
	put_uint32_t_by_index(msg, 29, img_buf_index); // Position of the image in the buffer, starts with 0
	put_uint16_t_by_index(msg, 33, width); // Image width
	put_uint16_t_by_index(msg, 35, height); // Image height
	put_uint16_t_by_index(msg, 37, depth); // Image depth
	put_uint8_t_by_index(msg, 39, channels); // Image channels
	put_uint32_t_by_index(msg, 40, key); // Shared memory area key
	put_uint32_t_by_index(msg, 44, exposure); // Exposure time, in microseconds
	put_float_by_index(msg, 48, gain); // Camera gain
	put_float_by_index(msg, 52, roll); // Roll angle in rad
	put_float_by_index(msg, 56, pitch); // Pitch angle in rad
	put_float_by_index(msg, 60, yaw); // Yaw angle in rad
	put_float_by_index(msg, 64, local_z); // Local frame Z coordinate (height over ground)
	put_float_by_index(msg, 68, lat); // GPS X coordinate
	put_float_by_index(msg, 72, lon); // GPS Y coordinate
	put_float_by_index(msg, 76, alt); // Global frame altitude
	put_float_by_index(msg, 80, ground_x); // Ground truth X
	put_float_by_index(msg, 84, ground_y); // Ground truth Y
	put_float_by_index(msg, 88, ground_z); // Ground truth Z

	return mavlink_finalize_message(msg, system_id, component_id, 92, 49);
}

/**
 * @brief Pack a image_available message on a channel
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param chan The MAVLink channel this message was sent over
 * @param msg The MAVLink message to compress the data into
 * @param cam_id Camera id
 * @param cam_no Camera # (starts with 0)
 * @param timestamp Timestamp
 * @param valid_until Until which timestamp this buffer will stay valid
 * @param img_seq The image sequence number
 * @param img_buf_index Position of the image in the buffer, starts with 0
 * @param width Image width
 * @param height Image height
 * @param depth Image depth
 * @param channels Image channels
 * @param key Shared memory area key
 * @param exposure Exposure time, in microseconds
 * @param gain Camera gain
 * @param roll Roll angle in rad
 * @param pitch Pitch angle in rad
 * @param yaw Yaw angle in rad
 * @param local_z Local frame Z coordinate (height over ground)
 * @param lat GPS X coordinate
 * @param lon GPS Y coordinate
 * @param alt Global frame altitude
 * @param ground_x Ground truth X
 * @param ground_y Ground truth Y
 * @param ground_z Ground truth Z
 * @return length of the message in bytes (excluding serial stream start sign)
 */
static inline uint16_t mavlink_msg_image_available_pack_chan(uint8_t system_id, uint8_t component_id, uint8_t chan,
							   mavlink_message_t* msg,
						           uint64_t cam_id,uint8_t cam_no,uint64_t timestamp,uint64_t valid_until,uint32_t img_seq,uint32_t img_buf_index,uint16_t width,uint16_t height,uint16_t depth,uint8_t channels,uint32_t key,uint32_t exposure,float gain,float roll,float pitch,float yaw,float local_z,float lat,float lon,float alt,float ground_x,float ground_y,float ground_z)
{
	msg->msgid = MAVLINK_MSG_ID_IMAGE_AVAILABLE;

	put_uint64_t_by_index(msg, 0, cam_id); // Camera id
	put_uint8_t_by_index(msg, 8, cam_no); // Camera # (starts with 0)
	put_uint64_t_by_index(msg, 9, timestamp); // Timestamp
	put_uint64_t_by_index(msg, 17, valid_until); // Until which timestamp this buffer will stay valid
	put_uint32_t_by_index(msg, 25, img_seq); // The image sequence number
	put_uint32_t_by_index(msg, 29, img_buf_index); // Position of the image in the buffer, starts with 0
	put_uint16_t_by_index(msg, 33, width); // Image width
	put_uint16_t_by_index(msg, 35, height); // Image height
	put_uint16_t_by_index(msg, 37, depth); // Image depth
	put_uint8_t_by_index(msg, 39, channels); // Image channels
	put_uint32_t_by_index(msg, 40, key); // Shared memory area key
	put_uint32_t_by_index(msg, 44, exposure); // Exposure time, in microseconds
	put_float_by_index(msg, 48, gain); // Camera gain
	put_float_by_index(msg, 52, roll); // Roll angle in rad
	put_float_by_index(msg, 56, pitch); // Pitch angle in rad
	put_float_by_index(msg, 60, yaw); // Yaw angle in rad
	put_float_by_index(msg, 64, local_z); // Local frame Z coordinate (height over ground)
	put_float_by_index(msg, 68, lat); // GPS X coordinate
	put_float_by_index(msg, 72, lon); // GPS Y coordinate
	put_float_by_index(msg, 76, alt); // Global frame altitude
	put_float_by_index(msg, 80, ground_x); // Ground truth X
	put_float_by_index(msg, 84, ground_y); // Ground truth Y
	put_float_by_index(msg, 88, ground_z); // Ground truth Z

	return mavlink_finalize_message_chan(msg, system_id, component_id, chan, 92, 49);
}

#ifdef MAVLINK_USE_CONVENIENCE_FUNCTIONS

/**
 * @brief Pack a image_available message on a channel and send
 * @param chan The MAVLink channel this message was sent over
 * @param msg The MAVLink message to compress the data into
 * @param cam_id Camera id
 * @param cam_no Camera # (starts with 0)
 * @param timestamp Timestamp
 * @param valid_until Until which timestamp this buffer will stay valid
 * @param img_seq The image sequence number
 * @param img_buf_index Position of the image in the buffer, starts with 0
 * @param width Image width
 * @param height Image height
 * @param depth Image depth
 * @param channels Image channels
 * @param key Shared memory area key
 * @param exposure Exposure time, in microseconds
 * @param gain Camera gain
 * @param roll Roll angle in rad
 * @param pitch Pitch angle in rad
 * @param yaw Yaw angle in rad
 * @param local_z Local frame Z coordinate (height over ground)
 * @param lat GPS X coordinate
 * @param lon GPS Y coordinate
 * @param alt Global frame altitude
 * @param ground_x Ground truth X
 * @param ground_y Ground truth Y
 * @param ground_z Ground truth Z
 */
static inline void mavlink_msg_image_available_pack_chan_send(mavlink_channel_t chan,
							   mavlink_message_t* msg,
						           uint64_t cam_id,uint8_t cam_no,uint64_t timestamp,uint64_t valid_until,uint32_t img_seq,uint32_t img_buf_index,uint16_t width,uint16_t height,uint16_t depth,uint8_t channels,uint32_t key,uint32_t exposure,float gain,float roll,float pitch,float yaw,float local_z,float lat,float lon,float alt,float ground_x,float ground_y,float ground_z)
{
	msg->msgid = MAVLINK_MSG_ID_IMAGE_AVAILABLE;

	put_uint64_t_by_index(msg, 0, cam_id); // Camera id
	put_uint8_t_by_index(msg, 8, cam_no); // Camera # (starts with 0)
	put_uint64_t_by_index(msg, 9, timestamp); // Timestamp
	put_uint64_t_by_index(msg, 17, valid_until); // Until which timestamp this buffer will stay valid
	put_uint32_t_by_index(msg, 25, img_seq); // The image sequence number
	put_uint32_t_by_index(msg, 29, img_buf_index); // Position of the image in the buffer, starts with 0
	put_uint16_t_by_index(msg, 33, width); // Image width
	put_uint16_t_by_index(msg, 35, height); // Image height
	put_uint16_t_by_index(msg, 37, depth); // Image depth
	put_uint8_t_by_index(msg, 39, channels); // Image channels
	put_uint32_t_by_index(msg, 40, key); // Shared memory area key
	put_uint32_t_by_index(msg, 44, exposure); // Exposure time, in microseconds
	put_float_by_index(msg, 48, gain); // Camera gain
	put_float_by_index(msg, 52, roll); // Roll angle in rad
	put_float_by_index(msg, 56, pitch); // Pitch angle in rad
	put_float_by_index(msg, 60, yaw); // Yaw angle in rad
	put_float_by_index(msg, 64, local_z); // Local frame Z coordinate (height over ground)
	put_float_by_index(msg, 68, lat); // GPS X coordinate
	put_float_by_index(msg, 72, lon); // GPS Y coordinate
	put_float_by_index(msg, 76, alt); // Global frame altitude
	put_float_by_index(msg, 80, ground_x); // Ground truth X
	put_float_by_index(msg, 84, ground_y); // Ground truth Y
	put_float_by_index(msg, 88, ground_z); // Ground truth Z

	mavlink_finalize_message_chan_send(msg, chan, 92, 49);
}
#endif // MAVLINK_USE_CONVENIENCE_FUNCTIONS


/**
 * @brief Encode a image_available struct into a message
 *
 * @param system_id ID of this system
 * @param component_id ID of this component (e.g. 200 for IMU)
 * @param msg The MAVLink message to compress the data into
 * @param image_available C-struct to read the message contents from
 */
static inline uint16_t mavlink_msg_image_available_encode(uint8_t system_id, uint8_t component_id, mavlink_message_t* msg, const mavlink_image_available_t* image_available)
{
	return mavlink_msg_image_available_pack(system_id, component_id, msg, image_available->cam_id, image_available->cam_no, image_available->timestamp, image_available->valid_until, image_available->img_seq, image_available->img_buf_index, image_available->width, image_available->height, image_available->depth, image_available->channels, image_available->key, image_available->exposure, image_available->gain, image_available->roll, image_available->pitch, image_available->yaw, image_available->local_z, image_available->lat, image_available->lon, image_available->alt, image_available->ground_x, image_available->ground_y, image_available->ground_z);
}

/**
 * @brief Send a image_available message
 * @param chan MAVLink channel to send the message
 *
 * @param cam_id Camera id
 * @param cam_no Camera # (starts with 0)
 * @param timestamp Timestamp
 * @param valid_until Until which timestamp this buffer will stay valid
 * @param img_seq The image sequence number
 * @param img_buf_index Position of the image in the buffer, starts with 0
 * @param width Image width
 * @param height Image height
 * @param depth Image depth
 * @param channels Image channels
 * @param key Shared memory area key
 * @param exposure Exposure time, in microseconds
 * @param gain Camera gain
 * @param roll Roll angle in rad
 * @param pitch Pitch angle in rad
 * @param yaw Yaw angle in rad
 * @param local_z Local frame Z coordinate (height over ground)
 * @param lat GPS X coordinate
 * @param lon GPS Y coordinate
 * @param alt Global frame altitude
 * @param ground_x Ground truth X
 * @param ground_y Ground truth Y
 * @param ground_z Ground truth Z
 */
#ifdef MAVLINK_USE_CONVENIENCE_FUNCTIONS

static inline void mavlink_msg_image_available_send(mavlink_channel_t chan, uint64_t cam_id, uint8_t cam_no, uint64_t timestamp, uint64_t valid_until, uint32_t img_seq, uint32_t img_buf_index, uint16_t width, uint16_t height, uint16_t depth, uint8_t channels, uint32_t key, uint32_t exposure, float gain, float roll, float pitch, float yaw, float local_z, float lat, float lon, float alt, float ground_x, float ground_y, float ground_z)
{
	MAVLINK_ALIGNED_MESSAGE(msg, 92);
	mavlink_msg_image_available_pack_chan_send(chan, msg, cam_id, cam_no, timestamp, valid_until, img_seq, img_buf_index, width, height, depth, channels, key, exposure, gain, roll, pitch, yaw, local_z, lat, lon, alt, ground_x, ground_y, ground_z);
}

#endif

// MESSAGE IMAGE_AVAILABLE UNPACKING


/**
 * @brief Get field cam_id from image_available message
 *
 * @return Camera id
 */
static inline uint64_t mavlink_msg_image_available_get_cam_id(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_uint64_t(msg,  0);
}

/**
 * @brief Get field cam_no from image_available message
 *
 * @return Camera # (starts with 0)
 */
static inline uint8_t mavlink_msg_image_available_get_cam_no(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_uint8_t(msg,  8);
}

/**
 * @brief Get field timestamp from image_available message
 *
 * @return Timestamp
 */
static inline uint64_t mavlink_msg_image_available_get_timestamp(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_uint64_t(msg,  9);
}

/**
 * @brief Get field valid_until from image_available message
 *
 * @return Until which timestamp this buffer will stay valid
 */
static inline uint64_t mavlink_msg_image_available_get_valid_until(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_uint64_t(msg,  17);
}

/**
 * @brief Get field img_seq from image_available message
 *
 * @return The image sequence number
 */
static inline uint32_t mavlink_msg_image_available_get_img_seq(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_uint32_t(msg,  25);
}

/**
 * @brief Get field img_buf_index from image_available message
 *
 * @return Position of the image in the buffer, starts with 0
 */
static inline uint32_t mavlink_msg_image_available_get_img_buf_index(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_uint32_t(msg,  29);
}

/**
 * @brief Get field width from image_available message
 *
 * @return Image width
 */
static inline uint16_t mavlink_msg_image_available_get_width(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_uint16_t(msg,  33);
}

/**
 * @brief Get field height from image_available message
 *
 * @return Image height
 */
static inline uint16_t mavlink_msg_image_available_get_height(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_uint16_t(msg,  35);
}

/**
 * @brief Get field depth from image_available message
 *
 * @return Image depth
 */
static inline uint16_t mavlink_msg_image_available_get_depth(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_uint16_t(msg,  37);
}

/**
 * @brief Get field channels from image_available message
 *
 * @return Image channels
 */
static inline uint8_t mavlink_msg_image_available_get_channels(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_uint8_t(msg,  39);
}

/**
 * @brief Get field key from image_available message
 *
 * @return Shared memory area key
 */
static inline uint32_t mavlink_msg_image_available_get_key(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_uint32_t(msg,  40);
}

/**
 * @brief Get field exposure from image_available message
 *
 * @return Exposure time, in microseconds
 */
static inline uint32_t mavlink_msg_image_available_get_exposure(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_uint32_t(msg,  44);
}

/**
 * @brief Get field gain from image_available message
 *
 * @return Camera gain
 */
static inline float mavlink_msg_image_available_get_gain(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_float(msg,  48);
}

/**
 * @brief Get field roll from image_available message
 *
 * @return Roll angle in rad
 */
static inline float mavlink_msg_image_available_get_roll(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_float(msg,  52);
}

/**
 * @brief Get field pitch from image_available message
 *
 * @return Pitch angle in rad
 */
static inline float mavlink_msg_image_available_get_pitch(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_float(msg,  56);
}

/**
 * @brief Get field yaw from image_available message
 *
 * @return Yaw angle in rad
 */
static inline float mavlink_msg_image_available_get_yaw(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_float(msg,  60);
}

/**
 * @brief Get field local_z from image_available message
 *
 * @return Local frame Z coordinate (height over ground)
 */
static inline float mavlink_msg_image_available_get_local_z(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_float(msg,  64);
}

/**
 * @brief Get field lat from image_available message
 *
 * @return GPS X coordinate
 */
static inline float mavlink_msg_image_available_get_lat(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_float(msg,  68);
}

/**
 * @brief Get field lon from image_available message
 *
 * @return GPS Y coordinate
 */
static inline float mavlink_msg_image_available_get_lon(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_float(msg,  72);
}

/**
 * @brief Get field alt from image_available message
 *
 * @return Global frame altitude
 */
static inline float mavlink_msg_image_available_get_alt(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_float(msg,  76);
}

/**
 * @brief Get field ground_x from image_available message
 *
 * @return Ground truth X
 */
static inline float mavlink_msg_image_available_get_ground_x(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_float(msg,  80);
}

/**
 * @brief Get field ground_y from image_available message
 *
 * @return Ground truth Y
 */
static inline float mavlink_msg_image_available_get_ground_y(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_float(msg,  84);
}

/**
 * @brief Get field ground_z from image_available message
 *
 * @return Ground truth Z
 */
static inline float mavlink_msg_image_available_get_ground_z(const mavlink_message_t* msg)
{
	return MAVLINK_MSG_RETURN_float(msg,  88);
}

/**
 * @brief Decode a image_available message into a struct
 *
 * @param msg The message to decode
 * @param image_available C-struct to decode the message contents into
 */
static inline void mavlink_msg_image_available_decode(const mavlink_message_t* msg, mavlink_image_available_t* image_available)
{
#if MAVLINK_NEED_BYTE_SWAP
	image_available->cam_id = mavlink_msg_image_available_get_cam_id(msg);
	image_available->cam_no = mavlink_msg_image_available_get_cam_no(msg);
	image_available->timestamp = mavlink_msg_image_available_get_timestamp(msg);
	image_available->valid_until = mavlink_msg_image_available_get_valid_until(msg);
	image_available->img_seq = mavlink_msg_image_available_get_img_seq(msg);
	image_available->img_buf_index = mavlink_msg_image_available_get_img_buf_index(msg);
	image_available->width = mavlink_msg_image_available_get_width(msg);
	image_available->height = mavlink_msg_image_available_get_height(msg);
	image_available->depth = mavlink_msg_image_available_get_depth(msg);
	image_available->channels = mavlink_msg_image_available_get_channels(msg);
	image_available->key = mavlink_msg_image_available_get_key(msg);
	image_available->exposure = mavlink_msg_image_available_get_exposure(msg);
	image_available->gain = mavlink_msg_image_available_get_gain(msg);
	image_available->roll = mavlink_msg_image_available_get_roll(msg);
	image_available->pitch = mavlink_msg_image_available_get_pitch(msg);
	image_available->yaw = mavlink_msg_image_available_get_yaw(msg);
	image_available->local_z = mavlink_msg_image_available_get_local_z(msg);
	image_available->lat = mavlink_msg_image_available_get_lat(msg);
	image_available->lon = mavlink_msg_image_available_get_lon(msg);
	image_available->alt = mavlink_msg_image_available_get_alt(msg);
	image_available->ground_x = mavlink_msg_image_available_get_ground_x(msg);
	image_available->ground_y = mavlink_msg_image_available_get_ground_y(msg);
	image_available->ground_z = mavlink_msg_image_available_get_ground_z(msg);
#else
	memcpy(image_available, MAVLINK_PAYLOAD(msg), 92);
#endif
}
