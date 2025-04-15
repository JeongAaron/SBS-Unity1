using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    private void Awake()
    {
        //  Awake �Լ���?
        //  ���� ������Ʈ�� �����Ǿ��� �� �� �� ���� ȣ��Ǹ�, ��Ʈ��Ʈ�� ��Ȱ��ȭ�Ǿ� �ִ� ���¿����� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("Awake");
    }
    private void OnEnable()
    {
        //  OnEnable �Լ���?
        //  ���� ������Ʈ�� Ȱ��ȭ�Ǵ� �������� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("OnEnable");
    }
    private void Start()
    {
        //  Start �Լ���?
        //  ���� ������Ʈ�� �����Ǿ��� �� �� �ѹ��� ȣ��Ǹ�, ��ũ��Ʈ�� ��Ȱ��ȭ�� ������ ��, ȣ����� �ʴ� �̺�Ʈ �Լ�
        Debug.Log("Start");
    }
    private void FixedUpdate()
    {
        //  FixedUpdate �Լ���? ȸ�� �̵� �� ������ ó��
        //  TimeStep�� ������ ���� ���� ������ �������� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("FixedUpdate");
        
    }
    private void Update()
    {
        //  Update �Լ���? Ű �Էµ��� ó��
        //  ������ ����Ǵ� ���� �� �����Ӹ��� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("Update");
    }
    private void LateUpdate()
    {
        //  LateUpdate �Լ���? ĳ���� �̵� �� ���󰡴� ī�޶� ���� ó���� ��
        //  Update �Լ��� ȣ��� ���Ŀ� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("LateUpdate");
    }
    private void OnDisable()
    {
        //  OnDisable �Լ���? OnEnable �Լ��� ���� ���Ǹ� ������Ʈ�� �޸� �Ҵ翡�� �޸� ����ȭ�� �������� Destroy �� �� ó�� ���̰� �ϱ����� ���
        //  ���� ������Ʈ�� ��Ȱ��ȭ�Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("OnDisable");
    }
    private void OnDestroy()
    {
        //  OnDestory �Լ���?
        //  ���� ������Ʈ�� �����Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ�
        Debug.Log("OnDestroy");
    }
}
