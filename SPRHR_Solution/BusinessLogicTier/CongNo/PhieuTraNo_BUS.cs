using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicTier.CongNo
{
    public class PhieuTraNo_BUS
    {

        private string _SoPhieuTraNo;

        private double _TongTien;

        private DateTime _ThoiGian;

        private List<ChiTietPhieuTraNo_BUS> _ChiTietPhieuTraNo_BUSs;
        
       

        public PhieuTraNo_BUS()
        {
           // this._ChiTietPhieuTraNo_BUSs = new List<ChiTietPhieuTraNo_BUS>(new Action<ChiTietPhieuTraNo_BUS>(this.attach_ChiTietPhieuTraNo_BUSs), new Action<ChiTietPhieuTraNo_BUS>(this.detach_ChiTietPhieuTraNo_BUSs));
            
        }

       
        public string SoPhieuTraNo
        {
            get
            {
                return this._SoPhieuTraNo;
            }
            set
            {
                if ((this._SoPhieuTraNo != value))
                {
                  
                }
            }
        }

        
        public double TongTien
        {
            get
            {
                return this._TongTien;
            }
            set
            {
                if ((this._TongTien != value))
                {
                   
                }
            }
        }

       
        public System.DateTime ThoiGian
        {
            get
            {
                return this._ThoiGian;
            }
            set
            {
                if ((this._ThoiGian != value))
                {
                   
                }
            }
        }

       
        public List<ChiTietPhieuTraNo_BUS> ChiTietPhieuTraNo_BUSs
        {
            get
            {
                return this._ChiTietPhieuTraNo_BUSs;
            }
            set
            {
                this._ChiTietPhieuTraNo_BUSs=value;
            }
        }
        

    }
}
