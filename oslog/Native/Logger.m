#import "Logger.h"

@implementation Logger

- (id)initWithSubsystemAndCategory:(const char*)subsystem category:(const char*) category
{
    self = [super init];
    if (self)
    {
        _os_log = os_log_create(subsystem, category);
    }
    return self;
}

- (id)init
{
    self = [super init];
    if (self)
    {
        _os_log = OS_LOG_DEFAULT;
    }
    return self;
}

- (void) Log:(os_log_type_t)type message: (const char*) msg;
{
    os_log_with_type(_os_log, type, "%{public}s", msg);
}

- (bool) IsEnabled:(os_log_type_t)type;
{
    return os_log_type_enabled(_os_log, type);
}

@end