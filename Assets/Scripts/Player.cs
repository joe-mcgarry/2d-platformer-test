using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private int _health;
    public int Health
    {
        get
        {
            return _health;
        }

        set
        {
            _health = value;
        }
    }

    private int power;
    private string name;

   public Player(int health, int power, string name)
    {
        Health = health;
        this.power = power;
        this.name = name;
    }
}
