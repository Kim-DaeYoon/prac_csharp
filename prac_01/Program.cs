// See https://aka.ms/new-console-template for more information
// 헤드퍼스트 디자인 패턴 p061
// 전략패턴 연습문제

using System;

namespace myStudy
{
	// 메인 클래스
	public class myApp
	{
		static void Main(String[] args)
		{
			Console.WriteLine("Hello, World!");

			Character queen = new Queen();
			queen.display();
			queen.fight();

			queen.setWeapon(new KnifeBehavior());
			queen.fight();

			Character troll = new Troll();
			troll.display();
			troll.fight();
		}
	}
}