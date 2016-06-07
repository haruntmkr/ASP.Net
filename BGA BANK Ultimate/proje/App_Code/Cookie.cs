using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Cookie
/// </summary>
public class Cookie
{
    const String mycookie = "httpcookie";
    HttpCookie cookie = new HttpCookie(mycookie);

	public Cookie()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public void cookie_olustur(string anahtar,string ikincil_anahtar )
    {
        var Response = HttpContext.Current.Response;
        cookie.Values.Add(anahtar, ikincil_anahtar);
        cookie.Expires = DateTime.Now.AddHours(12);
        Response.Cookies.Add(cookie);
    
    
    }

    public String oku(String anahtar) 
    {
        var Request = HttpContext.Current.Request;
        if (Request.Cookies[mycookie][anahtar] != null)
            return Request.Cookies[mycookie][anahtar];
        else
            return "0";
    }
    public int cookie_durumu(String anahtar) 
    {
        var Request = HttpContext.Current.Request;
        if (Request.Cookies[mycookie] != null && Request.Cookies[mycookie][anahtar] != null)
        {
            return 1;
        }
        return 0;
    
    
    
    }

    public int cookie_durumu()
    {
        var Request = HttpContext.Current.Request;
        if (Request.Cookies[mycookie] != null)
        {
            return 1;
        }
        return 0;
    }

    public void yoket() 
    {
        var Request = HttpContext.Current.Request;
        var Response = HttpContext.Current.Response;
        if (Convert.ToBoolean(cookie_durumu()))
        {
            cookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(cookie);
        }
    
    
    }



}