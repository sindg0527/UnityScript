using System.Collections;
using System.Collections.Generic;
using UnityEngine; //����Ƽ ������ �ִ� ��� ���

public class First : MonoBehaviour
//MonoBehaviour�� ����Ƽ���� ����ϴ� ��ɵ��� ��Ƴ��� Ŭ����
//�̰� ����Ǿ����� ������ ����Ƽ�� ������Ʈ�� ���� �� �� ����
{
    //�Ϲ� C#������ Main�� ���� ������ �����ߴٸ�
    //����Ƽ�� ��ũ��Ʈ�� ������ ����Ŭ�� ���� ������ ��ġ�� �ڵ带 �����ϰ�
    //����Ƽ ������ �����ϴ� ������ �۾��� ����

    //ù ������ ���� �� ȣ��Ǵ� �Լ�

    public int count = 0; //����Ƽ �������� ������ �����ϰ� ����
    private float value = 2.0f; //����Ƽ �������� ���� �Ұ�

    void Start()
    {
        Debug.Log("����");
    }

    //�������� ���� ���� �����ؾ��ϴ� ��ġ
    //�ٽ� ���� ���� �ۼ��Ǵ� ��ġ

    //void Update()
    //{
    //    count++;
    //    Debug.Log(count);
    //}
}