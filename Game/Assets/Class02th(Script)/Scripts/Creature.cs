using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    private Stat stat = new Stat();
    public Creature()
    {
        stat.Level = 1;
        stat.Health = 105;
        stat.Name = "Bear";
        Debug.Log("Creature");
        Debug.Log("Name : " + stat.Name);
        Debug.Log("HP : " + stat.Health);
        Debug.Log("Level : " + stat.Level);
    }
    
}
