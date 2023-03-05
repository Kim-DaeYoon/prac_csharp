// 액션 인터페이스

using System;

namespace myStudy
{
	// base 인터페이스---------------------------------------
	public interface WeaponBehavior
	{
		public void useWeapon();
	}

	// sub 클래스들 -----------------------------------------
	public class KnifeBehavior : WeaponBehavior
	{
		public void useWeapon()
		{
			Console.WriteLine("나이프 사용");
		}
	}

	public class BowBehavior : WeaponBehavior
	{
		public void useWeapon()
		{
			Console.WriteLine("활 쏘기");
		}
	}

	public class AxeBehavior : WeaponBehavior
	{
		public void useWeapon()
		{
			Console.WriteLine("도끼 사용");
		}
	}

	public class SwordBehavior : WeaponBehavior
	{
		public void useWeapon()
		{
			Console.WriteLine("검 사용");
		}
	}
}
