using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] GameObject [] weapons;
    [SerializeField] List<GameObject> weaponList;
    [SerializeField] Transform CreatePosition;
    private GameObject CurrentPrefab;
    void Start()
    {
        for(int i = 0; i< weapons.Length; i++)
        {
            Instantiate(weapons[i],CreatePosition);
            weaponList.Add(weapons[i]);
        }

    }
    private void Update()
    {
       
    }

}
