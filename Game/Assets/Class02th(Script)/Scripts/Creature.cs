using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    public Stat stat = new Stat();
    public Creature()
    {
        Debug.Log("Creature!!!!!!");
        stat.health = 100;
        stat.level = 10;
        stat.name = "Bear";
        Debug.Log(stat.name);
        Debug.Log(stat.health);
        Debug.Log(stat.level);
    }
    
}
