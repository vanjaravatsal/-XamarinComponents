using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;

namespace testing
{
	public class Test
	{
		public static object DeserializeItemString(string str)
		{
			BinaryFormatter f = new BinaryFormatter();
			return f.UnsafeDeserialize(null, null);
		}

		public static object TestMethod()
		{
			RijndaelManaged rjMan = new RijndaelManaged();
			return rjMan;
		}
	}
}