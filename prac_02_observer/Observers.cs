using System;
using System.Collections.Generic;

// 옵저버 (리스너)
namespace myStudy
{

    // 옵저버 클래스 
    public class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private WeatherData _weatherData;  // 서브젝트 참조용

        // subject(==WeatherData) 를 인자로 받아 인스턴스 생성시 바로 subject에 옵저버로 등록한다.
        public CurrentConditionDisplay(WeatherData weatherData)
        {
            this._weatherData = weatherData;
            _weatherData.registerObserver(this);
        }

        // subject(WeatherData) -> here : 노티파이 받는 함수
         //(서브젝트에서 옵저버로 데이터를 주는 push 방식 )
         /*
        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            display();
        }
        */

        // subject(WeatherData) -> here : 노티파이 받는 함수
        // 옵저버가 서브젝트로 부터 데이터 가져오는 pull 방식 
        public void update()
        {
            // 서브젝트인 weatherData를 가지고 있으므로 pull 방식 사용가능
            this.temperature = _weatherData.getTemperature();
            this.humidity = _weatherData.getHumidity();
            display();
        }


        public void display()
        {
            Console.WriteLine("현재 상태 : 온도 {0}F  습도{1}%",temperature,humidity);
        }
    }

    // 옵저버가 여러개일 경우 아래에 옵저버 클래스를 추가로 작성한다.

}