using System;

// Subsystem classes
class DVDPlayer
{
    public void TurnOn() { Console.WriteLine("DVD Player: Turning on..."); }
    public void Play(string movie) { Console.WriteLine("DVD Player: Playing movie '" + movie + "'"); }
    public void TurnOff() { Console.WriteLine("DVD Player: Turning off..."); }
}

class TV
{
    public void TurnOn() { Console.WriteLine("TV: Turning on..."); }
    public void SetInput(string input) { Console.WriteLine("TV: Setting input to '" + input + "'"); }
    public void TurnOff() { Console.WriteLine("TV: Turning off..."); }
}

class SoundSystem
{
    public void TurnOn() { Console.WriteLine("Sound System: Turning on..."); }
    public void SetVolume(int volume) { Console.WriteLine("Sound System: Setting volume to " + volume); }
    public void TurnOff() { Console.WriteLine("Sound System: Turning off..."); }
}

// Facade class
class EntertainmentSystemFacade
{
    private DVDPlayer _dvdPlayer;
    private TV _tv;
    private SoundSystem _soundSystem;

    public EntertainmentSystemFacade()
    {
        _dvdPlayer = new DVDPlayer();
        _tv = new TV();
        _soundSystem = new SoundSystem();
    }

    public void WatchMovie(string movie)
    {
        Console.WriteLine("Initializing entertainment system for movie playback...");
        _dvdPlayer.TurnOn();
        _tv.TurnOn();
        _tv.SetInput("DVD");
        _dvdPlayer.Play(movie);
        _soundSystem.TurnOn();
        _soundSystem.SetVolume(10);
    }

    public void ListenToMusic()
    {
        Console.WriteLine("Initializing entertainment system for music playback...");
        _soundSystem.TurnOn();
        _soundSystem.SetVolume(20);
    }

    public void TurnOff()
    {
        Console.WriteLine("Turning off entertainment system...");
        _dvdPlayer.TurnOff();
        _tv.TurnOff();
        _soundSystem.TurnOff();
    }
}

// Client code
class Client
{
    static void Main(string[] args)
    {
        EntertainmentSystemFacade entertainmentSystem = new EntertainmentSystemFacade();

        // Watch movie
        Console.WriteLine("\n-- Watching Movie --");
        entertainmentSystem.WatchMovie("The Matrix");

        // Listen to music
        Console.WriteLine("\n-- Listening to Music --");
        entertainmentSystem.ListenToMusic();

        // Turn off
        Console.WriteLine("\n-- Turning Off --");
        entertainmentSystem.TurnOff();
    }
}
