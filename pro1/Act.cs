// 행동 인터페이스
//

using System;

namespace myStudy
{
    // fly 행동 구현 인터페이스------------------------------------
    public interface FlyBehavior
    {
        public void fly();
    }

    public class FlyWithWings : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("날고 있어요");
        }
    }

    public class FlyNoWay : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("나는 못 날아요");
        }
    }

    public class FlyRocketPowered : FlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("로켓 추진으로 날아갑니다.");
        }
    }

   
    // 꽥꽥 행동 구현 인터 페이스----------------------------------
    public interface QuackBehavior
    {
        public void quack();
    }

    public class Quack : QuackBehavior
    {
        public void quack()
        { 
            Console.WriteLine("꽥");
        }
    }

    public class MuteQuack : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("조용");
        }
    }

    public class Squeak : QuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("삑");
        }
    }
}

