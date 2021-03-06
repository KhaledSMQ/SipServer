using System;

namespace Microsoft.Win32.Ssp
{
	public enum ContextAttr
	{
		ASC_RET_DELEGATE = 1,
		ASC_RET_MUTUAL_AUTH,
		ASC_RET_REPLAY_DETECT = 4,
		ASC_RET_SEQUENCE_DETECT = 8,
		ASC_RET_CONFIDENTIALITY = 16,
		ASC_RET_USE_SESSION_KEY = 32,
		ASC_RET_ALLOCATED_MEMORY = 256,
		ASC_RET_USED_DCE_STYLE = 512,
		ASC_RET_DATAGRAM = 1024,
		ASC_RET_CONNECTION = 2048,
		ASC_RET_CALL_LEVEL = 8192,
		ASC_RET_THIRD_LEG_FAILED = 16384,
		ASC_RET_EXTENDED_ERROR = 32768,
		ASC_RET_STREAM = 65536,
		ASC_RET_INTEGRITY = 131072,
		ASC_RET_LICENSING = 262144,
		ASC_RET_IDENTIFY = 524288,
		ASC_RET_NULL_SESSION = 1048576,
		ASC_RET_ALLOW_NON_USER_LOGONS = 2097152,
		ASC_RET_FRAGMENT_ONLY = 8388608,
		ASC_RET_NO_TOKEN = 16777216
	}
}
