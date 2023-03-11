using System;
using System.Collections.Generic;

// 서브젝트( 노티파이어 )
namespace myStudy
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observers;  // 옵저버 리스트 
        private float temperature;  // 온도
        private float humidity;     // 습도
        private float pressure;     // 기압

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public float getTemperature()
        {
            return temperature;
        }

        public float getHumidity()
        {
            return humidity;
        }

        public float getPressure()
        {
            return pressure;
        }


        //---------------------------------------------------------------
        // Subject 인터페이스의 메소드 여기서 구현 
        // 옵저버 추가(등록)
        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }

        // 옵저버 제거
        public  void removeObserver(IObserver o)
        {
            observers.Remove(o);
        }

        // this -> 모든 옵저버에게 상태 변화 알림 
        public void notifyObservers()
        {
            foreach (var item in observers)
            {
                // 서브젝트에서 옵저버로 데이터 보내 주는 push 방식
                //item.update(temperature,humidity,pressure);

                // 옵저버에서 서브젝트에서 데이터 가져오는 pull 방식
                item.update();
            }
        }

        //----------------------------------------------------------
        // 외부(기상 스테이션)에서 -> this 상태 변화 알려줌 
        public void measurementsChanged()
        {
            notifyObservers();
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }

        // 기타 WeatherData 메소드
    }
}