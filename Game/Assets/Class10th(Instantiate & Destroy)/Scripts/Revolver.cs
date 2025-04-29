using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Revolver : Weapon
{
    public override void Attack()
    {
        Debug.Log("Fire a revolver");
    }
    private void Start()
    {
        Debug.Log("Damage : " + damage + "\nIntersection : " + intersection);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.Attack();
        }
    }
}
