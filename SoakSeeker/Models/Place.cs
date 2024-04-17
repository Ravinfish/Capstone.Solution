using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using SoakSeeker.Models;

namespace SoakSeeker.Models;

public class Place
{
  // Properties
  public int PlaceId { get; set; }
  public string State { get; set; }
  public string Navigation { get; set; }
  public string HotSpring { get; set; }
  public GPSCoordinates Coordinates { get; set; }

  // Constructor
  public Place(int placeId, string state, string navigation, string hotSpring, GPSCoordinates coordinates)
  {
    PlaceId = placeId;
    State = state;
    Navigation = navigation;
    HotSpring = hotSpring;
    Coordinates = coordinates;

  }
}

// GPS  Coordinates Class
public class GPSCoordinates
{
  // Properties
  public double Latitude { get; set; }
  public double Longitude { get; set; }

  // Constructor
  public GPSCoordinates(double latitude, double longitude)
  {
    Latitude = latitude;
    Longitude = longitude;
  }
}