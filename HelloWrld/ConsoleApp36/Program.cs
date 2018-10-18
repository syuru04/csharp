using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApplication6
{
    class Goods
    {
        public int goodsno { get; set; }
        public string gname { get; set; }
        public int danga { get; set; }

        public Goods(int goodsno, string gname, int danga)
        {
            this.goodsno = goodsno;
            this.gname = gname;
            this.danga = danga;
        }

        public override String ToString()
        {
            return "Goods [상품번호=" + goodsno + ", 상품명=" + gname + ", 단가="
                    + danga + "]";
        }
    }

    class Cart
    {
        public Goods goods { get; set; }
        public int count { get; set; }
        public int sum { get; set; }

        public Cart(Goods goods, int count)
        {
            this.goods = goods;
            this.count = count;
            sum = count * goods.danga;
        }

        public override String ToString()
        {
            return "Cart [Goods=" + goods + ", count=" + count + ", sum=" + sum
                    + "]";
        }
    }

    class CartTest
    {
        static void Main()
        {
            Goods g1 = new Goods(1001, "볼펜", 2000);
            Goods g2 = new Goods(1002, "연필", 500);
            Goods g3 = new Goods(1003, "딸기", 6000);

            Dictionary<int, Cart> onj = new Dictionary<int, Cart>();
            onj.Add(1,new Cart() { goods = g1, count = 2 });



            foreach (KeyValuePair<int, Cart> d in onj)
            {
                Console.WriteLine("Key = {0}, Value = {1}", d.Key, d.Value);
            }
        }
    }
}