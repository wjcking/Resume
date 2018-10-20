/*
 * Created by SharpDevelop.
 * User: lenovo
 * Date: 2018-10-19
 * Time: 16:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using NUnit.Framework;
using SimpleSpreadsheet;
namespace UnitTest
{
	[TestFixture]
	public class Test1
	{
		[Test]
		public void TestCount()
		{ 
			Console.WriteLine("------------------------------------------------------------------".Length.ToString());
		}
		[Test]
		public void TestInput()
		{ 
			Command.GetResult("C 20 4");
		}
		[Test]
		public void TestInputEmpty()
		{
			 
			Command.GetResult(string.Empty);
		}
		[Test]
		public void TestSheetsEmpty()
		{
 
		}
	 
		[Test]
		public void Test2dArray()
		{
			int[,] vectors= new int[3,3];
			vectors[0,0] = 334;
			foreach(var v in vectors)
			{
				Console.WriteLine(v.ToString( )); 
			}
//			for (int i=0;i<vectors.Length;i++)
//			{
//				
//				Console.WriteLine(i.ToString() +":"+   vectors[i][0].ToString());
//			}
		}
	}
}
