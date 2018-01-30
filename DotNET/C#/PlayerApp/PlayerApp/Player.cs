using System;

namespace PlayerApp
{
    class Player
    {
        private int _id;
        private String _name;
        private int _age;

        public Player(int id, String name)
        {
            _id = id;
            _name = name;
        }

        public Player(int id, String name, int age)
        {
            _id = id;
            _name = name;
            _age = age;
        }

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public String Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        public override string ToString()
        {
            String result = " Id\t:" + Id + "\n Name\t:" + Name
                + " \n Age\t:" + Age;
            return result;
        }

        public Player whoIsElder(Player player)
        {
            return Age > player.Age ? this : player;
        }

        public override bool Equals(object obj)
        {
            return Id.Equals(obj);
        }

    }
}
