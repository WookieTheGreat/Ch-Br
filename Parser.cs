using System;
using System.IO;

namespace ChBr
{
	public class Parser
	{
		public Parser (string file)
		{
			string code = System.IO.File.ReadAllText (file);
			string[] bytes = code.Split (' ');

			if (bytes[0] != "anoo" || bytes[bytes.Length-1] != "vdamke"){
				Console.WriteLine ("COMPILER ERROR");
			} else {
				for (int i = 0; i < bytes.Length; i++) {
					switch (bytes [i]) {
					case "anoo":
						Console.Write ("ANOO ");
					break;
					case "ch":
						Console.Write ("CHEEKI ");
					break;
					case "br":
						Console.Write ("BREEKI ");
					break;
					case "vdamke":
						Console.Write ("VDAMKE ");
					break;
					}
				}
			}
			Console.ReadLine ();
		}
	}
}

