using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Mouse : MonoBehaviour
{
    [SerializeField] Ray ray;
    [SerializeField] RaycastHit rayCastHit;
    [SerializeField] LayerMask layerMask;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray, out rayCastHit, Mathf.Infinity,layerMask))
            {

                GameObject prefab = rayCastHit.collider.gameObject;
                Debug.Log(prefab.gameObject.name);
                if(prefab.transform.GetChild(0).gameObject.activeSelf)
                {
                    prefab.transform.GetChild(0).gameObject.SetActive(false);
                    
                }
                else
                {
                    prefab.transform.GetChild(0).gameObject.SetActive(true);
                }
            }
        }
    }
}
