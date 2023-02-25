using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[ComImport,
 TypeLibType(256),
 InterfaceType(1),
 Guid("94D09862-1875-4FC9-B434-91CF25C840A1")]
public interface IIDMApi {
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SendLinkToIDM(
		[In][MarshalAs(UnmanagedType.BStr)] string bstrUrl,
		[In][MarshalAs(UnmanagedType.BStr)] string bstrReferer,
		[In][MarshalAs(UnmanagedType.BStr)] string bstrCookies,
		[In][MarshalAs(UnmanagedType.BStr)] string bstrData,
		[In][MarshalAs(UnmanagedType.BStr)] string bstrUser,
		[In][MarshalAs(UnmanagedType.BStr)] string bstrPassword,
		[In][MarshalAs(UnmanagedType.BStr)] string bstrLocalPath,
		[In][MarshalAs(UnmanagedType.BStr)] string bstrLocalFileName,
		[In] int lFlags);
}

[ComImport,
 TypeLibType(2),
 ClassInterface((short)0),
 Guid("AC746233-E9D3-49CD-862F-068F7B7CCCA4")]
public class IDMApi : IIDMApi {
	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern void SendLinkToIDM(
		[In][MarshalAs(UnmanagedType.BStr)] string bstrUrl,
		[In][MarshalAs(UnmanagedType.BStr)] string bstrReferer,
		[In][MarshalAs(UnmanagedType.BStr)] string bstrCookies,
		[In][MarshalAs(UnmanagedType.BStr)] string bstrData,
		[In][MarshalAs(UnmanagedType.BStr)] string bstrUser,
		[In][MarshalAs(UnmanagedType.BStr)] string bstrPassword,
		[In][MarshalAs(UnmanagedType.BStr)] string bstrLocalPath,
		[In][MarshalAs(UnmanagedType.BStr)] string bstrLocalFileName,
		[In] int lFlags);
}
