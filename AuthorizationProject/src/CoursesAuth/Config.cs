using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using IdentityServer4.Models;
using IdentityServer4.Services.InMemory;

namespace CoursesAuth
{
    public class Config
    {
        public static IEnumerable<Scope> GetScopes()
        {
            return new List<Scope>
            {
                new Scope
                {
                    Name = "CoursesAPI",
                    Description = "An API for retrieving courses for the University of Helsinki",
                    IncludeAllClaimsForUser = true
                }
            };
        }

        public static List<InMemoryUser> GetUsers()
        {
            return new List<InMemoryUser>
        {
            new InMemoryUser
            {
                Subject = "1",
                Username = "alice",
                Password = "password",
                Claims = new Claim[]
                {
                    new Claim("IsTeacher", "true"),
                }
            },
            new InMemoryUser
            {
                Subject = "2",
                Username = "bob",
                Password = "password",
                Claims = new Claim[]
                {
                    new Claim("IsStudent", "true"),
                }
            }
        };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "client",
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                    ClientSecrets = new List<Secret>
                    {
                        new Secret("secret".Sha256())
                    },
                    AllowedScopes = new List<string>
                    {
                        "CoursesAPI"
                    }
                }
            };
        }
    }
}
