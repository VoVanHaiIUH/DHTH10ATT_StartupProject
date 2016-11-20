using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccessLayer.CongNo;
using BusinessEntities.CongNo;

namespace UnitTest.CongNo
{
    [TestClass]
    public class TestKH
    {
        CongNo_ALL_DAL CN = new CongNo_ALL_DAL();
        [TestMethod]
        public void TestTraNoKH()
        {
            eChiTietPhieuTraNoKhachHang ect = new eChiTietPhieuTraNoKhachHang();
            
        }
    }
}
