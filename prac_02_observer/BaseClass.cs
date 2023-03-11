using System;

// p094
// 옵저버 패턴
// base interface
namespace myStudy
{
    // 서브젝트는 옵저버 등록, 제거, 알림 3개의 기능을 가진다.
    public interface ISubject
    {
        public void registerObserver(IObserver o);
        public void removeObserver(IObserver o);
        public void notifyObservers();
    }

    // 온도, 습도, 기압
    public interface IObserver
    {
        // 서버젝트에서 옵저버로 데이터 주는 push 방식 
        //public void update(float temp, float humidity, float pressure);

        // 옵저버에서 서브젝트에서 데이터 가져오는 pull방식
        public void update();
    }

    public interface IDisplayElement
    {
        public void display();
    }
}