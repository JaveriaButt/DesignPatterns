using System;
using System.Collections.Generic;

// Observer Interface
public interface IObserver
{
    void Update(string weather);
}

// Subject Interface
public interface ISubject
{
    void AddObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}

// ConcreteSubject Class
public class WeatherStation : ISubject
{
    private List<IObserver> observers = new List<IObserver>();
    private string weather;

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(weather);
        }
    }

    public void SetWeather(string newWeather)
    {
        weather = newWeather;
        NotifyObservers();
    }
}

// ConcreteObserver Class
public class PhoneDisplay : IObserver
{
    private string weather;

    public void Update(string weather)
    {
        this.weather = weather;
        Display();
    }

    private void Display()
    {
        Console.WriteLine("Phone Display: Weather updated - " + weather);
    }
}

// ConcreteObserver Class
public class TVDisplay : IObserver
{
    private string weather;

    public void Update(string weather)
    {
        this.weather = weather;
        Display();
    }

    private void Display()
    {
        Console.WriteLine("TV Display: Weather updated - " + weather);
    }
}

// Usage Class
class Program
{
    static void Main(string[] args)
    {
        WeatherStation weatherStation = new WeatherStation();

        IObserver phoneDisplay = new PhoneDisplay();
        IObserver tvDisplay = new TVDisplay();

        weatherStation.AddObserver(phoneDisplay);
        weatherStation.AddObserver(tvDisplay);

        // Simulating weather change
        weatherStation.SetWeather("Sunny");

        // Output:
        // Phone Display: Weather updated - Sunny
        // TV Display: Weather updated - Sunny
    }
}
