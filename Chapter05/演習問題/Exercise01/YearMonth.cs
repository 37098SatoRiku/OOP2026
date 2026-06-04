using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    //5.1         
    public record YearMonth(int Year, int Month) {
        public int Year { get; private set; } = Year;
        public int Month { get; private set; } = Month;

        public bool Is21Century() { 
          if(Year >= 2001 && 2100 >= Year) {
                return true;
            }
            return false;
        }

        public  YearMonth AddOneMonth() {
            if(Month == 12) {
                return new YearMonth(Year + 1, 1);
            }
            return new YearMonth(Year, Month + 1);
        }

        public override string ToString() => $"{Year}年{Month}月";
    }
}

