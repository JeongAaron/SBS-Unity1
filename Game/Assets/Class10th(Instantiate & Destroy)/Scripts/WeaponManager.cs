using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] GameObject [] weapons;
    [SerializeField] List<GameObject> weaponList;
    [SerializeField] Transform createPosition;
    [SerializeField] int currentIndex = 0;
    void Start()
    {
        for(int i = 0; i< weapons.Length; i++)
        {
            GameObject clone = Instantiate(weapons[i], createPosition);
            clone.gameObject.SetActive(false);
            weaponList.Add(clone);
        }
        weaponList[currentIndex].gameObject.SetActive(true);
    }
    public void Swap()
    {
        weaponList[currentIndex].gameObject.SetActive(false);
        currentIndex = (currentIndex + 1) % weaponList.Count;
        weaponList[currentIndex].gameObject.SetActive(true);
    }
    private void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
        {
            Swap();
        }
    }

}

public class currentIndex
{
}