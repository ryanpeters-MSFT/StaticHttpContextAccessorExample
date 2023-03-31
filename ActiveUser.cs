public static class ActiveUser
{
    private static IHttpContextAccessor _context;

    public static void Initialize(IHttpContextAccessor context) => _context = context;

    public static void GetActiveUserInfo()
    {
        var request = _context.HttpContext.Request;

        //
    }
}