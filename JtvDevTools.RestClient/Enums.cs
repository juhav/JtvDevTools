namespace JtvDevTools.RestClient
{

    public enum HttpMethod
    {
        Undefined = 0,
        GET,
        POST,
        PUT,
        DELETE,
        PATCH,
        HEAD,
        TRACE,
        CONNECT,
        OPTIONS
    }

    public enum RequestOutputMode
    {
        All = 0,
        Body = 1,
        Headers = 2,
        StatusCode = 3
    }

    public enum AuthenticatorType
    {
        None = 0,
        Windows = 1,
        Basic = 2
    }
}