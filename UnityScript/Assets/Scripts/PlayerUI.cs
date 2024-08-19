using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Player player;

    public Image Player_Image;
    public Slider Player_hp;
    public Text Player_name;

    public GameObject Player_UI;

    private void Start()
    {
        Player_Image.sprite = player.image;
        Player_name.text = player.name;
        Player_hp.maxValue = player.max_hp;
        Player_hp.value = player.hp;
    }

    void Update()
    {
        //GetKeyDown : �������� (1��)
        //GetKey : ������ ����
        //GetKeyUp : Ű�� ���� ��
        if(Input.GetKeyDown(KeyCode.I)) //Ű���� I ��ư�� ������ ��
        {
            if (Player_UI.activeSelf) //GameObject�� ���� Ȱ��ȭ�Ǿ� �ִ��� �ƴ����� ��Ÿ���� bool��
                Player_UI.SetActive(false); //�����ִٸ� ��Ȱ��ȭ
            else
                Player_UI.SetActive(true);  //�����ִٸ� Ȱ��ȭ
        }
    }

    //����Ƽ c#�� �޼ҵ� ��� ���
    //1. Ű���� �Է� ���� ���� �޼ҵ� ȣ��
    //2. ����Ƽ�� ��ư ���� Ȱ���� ��ư ������ �� �޼ҵ� ȣ��

    public void Action01()
    {
        player.Dance();
    }
    public void Action02()
    {
        player.Heal(); //�÷��̾� ȸ��
        setValue(); //����� HP ����
    }

    public void setValue()
    {
        Player_hp.value = player.hp;
    }
}
