using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���α׷��� �⺻ �̷� (���� ����)
public class Tigonometry : MonoBehaviour
{
    // ���� ���п��� �ٷ�� �͵�
    // 1. �ﰢ�Լ�
    // 2. ��ǥ
    // 3. ����
    // 4. ���
    // 5. �����
    // 6. �

    //1-1 �ﰢ�Լ�
    //sin

    private void Start()
    {
        float angle = 45; //����
        Debug.Log(Mathf.Sin(angle * Mathf.Deg2Rad));
        Debug.Log(Mathf.Cos(angle * Mathf.Deg2Rad));
        Debug.Log(Mathf.Tan(angle * Mathf.Deg2Rad));

        //����Ƽ���� �� sin, cos �Լ����� ������ ���̴� 1�� ����
        //Sin �� Cos��
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
