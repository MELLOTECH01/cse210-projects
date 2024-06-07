using System;

// My Quick Web Search:
// https://stackoverflow.com
// https://www.geeksforgeeks.org
// w3schools c#
// MDN
// learn.microsoft.com

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");

        // Create event objects
        Address address1 = new Address("123 Main St", "Cityville", "Stateville", "Countryland");
        Lecture lectureEvent = new Lecture("Intro to Programming", "Learn the basics of programming", DateTime.Now.AddDays(7), "10:00 AM", address1, "John Doe", 50);

        Address address2 = new Address("456 Elm St", "Townville", "Provinceville", "Countryland");
        Reception receptionEvent = new Reception("Networking Mixer", "An evening of networking and socializing", DateTime.Now.AddDays(14), "6:00 PM", address2, "rsvp@example.com");

        Address address3 = new Address("789 Oak St", "Villageville", "Territoryville", "Countryland");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Picnic in the Park", "Join us for fun and games in the park", DateTime.Now.AddDays(21), "12:00 PM", address3, "Sunny");

        // Display marketing messages for each event
        Console.WriteLine("Marketing Messages:");
        Console.WriteLine("--------------------");
        Console.WriteLine("Lecture Event:");
        Console.WriteLine(lectureEvent.GetFullDetails());
         Console.WriteLine(lectureEvent.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Reception Event:");
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine(receptionEvent.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Outdoor Gathering Event:");
        Console.WriteLine(outdoorEvent.GetFullDetails());
        Console.WriteLine(outdoorEvent.GetShortDescription());
    }
}

// Address class to represent event addresses
class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetFullAddress()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }
}

// Base Event class
class Event
{
    protected string _title;
    private string _description;
    protected DateTime _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, DateTime date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate: {_date.ToShortDateString()}\nTime: {_time}\nAddress: {_address.GetFullAddress()}";
    }


    // public virtual string GetShortDescription()
    // {
       // return $"Type: Event\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    // }
}

// Derived Lecture class
class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nType: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }

    public string GetShortDescription()
    {
        return $"Type: Lecture\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }
}

// Derived Reception class
class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, DateTime date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nType: Reception\nRSVP Email: {_rsvpEmail}";
    }

    public string GetShortDescription()
    {
        return $"Type: Reception\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }
}

// Derived OutdoorGathering class
class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, DateTime date, string time, Address address, string weatherForecast)
        : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {_weatherForecast}";
    }

    public string GetShortDescription()
    {
        return $"Type: Outdoor Gathering\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }
}