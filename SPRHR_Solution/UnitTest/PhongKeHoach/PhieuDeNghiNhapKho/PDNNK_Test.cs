using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccessLayer.PhongKeHoach.PhieuDeNghiNhapKho;
using BusinessEntities.PhongKeHoach;
using System.Collections.Generic;

namespace UnitTest.PhongKeHoach.PhieuDeNghiNhapKho
{
    [TestClass]
    public class PDNNK_Test
    {
        [TestMethod]
        public void GetAllPDNNK()
        {
            LapPhieuDeNghiNhapKho_DAL Test = new LapPhieuDeNghiNhapKho_DAL();
            List<ePhieuDeNghiNhapKho> Ls = Test.GetALLPDNNK(); 
        }
    }
}
