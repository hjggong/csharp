using System;
using System.Collections;
using System.Collections.Generic;

namespace Day2
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

        public String ToString()
        {
            return "Goods[상품번호: "+goodsno+", 상품명: "+gname+", 단가: "+danga+"]";
        }
    }

    class Cart
    {
        public Goods goods { get; set; }
        public int count { get; set; }
        public int sum { get { return count * goods.danga; } set { } }

        public Cart(Goods goods, int count)
        {
            this.goods = goods;
            this.count = count;
            sum = count * goods.danga;
        }

        public String ToString()
        {
            return "Cart[Goods: " + goods + ", count: " + count + ", sum: " + sum + "]";
        }
    }
    
    class Program12
    {
        static void Main()
        {
            Goods g1 = new Goods(1001, "볼펜", 1000);
            Goods g2 = new Goods(1002, "연필", 500);
            Goods g3 = new Goods(1003, "딸기", 6000);

            Hashtable obj = new Hashtable();
        }
    }
}
