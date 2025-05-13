using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automation : MonoBehaviour
{
    [SerializeField] bool state;
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] Vector3 direction;
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        StartCoroutine(Coroutine());
    }
    private void FixedUpdate()
    {
        //  ForceMode.Force : 매 프레임마다 지속적을 힘을 가하는 함수. (Mass) - 0
        //  ForceMode.Impulse : 순간적으로 힘을 가하는 함수. (Mass) - 0
        //  ForceMode.Acceleration : 지속적인 가속도를 적용하는 함수. (Mass) - X
        //  ForceMode.VelocityChange : 순간적인 소도 변경을 적용하는 함수. (Mass) - X
        if(state)
        {
            rigidbody.AddForce(direction, ForceMode.Impulse);
            state = false;
        }

    }
    IEnumerator Coroutine() 
    {
        while(true)
        {
            yield return new WaitForSeconds(5);
            state = true;
        }
    }
}
