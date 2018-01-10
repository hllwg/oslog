using System;
using Foundation;

// @interface Logger
interface Logger
{
	// -(id)initWithSubsystemAndCategory:(const char *)subsystem category:(const char *)category;
	[Export ("initWithSubsystemAndCategory:category:")]
	unsafe IntPtr Constructor (sbyte* subsystem, sbyte* category);

	// -(void)Log:(id)type message:(const char *)msg;
	[Export ("Log:message:")]
	unsafe void Log (NSObject type, sbyte* msg);
}
