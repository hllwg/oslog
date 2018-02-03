#import <Foundation/Foundation.h>
#import <os/log.h>

@interface Logger : NSObject {
    os_log_t _os_log;
}

- (id) initWithSubsystemAndCategory:(const char*)subsystem category:(const char*) category;
- (id) init;
- (void) Log:(os_log_type_t)type message: (const char*) msg;
- (bool) IsEnabled:(os_log_type_t)type;
@end