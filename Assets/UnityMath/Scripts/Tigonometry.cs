using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 프로그래밍 기본 이론 (게임 수학)
public class Tigonometry : MonoBehaviour
{
    // 게임 수학에서 다루는 것들
    // 1. 삼각함수
    // 2. 좌표
    // 3. 벡터
    // 4. 행렬
    // 5. 사원수
    // 6. 곡선

    //1-1 삼각함수
    //sin

    private void Start()
    {
        float angle = 45; //각도
        Debug.Log(Mathf.Sin(angle * Mathf.Deg2Rad));
        Debug.Log(Mathf.Cos(angle * Mathf.Deg2Rad));
        Debug.Log(Mathf.Tan(angle * Mathf.Deg2Rad));

        //유니티에서 준 sin, cos 함수에서 빗변의 길이는 1로 설정
        //Sin 과 Cos은
        Vector2 vector2;
        vector2.x = Mathf.Cos(angle * Mathf.Deg2Rad);
        vector2.y = Mathf.Sin(angle * Mathf.Deg2Rad);
    }

    private void Update()
    {
        Vector2 vector2;
        vector2.x = Mathf.Cos(Time.time * 360 * Mathf.Deg2Rad);
        vector2.y = Mathf.Sin(Time.time * 360 * Mathf.Deg2Rad);
        transform.position = vector2;
    }
}
