using System.Collections.Generic;
using UnityEngine;

public enum CarType { Player, AI}
public class CarIdentity : MonoBehaviour
{
    //public list<string> cars = new list<string>() { "player", "gold car" };
    public CarType type = CarType.Player;
    public string car_name = "Pelaaja";
}
