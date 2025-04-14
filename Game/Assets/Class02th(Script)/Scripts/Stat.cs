using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stat
{
    private int level;
    private int health;
    private string name;
    public int Level { set { level = value; } get { return level; } }
    public int Health { set { if(value < 100) { health = value; } else { health = 100; } } get { return health; } }
    public string Name { set { name = value; } get { return name; } }
}
