// See https://aka.ms/new-console-template for more information
// 헤드 퍼스트 디자인 패턴 학습
// 전략 패턴  Strategy pattern 
// 
// 알고리즘을 정의하고 캡슐화해서 각각의 알고리즘군을 수정해서 쓸수 있게 해준다.
// 클라이언트로부터 알고리즘을 분리해서 독립적으로 변경할 수 있다.
//
using System;

namespace myStudy
{
    // fly 행동 구현 인터페이스
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
   
    // 꽥꽥 행동 구현 인터 페이스
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


    
    // 오리 추상 클래스 
    public abstract class Duck
    {
        protected FlyBehavior flyBehavior;
        protected QuackBehavior quackBehavior;

        public Duck(){}

        public abstract void display();

        public void performFly(){
            flyBehavior.fly();
        }

        public void performQuack(){
            quackBehavior.quack();
        }

        public void swim(){
            Console.WriteLine("모든 오리는 물에 뜹니다.");
        }
    }

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void display()
        {
            Console.WriteLine("저는 물 오리입니다.");
        }
    }


    public class myApp
    {

        static void Main(String[] args)
        {
            Console.WriteLine("Hello, World!");

            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();
        }
    }
}
