﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShipperCar;
using System.Collections.Generic;

namespace ShiiperCarTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void 只買一本書價格期望為100元()
        {
            List<Book> books = new List<Book>() {
                new Book() {  Name="哈利波特",Version="1", Quantity=1 }
            };

            OrderShiiperCar shipperCarOb = new OrderShiiperCar();
            var expected = 100;
            var actual = shipperCarOb.TotalValue(books);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 第一集買了一本而且第二集也買了一本期望為190()
        {
            //期望第二本有0.95折扣，但不同版本
            List<Book> books = new List<Book>() {
                new Book() {  Name="哈利波特",Version="1", Quantity=1 },
                new Book() {  Name="哈利波特",Version="2", Quantity=1 }
            };

            OrderShiiperCar shipperCarOb = new OrderShiiperCar();
            var expected = 190;
            var actual = shipperCarOb.TotalValue(books);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void 一二三集各買了一本期望為270()
        {
            //期望第三本有0.9折扣，但不同版本
            List<Book> books = new List<Book>() {
                new Book() {  Name="哈利波特",Version="1", Quantity=1 },
                new Book() {  Name="哈利波特",Version="2", Quantity=1 },
                new Book() {  Name="哈利波特",Version="3", Quantity=1 }
            };

            OrderShiiperCar shipperCarOb = new OrderShiiperCar();
            var expected = 270;
            var actual = shipperCarOb.TotalValue(books);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void 一二三四集各買了一本期望為320()
        {
            //期望第二本有0.8折扣，但不同版本
            List<Book> books = new List<Book>() {
                new Book() {  Name="哈利波特",Version="1", Quantity=1 },
                new Book() {  Name="哈利波特",Version="2", Quantity=1 },
                new Book() {  Name="哈利波特",Version="3", Quantity=1 },
                new Book() {  Name="哈利波特",Version="4", Quantity=1 }
            };

            OrderShiiperCar shipperCarOb = new OrderShiiperCar();
            var expected = 320;
            var actual = shipperCarOb.TotalValue(books);
            Assert.AreEqual(expected, actual);
        }
    }
}
