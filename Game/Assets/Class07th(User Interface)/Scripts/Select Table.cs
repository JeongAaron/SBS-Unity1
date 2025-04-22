using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectTable : MonoBehaviour
{
    [SerializeField] Text titleText;
    public void Entered()
    {
        Debug.Log("Entered");
        titleText.fontSize = 100;
    }
    public void Exited()
    {
        Debug.Log("Exited");
        titleText.fontSize = 75;
    }
    public void Clicked()
    {
        Debug.Log("Clicked");
        titleText.fontSize = 50;
    }
}
