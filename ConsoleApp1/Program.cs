using System;
using System.IO;

namespace ConsoleApp1 {
	public class Session
	{
		
		string dir = "C:\\Users\\lulag\\source\\repos\\windows_Programing_lab\\text.txt";
		


		
		public void recordSession(string userName, string session)
		{


			FileStream fs = new FileStream(dir, FileMode.Append, FileAccess.Write);
			
			
			StreamWriter sw = new StreamWriter(fs);
			//BinaryWriter bw = new BinaryWriter(fs);
			sw.WriteLine(userName + "\t" + session + "\t" + DateTime.Now);
			sw.Flush();
			sw.Close();
			fs.Close();
			Console.WriteLine("session recorded");

		}
		public void displaySession()
        {
			int newline=0;
			FileStream fs = new FileStream(dir, FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(fs);
			sr.BaseStream.Seek(0, SeekOrigin.Begin);
			string str = sr.ReadToEnd();
			while(str != null)
            {
				Console.WriteLine( str);
				++newline;
				str = sr.ReadLine();
            }
			Console.ReadLine();
        }
		public static void Main(string[] args)
		{
			Session s = new Session();
			s.recordSession("aser", "login");
			s.displaySession();
		}

	}
}
