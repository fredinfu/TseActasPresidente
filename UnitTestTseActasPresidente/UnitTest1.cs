using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TseHn2017Application.AppCode.Services;
using TseHn2017Application.AppCode.Context;

namespace UnitTestTseActasPresidente
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]//CLICK DERECHO a TestMethod y luego Debug Tests
        public void FillLocalSqlServerDataBase()
        {
            try
            {
                using (var context = new TseActasPresidenteDbContext())
                {
                    var service = new TseApiToLocalDbContext(context);
                    service.InsertTseApiToLocalDataBase();
                }
                
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
