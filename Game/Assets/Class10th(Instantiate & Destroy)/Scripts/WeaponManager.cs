using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] Transform CreatePosition;
    private GameObject CurrentPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(prefab, CreatePosition);
        CurrentPrefab = Instantiate(prefab, CreatePosition);
        Debug.Log(CurrentPrefab.name);
    }
    
}
