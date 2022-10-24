using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DeclareClassMembers
{/// <summary>
/// Q1 將指定文字內容存檔, 由於要存放的文字內容與檔案存放位置都會變化, 
/// 所以我們可以將這兩項資訊設計成 method的參數, 由外界傳入請設計一個FileManager class, 
/// 內含一個 Save method只需要設定method, 不必實作出功能
/// </summary>

	internal class Program
	{
		static void Main(string[] args)
		{
			FileManager answer=new FileManager();
			answer.Save("123.txt", "C:\\Users\\88693");
		}
	}

	class FileManager
	{
		public void Save(string FileName, string FilePath) 
		{
			//ToDo	
		}

	}
}
