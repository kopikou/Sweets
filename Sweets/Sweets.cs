using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweets
{
    public class Sweet
    {
        public static Random rnd = new Random();
        public int weight = 0; // вес
        public virtual String GetInfo()
        {
            var str = String.Format("\nВес: {0}", this.weight);
            return str;
        }
        public virtual String GetImg()
        {
            var str = "fruits.jpg";
            //var str = name;
            return str;
            //return name;
        }
    }
    //public enum ChocolateType { dark, milk };
    public enum ChocolateType { темный, молочный };
    public class Chocolate : Sweet
    {
        //public int weight = 0; // вес
        public int number_of_bars = 0; // количество плиток
        public ChocolateType choc_type = ChocolateType.темный; // тип шоколада
        //public String img = "";

        public override String GetInfo()
        {
            var str = "Шоколад";
            str += base.GetInfo();
            str += String.Format("\nКоличество плиток: {0}", this.number_of_bars);
            str += String.Format("\nТип шоколада: {0}", this.choc_type);
            return str;
        }

        public static Chocolate Generate()
        {
            //var rnd = new Random();
            return new Chocolate
            {
                weight = rnd.Next() % 100, // вес от 0 до 100
                number_of_bars = 5 + rnd.Next() % 15, // количество плиток от 5 до 20
                choc_type = (ChocolateType)rnd.Next(2),// тип шоколада
                //img = GetImg(choc_type)
            };
        }
        
        public override String GetImg()
        {
            String str = "..\\..\\..\\..\\static\\chocolate.jpg";
            switch (choc_type)
            {
                case ChocolateType.темный:
                    str = "..\\..\\..\\..\\static\\черншок.jpeg";
                    break;
                case ChocolateType.молочный:
                    str = "..\\..\\..\\..\\static\\молоч.jpg";
                    break;
            }
            return str;
        }
    }
    //public enum BakeryType { bun, pie, cheesecake, cupcake, cookies };
    public enum BakeryType { булочка, пирожок, ватрушка, пирожное, печенье };
    public class Bakery : Sweet
    {
        //public int weight = 0; // вес
        public float energy_value = 0; // энергетическая ценность
        public BakeryType bak_type = BakeryType.булочка; // тип выпечки

        public override String GetInfo()
        {
            var str = "Выпечка";
            str += base.GetInfo();
            str += String.Format("\nЭнергетическая ценность: {0}", this.energy_value);
            str += String.Format("\nТип выпечки: {0}", this.bak_type);
            return str;
        }

        public static Bakery Generate()
        {
            return new Bakery
            {
                weight = rnd.Next() % 100, // вес от 0 до 100
                energy_value = 100 + rnd.Next() % 400, // энергетическая ценность от 100 до 500
                bak_type = (BakeryType)rnd.Next(5) // тип выпечки
            };
        }
        public override String GetImg()
        {
            var str = "..\\..\\..\\..\\static\\bakery.jpg";
            switch (bak_type)
            {
                case BakeryType.булочка:
                    str = "..\\..\\..\\..\\static\\булочка.jpg";
                    break;
                case BakeryType.пирожок:
                    str = "..\\..\\..\\..\\static\\пирожок.jpg";
                    break;
                case BakeryType.ватрушка:
                    str = "..\\..\\..\\..\\static\\ватрушка.jpg";
                    break;
                case BakeryType.пирожное:
                    str = "..\\..\\..\\..\\static\\пирожное.jpg";
                    break;
                case BakeryType.печенье:
                    str = "..\\..\\..\\..\\static\\печенье.jpg";
                    break;
            }
            return str;
        }
    }
    //public enum FruitType { pome, stone_fruit, berries, nuts, tropical };
    public enum FruitType { семечковый, косточковый, ягоды, орехоплодный, тропический };
    public class Fruit : Sweet
    {
        //public int weight = 0; // вес
        public int ripeness = 0; // спеплость
        public FruitType fruit_type = FruitType.семечковый; // тип фрукта

        public override String GetInfo()
        {
            var str = "Фрукт";
            str += base.GetInfo();
            str += String.Format("\nСпелость: {0}", this.ripeness);
            str += String.Format("\nТип фрукта: {0}", this.fruit_type);
            return str; 
        }

        public static Fruit Generate()
        {
            return new Fruit
            {
                weight = rnd.Next() % 100, // вес от 0 до 100
                ripeness = rnd.Next() % 100, // спелость от 0 до 100
                fruit_type = (FruitType)rnd.Next(5) // тип фруктов
                
            };
        }
        public override String GetImg()
        {
            var str = "..\\..\\..\\..\\static\\fruits.jpg";
            switch (fruit_type)
            {
                case FruitType.семечковый:
                    str = "..\\..\\..\\..\\static\\яблоки.jpg";
                    break;
                case FruitType.косточковый:
                    str = "..\\..\\..\\..\\static\\персик.jpg";
                    break;
                case FruitType.ягоды:
                    str = "..\\..\\..\\..\\static\\ягоды.jpg";
                    break;
                case FruitType.орехоплодный:
                    str = "..\\..\\..\\..\\static\\орехи.jpg";
                    break;
                case FruitType.тропический:
                    str = "..\\..\\..\\..\\static\\апельсин.jpg";
                    break;
            }
            return str;
        }
    }
}