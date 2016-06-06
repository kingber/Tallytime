using System;
using NUnit.Framework;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using System.Net;
using System.Web;
using TallytimeWebApp.Models;

namespace TallytimeUnitTest
{
    [TestFixture]
    public class UnitTest1
    {
        Session session = new Session();
        
        [Test]
        public void SessionsTest_Create()
        {
            string result = session.Session(!null);
            Assert.AreEqual(session.GetType().Session, result);
            // assert that the expected result
        }
    }
}