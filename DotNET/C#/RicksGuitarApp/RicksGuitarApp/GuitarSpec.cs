namespace RicksGuitarApp
{
    class GuitarSpec
    {
        private Builder _builder;
        private string _model;
        private Type _type;
        private int _numStrings;
        private Wood _backWood;
        private Wood _topWood;

        public GuitarSpec(Builder builder, string model, Type type, int numStrings,
            Wood backWood, Wood topWood)
        {
            _builder = builder;
            _model = model;
            _type = type;
            _numStrings = numStrings;
            _backWood = backWood;
            _topWood = topWood;
        }

        public Builder Builder
        {
            get
            {
                return _builder;
            }
        }

        public string Model
        {
            get
            {
                return _model;
            }
        }

        public Type Type
        {
            get
            {
                return _type;
            }
        }

        public int NumStrings
        {
            get
            {
                return _numStrings;
            }
        }

        public Wood TopWood
        {
            get
            {
                return _topWood;
            }
        }

        public Wood BackWood
        {
            get
            {
                return _backWood;
            }
        }

        public bool matches(GuitarSpec otherSpec)
        {
            if (Builder != otherSpec.Builder)
                return false;
            if ((Model != null) && (!Model.Equals(""))
                    && (!Model.ToLower().Equals(otherSpec.Model.ToLower())))
                return false;
            if (Type != otherSpec.Type)
                return false;
            if (NumStrings != otherSpec.NumStrings)
                return false;
            if (BackWood != otherSpec.BackWood)
                return false;
            if (TopWood != otherSpec.TopWood)
                return false;
            return true;
        }
    }
}