using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    private void Awake()
    {
        //  Awake 함수란?
        //  게임 오브젝트가 생성되었을 때 단 한 번만 호출되며, 스트립트가 비활성화되어 있는 상태에서도 호출되는 이벤트 함수
        Debug.Log("Awake");
    }
    private void OnEnable()
    {
        //  OnEnable 함수란?
        //  게임 오브젝트가 활성화되는 순간마다 호출되는 이벤트 함수
        Debug.Log("OnEnable");
    }
    private void Start()
    {
        //  Start 함수란?
        //  게임 오브텍트가 생성되었을 때 단 한번만 호출되며, 스크립트가 비활성화된 상태일 땐, 호출되지 않는 이벤트 함수
        Debug.Log("Start");
    }
    private void FixedUpdate()
    {
        //  FixedUpdate 함수란? 회전 이동 등 물리적 처리
        //  TimeStep에 설정된 값에 따라 일정한 간격으로 호출되는 이벤트 함수
        Debug.Log("FixedUpdate");
        
    }
    private void Update()
    {
        //  Update 함수란? 키 입력등을 처리
        //  게임이 실행되는 동안 매 프레임마다 호출되는 이벤트 함수
        Debug.Log("Update");
    }
    private void LateUpdate()
    {
        //  LateUpdate 함수란? 캐릭터 이동 후 따라가는 카메라 등을 처리할 때
        //  Update 함수가 호출된 이후에 호출되는 이벤트 함수
        Debug.Log("LateUpdate");
    }
    private void OnDisable()
    {
        //  OnDisable 함수란? OnEnable 함수와 같이 사용되며 오브젝트의 메모리 할당에서 메모리 파편화를 막기위해 Destroy 된 것 처럼 보이게 하기위해 사용
        //  게임 오브젝트가 비활성화되었을 때 호출되는 이벤트 함수
        Debug.Log("OnDisable");
    }
    private void OnDestroy()
    {
        //  OnDestory 함수란?
        //  게임 오브젝트가 삭제되었을 때 호출되는 이벤트 함수
        Debug.Log("OnDestroy");
    }
}
