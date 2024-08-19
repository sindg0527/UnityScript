using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ŭ����(class)
//��ü�� ���� ���踦 ���� ����� ���� Ʋ

//class Ŭ������
//{
//    //�ʵ�((field) : Ŭ���� ���ο��� ������� ����, ��ü�� �Ӽ��� ǥ���ϴ� �뵵�� ���

//    //�޼ҵ�(method) : Ŭ���� ���ο��� ������� �Լ�, ��ü�� ����, ����� ǥ���ϴ� �뵵�� ���
//}

//����Ƽ���� ���� ������ class��
//���忡 ��ġ�� ������Ʈ�� ���� ������ �� �����ϴ�

//����Ƽ���� Ŭ������ ���� ������ �ν����ͷκ��� Ȯ���� �� �ְ� �ϴ� ���
[Serializable]
public class Player
{
    public int hp;
    public int max_hp;
    public string name;
    public Sprite image; //Sprite�� ����Ƽ���� 2D�̹��� ���Ͽ� ���� ����

    public void Dance()
    {
        Debug.Log($"{name}�� ���� �߰� �ֽ��ϴ�.");
    }

    public void Heal()
    {
        if (hp >= max_hp)
        {
            Debug.Log("ü���� �̹� ���� ���ֽ��ϴ�.");
            hp = max_hp;
            return;
        }
        hp += 10;
        Debug.Log($"ü���� 10 ȸ���մϴ�! ���� ü�� {hp} / {max_hp}");
    }
}
