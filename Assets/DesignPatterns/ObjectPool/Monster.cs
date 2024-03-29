using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    // 해당 작업을 진행하기 위해서는 오브젝트에 Collider 컴포넌트가 있어야함
    // 유니티 마우스, 터치 관련 이벤트 함수
    // 1. OnMouseOver() 해당 오브젝트에 마우스가 올라갈 경우 프레임 마다 실행
    // 2. OnMouseEnter() 마우스가 올라갈 경우 1화
    // 3. OnMouseExit() 마우스가 벗어날 때 1회
    // 4. OnMouseUp() 마우스 클릭이 해제될 때
    // 5. OnMouseDown() 마우스 클릭이 될 때
    //private void OnMouseOver()
    //{
    //    gameObject.SetActive(false);
    //}

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
    }

}
