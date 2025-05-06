using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Sound : MonoBehaviour
{
    [SerializeField] float countTime;
    [SerializeField] AudioClip audioClip;
    [SerializeField] AudioManager audioManager;
    private void Start()
    {
        countTime = Random.Range(1, 6);
    }
    private void Update()
    {
        countTime -= Time.deltaTime;
        if (countTime <= 0)
        {
            audioManager.Listener(audioClip);
            countTime = Random.Range(1, 6);
        }
    }
}
