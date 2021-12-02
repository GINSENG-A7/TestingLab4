using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingLab4
{
	[TestFixture]
	public class Tests
	{
		//[Test]
		//public void IsCorrectTest()
		//      {
		//	Assert.Throws<ArgumentException>(() =>
		//	{
		//		ArgumentException("Значение версии не может быть распознано корректно");
		//	});
		//}
		//[Test]
		//public void MoreTest()
		//{
		//	Assert.Throws<ArgumentException>(() =>
		//	{
		//		_ = new Versions("1.0,0-beta.alpha") > new Versions("1.0.0-beta.1");
		//	});

		//	Assert.Throws<ArgumentException>(() =>
		//	{
		//		_ = new Versions("QWERTY") > new Versions("1.0.0-beta.1");
		//	});

		//	Assert.Throws<ArgumentException>(() =>
		//	{
		//		Versions version = new Versions("10.5.1-aplha.beta");
		//	});

		//	Assert.IsTrue(new Versions("1.0.0-alpha.1") > new Versions("1.0.0-alpha.beta"));
		//	Assert.IsTrue(new Versions("1.0.0") > new Versions("1.0.0-alpha"));
		//	Assert.IsTrue(new Versions("1.0.1") > new Versions("1.0.0"));
		//	Assert.IsTrue(new Versions("1.1.0") > new Versions("1.0.0"));
		//	Assert.IsTrue(new Versions("1.1.1") > new Versions("1.1.0"));

		//	Assert.IsFalse(new Versions("0.0.9-alpha.5") > new Versions("0.10.0-beta.10.5"));
		//	Assert.IsFalse(new Versions("4.1.9-1") > new Versions("5.9.0-5"));
		//	Assert.IsFalse(new Versions("7.1.4-1") > new Versions("7.1.5-1"));
		//	Assert.IsFalse(new Versions("0.1.9-1") > new Versions("0.2.0-5"));
		//}

		//[Test]
		//public void LessTest()
		//{
		//	Assert.Throws<ArgumentException>(() =>
		//	{
		//		_ = new Versions("?.!,0-beta.alpha") > new Versions("1.0.0-alpha.1");
		//	});

		//	Assert.IsTrue(new Versions("1.0.0-beta.alpha") < new Versions("1.0.0-beta.1"));
		//	Assert.IsTrue(new Versions("5.5.4-beta.1") < new Versions("5.5.5-beta.alpha"));
		//	Assert.IsTrue(new Versions("0.1.1-beta.1") < new Versions("0.1.2-beta.alpha"));

		//	Assert.IsFalse(new Versions("54.48.89") < new Versions("54.48.80-alpha"));
		//	Assert.IsFalse(new Versions("8.14.16") < new Versions("8.14.15"));
		//	Assert.IsFalse(new Versions("1.0.8-beta.1") < new Versions("1.0.8-beta.0"));
		//}

		//[Test]
		//public void MoreOrEqualTest()
		//{
		//	Assert.IsTrue(new Versions("1.1.0") >= new Versions("1.0.0"));
		//	Assert.IsTrue(new Versions("4.6.7") >= new Versions("4.6.0"));
		//	Assert.IsTrue(new Versions("5.5.5") >= new Versions("5.5.5-alpha"));

		//	Assert.IsFalse(new Versions("5.10.45") >= new Versions("5.10.46"));
		//	Assert.IsFalse(new Versions("40.50.40") >= new Versions("40.50.45"));
		//	Assert.IsFalse(new Versions("10.1.5-alpha.54.beta") >= new Versions("10.1.5-alpha.54.1"));
		//}

		//[Test]
		//public void LessOrEqualTest()
		//{
		//	Assert.IsTrue(new Versions("1.0.0") <= new Versions("1.1.0"));
		//	Assert.IsTrue(new Versions("4.8.0") <= new Versions("4.9.1"));
		//	Assert.IsTrue(new Versions("40.40.40-alpha") <= new Versions("40.40.40"));
		//	Assert.IsTrue(new Versions("0.1.0-alpha") <= new Versions("0.1.0-alpha"));

		//	Assert.IsFalse(new Versions("5.8.1-alpha") <= new Versions("4.8.7-alpha"));
		//	Assert.IsFalse(new Versions("4.1.7-alpha.5") <= new Versions("4.1.7-alpha.1"));
		//	Assert.IsFalse(new Versions("50.80.1-1") <= new Versions("50.80.1-alpha")); // here
		//}

		//[Test]
		//public void EqualTest()
		//{
		//	Assert.IsTrue(new Versions("0.0.0") == new Versions("0.0.0"));
		//	Assert.IsTrue(new Versions("5.1.1") == new Versions("5.1.1"));
		//	Assert.IsTrue(new Versions("1.1.1-beta") == new Versions("1.1.1-beta"));

		//	Assert.IsFalse(new Versions("50.10.8") == new Versions("50.10.9"));
		//	Assert.IsFalse(new Versions("40.88.99-alpha") == new Versions("40.88.99-alpha.5"));
		//	Assert.IsFalse(new Versions("80.10.7-alpha") == new Versions("80.10.7"));
		//}

		//[Test]
		//public void NoEqualTest()
		//{
		//	Assert.Throws<ArgumentException>(() =>
		//	{
		//		bool metka = new Versions("1.0,0-beta.alpha") > new Versions("qwerty");
		//	});

		//	Assert.IsTrue(new Versions("1.0.0") != new Versions("1.0.1"));
		//	Assert.IsTrue(new Versions("5.1.5-alpha") != new Versions("5.1.5"));
		//	Assert.IsTrue(new Versions("10.44.1-alpha.beta") != new Versions("10.44.1-alpha.beta.1"));
		//	Assert.IsFalse(new Versions("1.0.0") != new Versions("1.0.0"));
		//	Assert.IsFalse(new Versions("8.7.4-1") != new Versions("8.7.4-1"));
		//}

		//[Test]
		//public void ToStringTest()
		//{
		//	Assert.AreEqual("1.0.0", new Versions("1.0.0").ToString());
		//	Assert.AreEqual("1.1.1-alpha", new Versions("1.1.1-alpha").ToString());
		//	Assert.AreEqual("10.50.1-alpha.beta.1", new Versions("10.50.1-alpha.beta.1").ToString());
		//}
		[Test]
		public void IntersectionTest()
        {
			Assert.AreEqual
				(
					new VersionsInterval(new Versions("0.0.0"), new Versions("2.0.0")).ToString(),
					VersionsInterval.Intersection
					(
						new VersionsInterval(new Versions("1.0.0"), new Versions("2.0.0")),
						new VersionsInterval("<=1.5.0")
					)[0].ToString()
				);
		}
		[Test]
		public void UnionTest()
        {
			Assert.AreEqual
				(
					new VersionsInterval(new Versions("0.0.0"), new Versions("1.5.0")).ToString(),
					VersionsInterval.Union
					(
						new VersionsInterval(new Versions("1.0.0"), new Versions("2.0.0")),
						new VersionsInterval("<=1.5.0")
					)[0].ToString()
				);
		}
		[Test]
		public void ToStringTest()
        {
			Assert.AreEqual("from 0.0.0 to 5.2.0" , new VersionsInterval("<=5.2.0").ToString());

			Assert.AreEqual("from 4.2.0 to 6.1.8", new VersionsInterval( new Versions("4.2.0"), new Versions("6.1.8")).ToString());
		}
	}
}
