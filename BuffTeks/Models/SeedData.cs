using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace BuffTeks.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BuffTeksDBContext(
                serviceProvider.GetRequiredService<DbContextOptions<BuffTeksDBContext>>()))
            {
                // // Look for any clients.
                // if (context.Clients.Any())
                // {
                //     return;   // DB has been seeded
                // }

                // context.Clients.AddRange(
                //     new Client
                //     {
                //         CompanyName= "Montague Corp",
                //         CompanyPhone ="753-1599",
                //         CompanyEmail ="help@montague.com",
                //         ComapnyLiaison="Romeo",
                //         LiaisonNumber="753-7894",
                //         ProjectName = "Libra",
                //     },
                //     new Client
                //     {
                //         CompanyName= "Capulet Corp",
                //         CompanyPhone ="951-3577",
                //         CompanyEmail ="help@capulet.com",
                //         ComapnyLiaison="Juliet",
                //         LiaisonNumber="951-1234",
                //         ProjectName = "Virgo",
                //     }
                // );
                // Look for any projecs.
                // if (context.Projects.Any())
                // {
                //     return;   // DB has been seeded
                // }

                // context.Projects.AddRange(
                //     new Project
                //     {
                //         ProjectName = "Libra",
                //         // ProjectClient = "Montague Corp",
                //         // MemberLiaison = "Julius",
                //         // CompanyLiaison = "Juliet"
                //     },
                //     new Project
                //     {
                //         ProjectName = "Virgo",
                //         // ProjectClient = "Capulet Corp",
                //         // MemberLiaison = "Mattis",
                //         // CompanyLiaison = "Romeo",
                //     }
                // );
                // Look for any members.
                // if (context.Members.Any())
                // {
                //     return;   // DB has been seeded
                // }

                // context.Members.AddRange(
                //      new Member
                //      {
                //         StudentID ="123",
                //         FName="George",
                //         LName ="Patton",
                //         Major="CIS",
                //         PhoneNumber="123-4567",
                //         Email="george@gmail.com",
                //          ProjectName = "Virgo",
                //      },
                //      new Member
                //      {
                //         StudentID ="456",
                //         FName="Ching",
                //         LName ="Shih",
                //         Major="CIDM",
                //         PhoneNumber="456-7891",
                //         Email="ching@gmail.com",
                //          ProjectName = "Virgo",
                //      },
                //      new Member
                //      {
                //         StudentID ="789",
                //         FName="Julius",
                //         LName ="Caesar",
                //         Major="CIS",
                //         PhoneNumber="789-1234",
                //         Email="ceaser@gmail.com",
                //         ProjectName = "Libra",
                //      },
                //      new Member
                //      {
                //         StudentID ="321",
                //         FName="Napoleon",
                //         LName ="Bonaparte",
                //         Major="CS",
                //         PhoneNumber="456-7981",
                //         Email="napoleon@gmail.com",
                //          ProjectName = "Virgo",
                //      },
                //      new Member
                //      {
                //         StudentID ="654",
                //         FName="James",
                //         LName ="Mattis",
                //         Major="CIS",
                //         PhoneNumber="321-3214",
                //         Email="james@gmail.com",
                //         ProjectName = "Libra",
                //      },
                //      new Member
                //      {
                //         StudentID ="987",
                //         FName="Genghis",
                //         LName ="Khan",
                //         Major="CIDM",
                //         PhoneNumber="654-7891",
                //         Email="genghis@gmail.com"
                //      }
                // );
                
                context.SaveChanges();
            }
            
            // using (var context = new context(serviceProvider.GetRequiredService<DbContextOptions<context>>()))
            // {
            //     // Look for any movies.
            //     if (context.Client.Any())
            //     {
            //         return;   // DB has been seeded
            //     }

            //     context.Client.AddRange(
            //         new Client
            //         {
            //             CompanyName= "Montague Corp",
            //             CompanyPhone ="753-1599",
            //             CompanyEmail ="help@montague.com",
            //             ComapnyLiaison="Romeo",
            //             LiaisonNumber="753-7894"
            //         },
            //         new Client
            //         {
            //             CompanyName= "Capulet Corp",
            //             CompanyPhone ="951-3577",
            //             CompanyEmail ="help@capulet.com",
            //             ComapnyLiaison="Juliet",
            //             LiaisonNumber="951-1234"
            //         }
            //     );
            //     context.SaveChanges();
            // }
        }
    }
}