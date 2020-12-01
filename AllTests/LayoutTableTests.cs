using System;
using NUnit.Framework;
using SquirtingElephant.Helpers;
using UnityEngine;

namespace AllTests
{
    public class LayoutTableTests
    {
        private TableData _tableData;
        
        [SetUp]
        public void Setup()
        {
            _tableData = new TableData(new Vector2(10f, 10f), Vector2.zero, new[] { 100f }, new[] { 10f }, 3, 3);
        }
        
        [Test]
        public void GenericTests()
        {
            Assert.AreEqual(10f, _tableData.TableRect.x);
            Assert.AreEqual(10f, _tableData.TableRect.y);
            Assert.AreEqual(300f, _tableData.TableRect.width);
            Assert.AreEqual(40f, _tableData.Bottom);
        }

        [Test]
        public void RowTests()
        {
            TableRow row = _tableData.Rows[1];
            
            Assert.AreEqual(10f, row.Rect.x);
            Assert.AreEqual(20f, row.Rect.y);
            Assert.AreEqual(300f, row.Rect.width);
            Assert.AreEqual(10f, row.Rect.height);
            Assert.AreEqual(10f, row.Height);
        }

        [Test]
        public void ColumnTests()
        {
            TableColumn column = _tableData.Columns[1];
            
            Assert.AreEqual(110f, column.Rect.x);
            Assert.AreEqual(10f, column.Rect.y);
            Assert.AreEqual(100f, column.Rect.width);
            Assert.AreEqual(30f, _tableData.TableRect.height);
        }
    }
}