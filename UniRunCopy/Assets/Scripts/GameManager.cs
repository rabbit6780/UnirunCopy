using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

//���ӿ��� ���¸� ǥ���ϰ�, ���� ������ UI�� �����ϴ� ���� �Ŵ���
//������ �� �ϳ��� ���� �Ŵ����� ������ �� ����
public class GameManager : MonoBehaviour
{
    public static GameManager instance; //�̱����� �Ҵ��� ���� ����

    public bool isGameover = false; //���ӿ��� ����
                                    //public Text scoreText;//������ ����� UI �ؽ�Ʈ
    public TextMeshProUGUI scoreText;
    public GameObject gameoverUI; //���ӿ��� �� Ȱ��ȭ�� UI ���� ������Ʈ

    private int score = 0; //���� ����

    // ���� ���۰� ���ÿ� �̱����� ����
    void Awake()
    {
        //�̱��� ���� instance�� ��� �ִ°�?
        if (instance==null)
        {
            //instance�� ��� �ִٸ�(null) �װ��� �ڱ� �ڽ��� �Ҵ�
            instance = this;
        }
        else
        {
            //instance�� �̹� �ٸ� GameManagr ������Ʈ�� �Ҵ�Ǿ� �ִ� ���

            //���� �ΰ� �̻��� GameManager ������Ʈ�� �����Ѵٴ� �ǹ�
            //�̱��� ������Ʈ�� �ϳ��� �����ؾ� �ϹǷ� �ڽ��� ���� ������Ʈ�� �ı�
            Debug.LogWarning("���� �ΰ� �̻��� ���� �Ŵ����� �����մϴ�!");
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //���ӿ��� ���¿��� ������ ������� �� �ְ� �ϴ� ó��
        if (isGameover&&Input.GetMouseButton(0))
        {
            //���ӿ��� ���¿��� ���콺 ���� ��ư�� Ŭ���ϸ� ���� �� �����
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    //������ ������Ű�� �޼���
    public void AddScore(int newScore)
    {
        //���ӿ����� �ƴ϶��
        if (!isGameover)
        {
            //������ ����
            score += newScore;
            scoreText.text = "Score : " + score;
        }
    }

    //�÷��̾� ĳ���� ��� �� ���ӿ����� �����ϴ� �޼���
    public void OnPlayerDead()
    {
        isGameover = true;
        gameoverUI.SetActive(true);
    }
}
