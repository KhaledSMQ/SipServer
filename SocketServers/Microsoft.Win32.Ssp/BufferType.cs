using System;

namespace Microsoft.Win32.Ssp
{
	public enum BufferType
	{
		SECBUFFER_VERSION,
		SECBUFFER_EMPTY = 0,
		SECBUFFER_DATA,
		SECBUFFER_TOKEN,
		SECBUFFER_PKG_PARAMS,
		SECBUFFER_MISSING,
		SECBUFFER_EXTRA,
		SECBUFFER_STREAM_TRAILER,
		SECBUFFER_STREAM_HEADER,
		SECBUFFER_NEGOTIATION_INFO,
		SECBUFFER_PADDING,
		SECBUFFER_STREAM,
		SECBUFFER_MECHLIST,
		SECBUFFER_MECHLIST_SIGNATURE,
		SECBUFFER_TARGET,
		SECBUFFER_CHANNEL_BINDINGS,
		SECBUFFER_CHANGE_PASS_RESPONSE
	}
}