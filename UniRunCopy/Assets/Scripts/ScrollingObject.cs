using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    public float speed = 10f; //�̵� �ӵ�

    private void Update()
    {
        //���� ������Ʈ�� ���� �ӵ��� �������� �����̵��ϴ� ó��

        //���ӿ����� �ƴ϶��
        if (!GameManager.instance.isGameover)
        {//�ʴ� speed�� �ӵ��� �������� �����̵�
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

    }
}
