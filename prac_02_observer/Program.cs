using System;

// 메인 
namespace myStudy
{
    // 기상 스테이션
    public class WeatherStation
    {
        public static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData(); // 서브젝트 객체 생성

            // 옵저버 객체 생성
            CurrentConditionDisplay currentDisplay = new CurrentConditionDisplay(weatherData);

            // 서브젝트에 기상 측정값을 알려줌 
            weatherData.setMeasurements(80, 65, 30.4f);
            weatherData.setMeasurements(82, 70, 29.2f);
            weatherData.setMeasurements(78, 90, 39.4f);
        }
    }
}

// 서브젝트 == 노티파이어
// 옵저버 == 리스너

// 주석 추가 
