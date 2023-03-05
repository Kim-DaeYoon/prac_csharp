// 캐릭터 클래스

using System;

namespace myStudy
{
	// 캐릭터 추상 클래스 base -------------------------------------------
	public abstract class Character
	{
		protected WeaponBehavior weapon;

		public Character()
		{
			if (weapon==null)
			{
				weapon = new KnifeBehavior();
			}

		}

		public abstract void display();

		public void setWeapon(WeaponBehavior w)
		{
			this.weapon = w;
		}

		public void fight()
		{
			weapon.useWeapon();
		}

		public void move()
		{
			Console.WriteLine("캐릭터들은 이동 가능합니다.");
		}
	}

	// sub 클래스 --------------------------------------------------------
	public class Queen : Character
	{
		public Queen()
		{
			weapon = new BowBehavior();
		}

		public override void display()
		{
			Console.WriteLine("나는 여왕이다.");
		}
	}

	public class King : Character
	{
		public King()
		{
			weapon = new KnifeBehavior();
		}

		public override void display()
		{
			Console.WriteLine("나는 왕이다.");
		}
	}

	public class Knight : Character
	{
		public Knight()
		{
			weapon = new SwordBehavior();
		}

		public override void display()
		{
			Console.WriteLine("나는 기사임");
		}
	}

	public class Troll : Character
	{
		public Troll()
		{
			weapon = new AxeBehavior();
		}

		public override void display()
		{
			Console.WriteLine("나는 트롤임");
		}
	}

}