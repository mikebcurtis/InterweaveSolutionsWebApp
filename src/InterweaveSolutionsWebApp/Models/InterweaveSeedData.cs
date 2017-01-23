using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterweaveSolutionsWebApp.Models
{
    public class InterweaveSeedData
    {
        private InterweaveContext _context;
        private UserManager<InterweaveUser> _userManager;

        public InterweaveSeedData(InterweaveContext context, UserManager<InterweaveUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task PopulateDevelopmentSeedData()
        {
            string testPassword = "P@ssw0rd!";

            if (await _userManager.FindByEmailAsync("testSA1@interweavesolutions.org") == null)
            {
                InterweaveUser testUser = new InterweaveUser()
                {
                    UserName = "testSA1",
                    Email = "testSA1@interweavesolutions.org",
                    CertificateID = "TEST_CERTIFICATE_TESTSA1"
                };

                await _userManager.CreateAsync(testUser, testPassword);
            }

            if (await _userManager.FindByEmailAsync("testAdmin1@interweavesolutions.org") == null)
            {
                InterweaveUser testUser = new InterweaveUser()
                {
                    UserName = "testAdmin1",
                    Email = "testAdmin1@interweavesolutions.org",
                    CertificateID = "TEST_CERTIFICATE_TESTADMIN1"
                };

                await _userManager.CreateAsync(testUser, testPassword);
            }

            if (await _userManager.FindByEmailAsync("testStudent1@interweavesolutions.org") == null)
            {
                InterweaveUser testUser = new InterweaveUser()
                {
                    UserName = "testStudent1",
                    Email = "testStudent1@interweavesolutions.org",
                    CertificateID = ""
                };

                await _userManager.CreateAsync(testUser, testPassword);
            }
        }
    }
}
