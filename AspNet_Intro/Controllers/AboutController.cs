using System;
namespace AspNet_Intro.Controllers
{
	public class AboutController
	{
		public string Index(int num)
		{
			return "This is About Controller Index method" + num;
		}

		public string GetInfo()
		{
			return "This page is getinfo page";
		}
	}
}

