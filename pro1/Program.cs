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
    // 오리 추상 클래스 
    public abstract class Duck
    {
        protected FlyBehavior flyBehavior;
        protected QuackBehavior quackBehavior;

        public Duck(){}

        public abstract void display();

        public void setFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void setQuakBehavior(QuackBehavior qb)
        {
            quackBehavior = qb;
        }

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

    public class ModelDuck : Duck
    {
        public ModelDuck(){
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quack();
        }

        public override void display()
        {
            Console.WriteLine("저는 모형 오리입니다");
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

            Duck model  = new ModelDuck();
            model.performFly();
            model.setFlyBehavior(new FlyRocketPowered());
            model.performFly();
        }
    }
}
