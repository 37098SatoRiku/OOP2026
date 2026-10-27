namespace DistanceConverter {
    public class MeterConverter : ConverterBase {
        public override bool IsMyUnit(string name) => name is "meter" || name == UnitName;
        protected override double Ratio => 1;
        public override string UnitName => "メートル";
    }

    public class KilometerConverter : ConverterBase {
        public override bool IsMyUnit(string name) => name is "kilometer" || name == UnitName;
        protected override double Ratio => 1000;
        public override string UnitName => "キロメートル";
    }

    public class FeetConverter : ConverterBase {
        public override bool IsMyUnit(string name) => name is "feet" || name == UnitName;
        protected override double Ratio => 0.3048;
        public override string UnitName => "フィート";
    }

    public class InchConverter : ConverterBase {
        public override bool IsMyUnit(string name) => name is "inch" || name == UnitName;
        protected override double Ratio => 0.0254;
        public override string UnitName => "インチ";
    }

    public class YardConverter : ConverterBase {
        public override bool IsMyUnit(string name) => name is "yard" || name == UnitName;
        protected override double Ratio => 0.9144 ;
        public override string UnitName => "ヤード";
    }

    public class MileConverter : ConverterBase {
        public override bool IsMyUnit(string name) => name is "mile" || name == UnitName;
        protected override double Ratio => 1609.344;
        public override string UnitName => "マイル";
    }
}
