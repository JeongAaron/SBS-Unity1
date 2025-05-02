using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knife : Weapon
{
    [SerializeField] Animation slash;
    public override void Attack()
    {
        Debug.Log("Slash");
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
