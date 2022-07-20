using MarsFramework.Pages;
using NUnit.Framework;
using System.Threading;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {

            [Test]
            [System.Obsolete]
            public void UserAccount()
            {
                // SignIn obj = new SignIn();
                // obj.LoginSteps();

                // Profile obj = new Profile();
                // obj.EditProfile();

             //   ShareSkill obj = new ShareSkill();
              //   obj.EnterShareSkill();

                ManageListings obj = new ManageListings();
               obj.Listings();



            }



        }
    }
}