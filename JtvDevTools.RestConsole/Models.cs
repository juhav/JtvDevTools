﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JtvDevTools.RestConsole;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum HttpMethod
{
    Undefined = 0,
    GET,
    POST,
    PUT,
    DELETE
}

//public class BaseUrl
//{
//    private string name = "";
//    private string url = "";

//    public string Name 
//    {
//        get => name;
//        set => name = (value ?? "").Trim();
//    }

//    public string Url 
//    {
//        get => url;
//        set => url = (value ?? "").Trim();
//    }
//}

public class ApiRequest
{
    private Dictionary<string, string> headers = new Dictionary<string, string>();
    private Dictionary<string, string> queryParams = new Dictionary<string, string>();
    private string authenticatorName = "";

    public Guid Id { get; set; }
    public string? Name { get; set; }
    public HttpMethod Method { get; set; }
    public string? BaseUrl { get; set; }
    public string? Resource { get; set; }
    
    public Dictionary<string, string> Headers 
    {
        get => headers;
        set => headers = (value != null ? value : new Dictionary<string, string>());
    }
    
    public Dictionary<string, string> QueryParams
    {
        get => queryParams;
        set => queryParams = (value != null ? value : new Dictionary<string, string>());
    }

    public string AuthenticatorName
    {
        get => authenticatorName;
        set => authenticatorName = (value ?? "").Trim().ToUpperInvariant();
    }

    public string? User { get; set; }
    public string? Pwd { get; set; }
    public string? ClientCertificate { get; set; }
    public bool PrettyPrint { get; set; }
    public string? Body { get; set; }

    public ApiRequest()
    {
        Id = Guid.NewGuid();
        Headers = new Dictionary<string, string>();
        QueryParams = new Dictionary<string, string>();
    }
}


