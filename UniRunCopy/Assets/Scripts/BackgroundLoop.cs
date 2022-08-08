using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//���� ������ �̵��� ����� ������ ������ ���ġ�ϴ� ��ũ��Ʈ 
public class BackgroundLoop : MonoBehaviour
{
    private float width; //����� ���� ����

    private void Awake()
    {
        // ���� ���̸� �����ϴ� ó��
        //BoxCollider2D ������Ʈ�� Size �ʵ��� x���� ���� ���̷� ���
        BoxCollider2D backgroundColider = GetComponent<BoxCollider2D>();

        width = backgroundColider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        //���� ��ġ�� �������� �������� width �̻� �̵����� �� ��ġ�� ���ġ
        if (transform.position.x <= -width)
        {
            Reposition();
        }
    }

    //��ġ�� ���ġ�ϴ� �޼���
    private void Reposition()
    {
        //���� ��ġ���� ���������� ���� ���� *2��ŭ �̵�
        Vector2 offset = new Vector2(width * 2, 0);
        transform.position = (Vector2)transform.position + offset;
    }
}
