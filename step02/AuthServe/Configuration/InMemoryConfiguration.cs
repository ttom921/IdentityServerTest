﻿using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthServe.Configuration
{
    public class InMemoryConfiguration
    {
        public static IEnumerable<ApiResource> ApiResources()
        {
            return new[]
            {
                new ApiResource("socialnetwork","社交網路")
            };
        }
        public static IEnumerable<Client> Clients()
        {
            return new[]
            {
                new Client
                {
                    ClientId = "socialnetwork",
                    ClientSecrets = new []{ new Secret("secret".Sha256())},
                    AllowedGrantTypes= GrantTypes.ResourceOwnerPasswordAndClientCredentials,
                    AllowedScopes= new []{ "socialnetwork" }
                    
                }
            };
        }
        public static IEnumerable<TestUser> Users()
        {
            return new[]
            {
                new TestUser
                {
                    SubjectId = "1",
                    Username="test",
                    Password="1234"
                }
            };
        }
    }
}
