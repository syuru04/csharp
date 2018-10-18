﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    public class Animation
    {
        private int total; // 총 애니메이션 편수
        private string distributor; //유통사
        private string date; //제작날짜
        private int price; //가격
        private string[] title; //제목

        public Animation(int total, string distributor, string date, int price)
        {
            this.total = total;
            this.distributor = distributor;
            this.date = date;
            this.price = price;
            this.title = new string[total];
        }

        public string this[int index]
        {
            get { return title[index]; } 
            set { title[index] = value; }
        }

        public string getDistributor()
        {
            return distributor;
        }
        public int getPrice()
        {
            return price;
        }
        public int getTotal()
        {
            return total;
        }

        static void Main(string[] args)
        {
            Animation ani = new Animation(5, "한국애니", "10-27-2004", 35000);
            ani[0] = "인어공주";
            ani[1] = "신데렐라";
            ani[2] = "백설공주";
            ani[3] = "바보온달";
            ani[4] = "라이온킹";
            Console.WriteLine("가격: {0}", ani.getPrice());
            Console.WriteLine("----------------------------");
            for (int i = 0; i < ani.getTotal(); i++)
            {
                Console.WriteLine("Volume{0} : {1}", i, ani[i]);
            }


        }
    }
}