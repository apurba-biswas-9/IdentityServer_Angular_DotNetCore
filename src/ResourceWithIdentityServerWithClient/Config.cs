// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using IdentityServer4.Models;
using System.Collections.Generic;

namespace QuickstartIdentityServer
{
    using System.Security.Claims;

    public class Config
    {
        public static string HOST_URL = "https://localhost:44363";
        public static string HOST_URL1 = "http://localhost:4200";

        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email(),
                new IdentityResource("dataeventrecordsscope",new []{ "role", "admin", "user", "dataEventRecords", "dataEventRecords.admin" , "dataEventRecords.user" } ),
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("dataEventRecords")
                {
                    ApiSecrets =
                    {
                        new Secret("dataEventRecordsSecret".Sha256())
                    },
                    Scopes =
                    {
                        new Scope
                        {
                            Name = "dataeventrecords",
                            DisplayName = "Scope for the dataEventRecords ApiResource"
                        }
                    },
                    UserClaims = { "role", "admin", "user", "dataEventRecords", "dataEventRecords.admin", "dataEventRecords.user" }
                },
                 new ApiResource("securedFiles")
                 {

                 }
            };
        }

        // clients want to access resources (aka scopes)
        public static IEnumerable<Client> GetClients()
        {
            // client credentials client

            return new List<Client>
            {
                new Client
                {
                    
                    //ClientName = "singleapp",
                    //ClientId = "singleapp",
                    //AccessTokenType = AccessTokenType.Reference,
                    ////AccessTokenLifetime = 600, // 10 minutes, default 60 minutes
                    //AllowedGrantTypes = GrantTypes.Implicit,
                    //RequireConsent = false,
                    //AllowAccessTokensViaBrowser = true,
                    //RedirectUris = new List<string>
                    //{
                    //     HOST_URL1,
                    //     HOST_URL1 + "/silent-renew.html"

                    //},
                    //PostLogoutRedirectUris = new List<string>
                    //{
                    //     HOST_URL1
                    //},
                    //AllowedCorsOrigins = new List<string>
                    //{
                    //     HOST_URL1
                    //},
                    //AllowedScopes = new List<string>
                    //{
                    //    "openid",
                    //    "dataEventRecords",
                    //    "dataeventrecordsscope",
                    //    "securedFiles",
                    //    "securedfilesscope",
                    //    "role"
                    //}

                     //Code
                     ClientName = "angular_code_client",
                      ClientId = "angular_code_client",
    AccessTokenType = AccessTokenType.Reference,
    // RequireConsent = false,
    AccessTokenLifetime = 330,// 330 seconds, default 60 minutes
    IdentityTokenLifetime = 30,

    RequireClientSecret = false,
    AllowedGrantTypes = GrantTypes.Code,
    RequirePkce = true,

    AllowAccessTokensViaBrowser = true,
    RedirectUris = new List<string>
    {
        "https://localhost:4200",
        "https://localhost:4200/silent-renew.html"

    },
    PostLogoutRedirectUris = new List<string>
    {
        "https://localhost:4200/unauthorized",
        "https://localhost:4200"
    },
    AllowedCorsOrigins = new List<string>
    {
        "https://localhost:4200"
    },
    AllowedScopes = new List<string>
    {
        "openid",
        "dataEventRecords",
        "dataeventrecordsscope",
        "securedFiles",
        "securedfilesscope",
        "role",
        "profile",
        "email"
    }
                }
            };
        }
    }
}