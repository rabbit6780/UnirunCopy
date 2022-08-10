using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// �������μ� �ʿ��� ������ ���� ��ũ��Ʈ
public class Platform : MonoBehaviour
{
    public GameObject[] obstacles; //��ֹ� ������Ʈ��
    private bool stepped = false; //�÷��̾� ĳ���Ͱ� ��Ҵ°�

    //������Ʈ�� Ȱ��ȭ�� ������ �Ź� ����Ǵ� �޼���
    private void OnEnable()
    {
        //������ �����ϴ� ó��
        //���� ���¸� ����
        stepped = false;

        //��ֹ��� ����ŭ ����
        for (int i = 0; i < obstacles.Length; i++)
        {
            //���� ������ ��ֹ��� 1/3�� Ȯ���� Ȱ��ȭ
            if (Random.Range(0,3)==0)
            {
                obstacles[i].SetActive(true);
            }
            else
            {
                obstacles[i].SetActive(false);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //�÷��̾� ĳ���Ͱ� �ڽ��� ����� �� ������ �߰��ϴ� ó��
    }
}
