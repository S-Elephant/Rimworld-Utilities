using NUnit.Framework;
using SquirtingElephant.Helpers;
using UnityEngine;

namespace AllTests
{
    public class RectTests
    {
        [Test]
        public void RectExtensions1()
        {
            Rect a = new Rect(1, 2, 3, 4);
            Rect b = new Rect(10, 20, -30, -40);
            Rect c = a.Add(b);
            
            Assert.AreEqual(11, c.x);
            Assert.AreEqual(22, c.y);
            Assert.AreEqual(-27, c.width);
            Assert.AreEqual(-36, c.height);

            c = b.Subtract(a);
            Assert.AreEqual(9, c.x);
            Assert.AreEqual(18, c.y);
            Assert.AreEqual(-33, c.width);
            Assert.AreEqual(-44, c.height);
        }
        
        [Test]
        public void RectExtensions2()
        {
            Rect a = new Rect(10, 20, 30, 40);
            
            Assert.AreEqual(20, a.Add_X(10).x);
            Assert.AreEqual(0, a.Add_X(-10).x);
            Assert.AreEqual(40, a.Add_Y(20).y);
            Assert.AreEqual(60, a.Add_Width(30).width);
            Assert.AreEqual(80, a.Add_Height(40).height);
        }
        
        [Test]
        public void RectReplacementExtensions()
        {
            Rect a = new Rect(10, 20, 30, 40);
            
            Assert.AreEqual(100, a.Replace_X(100).x);
            Assert.AreEqual(100, a.Replace_Y(100).y);
            Assert.AreEqual(100, a.Replace_Width(100).width);
            Assert.AreEqual(100, a.Replace_Height(100).height);
        }
    }
}