using System.Collections;
using System.Collections.Generic;
using UnityEngine; //유니티 엔진에 있는 기능 사용

public class First : MonoBehaviour
//MonoBehaviour는 유니티에서 사용하는 기능들을 모아놓은 클래스
//이게 연결되어있지 않으면 유니티의 오브젝트에 연결 할 수 없음
{
    //일반 C#에서는 Main을 통해 실행을 진행했다면
    //유니티의 스크립트는 라이프 사이클에 의해 정해진 위치에 코드를 설계하고
    //유니티 엔진이 실행하는 것으로 작업을 진행

    //첫 프레임 시작 시 호출되는 함수

    public int count = 0; //유니티 엔진에서 수정이 가능하고 보임
    private float value = 2.0f; //유니티 엔진에서 수정 불가

    void Start()
    {
        Debug.Log("시작");
    }

    //실질적인 동작 등을 구현해야하는 위치
    //핵심 로직 등이 작성되는 위치

    //void Update()
    //{
    //    count++;
    //    Debug.Log(count);
    //}
}