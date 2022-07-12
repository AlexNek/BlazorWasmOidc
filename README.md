# Blazor web assembly standalone authentification

## Introduction
As long as you want to use only client version there imediatly come problem that you cannot use any private/secret data into your application.
Any private data could be stolen on client side. But how we can manage web site users?
One variant is using external autorization server with OpenID Connection (OIDC).

![image from link1](Docu/images/oidc.png)
*Image from pingidentity.com (link 1)*

OIDC is supported out of the box for blazor standalone web assmely nas .NET 6.0

## Sample application
We create Blazor web assembly standalone project with Visual studio 2022 and .NET 6.0
We try to add different authorization server  to our applications

## Authorization/Identity Server

### Links

1. [OIDC: What Is OpenID Connect and How Does It Work? What You Need to Know](https://www.pingidentity.com/en/resources/content-library/articles/openid-connect.html)
2. [Secure an ASP.NET Core Blazor WebAssembly standalone app with the Authentication library](https://docs.microsoft.com/en-us/aspnet/core/blazor/security/webassembly/standalone-with-authentication-library?view=aspnetcore-7.0&tabs=visual-studio)
3. [OAuth 2.0 and OpenID Connect (OIDC) in the Microsoft identity platform](https://docs.microsoft.com/en-us/azure/active-directory/develop/active-directory-v2-protocols)
4. [Microsoft identity platform and OpenID Connect protocol](https://docs.microsoft.com/en-us/azure/active-directory/develop/v2-protocols-oidc)