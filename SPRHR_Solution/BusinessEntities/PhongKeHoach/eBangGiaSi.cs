using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.PhongKeHoach
{
    public class eBangGiaSi
    {
        public string MaSp { get; set; }
        public decimal GiaBanSi { get; set; }
        public eBangGiaSi()
        {
            this.MaSp = "";
            this.GiaBanSi = 0;

        }
        public eBangGiaSi(string masp,decimal giabansi)
        {
            this.MaSp = masp;
            this.GiaBanSi = giabansi;

        }
        public override bool Equals(object obj)
        {
            eBangGiaSi a = (eBangGiaSi)obj;
            return this.MaSp.ToLower().Equals(a.MaSp.ToLower());
        }
        public override int GetHashCode()
        {
            return this.MaSp.ToLower().GetHashCode();
        }
    }
}
