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
        //GetKeyDown : 눌렀을때 (1번)
        //GetKey : 누르는 동안
        //GetKeyUp : 키를 뗐을 때
        if(Input.GetKeyDown(KeyCode.I)) //키보드 I 버튼을 눌렀을 때
        {
            if (Player_UI.activeSelf) //GameObject가 현재 활성화되어 있는지 아닌지를 나타내는 bool값
                Player_UI.SetActive(false); //켜져있다면 비활성화
            else
                Player_UI.SetActive(true);  //꺼져있다면 활성화
        }
    }

    //유니티 c#의 메소드 사용 방법
    //1. 키보드 입력 값에 따라 메소드 호출
    //2. 유니티의 버튼 등을 활용해 버튼 눌렀을 때 메소드 호출

    public void Action01()
    {
        player.Dance();
    }
    public void Action02()
    {
        player.Heal(); //플레이어 회복
        setValue(); //변경된 HP 적용
    }

    public void setValue()
    {
        Player_hp.value = player.hp;
    }
}
