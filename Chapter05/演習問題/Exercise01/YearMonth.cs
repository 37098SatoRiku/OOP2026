using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    //5.1         
    public class YearMonth(int Year, int Month, int Is21Century) {
        public int Year { get; private set; } = Year;
        public int Month { get; private set; } = Month;
        public bool Is21Century => Year <= 2001 && 2100 >= Year;

        public YearMonth AddOneMonth() {
            if(Month == 12) {
                return new YearMonth(Year + 1, 1, Year);
            }
            return new YearMonth(Year, Month + 1, Year);
        }

        public override string ToString() => $"{Year}年{Month}月";
    }
}

