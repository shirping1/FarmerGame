using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    // �ش� �۾��� �����ϱ� ���ؼ��� ������Ʈ�� Collider ������Ʈ�� �־����
    // ����Ƽ ���콺, ��ġ ���� �̺�Ʈ �Լ�
    // 1. OnMouseOver() �ش� ������Ʈ�� ���콺�� �ö� ��� ������ ���� ����
    // 2. OnMouseEnter() ���콺�� �ö� ��� 1ȭ
    // 3. OnMouseExit() ���콺�� ��� �� 1ȸ
    // 4. OnMouseUp() ���콺 Ŭ���� ������ ��
    // 5. OnMouseDown() ���콺 Ŭ���� �� ��
    //private void OnMouseOver()
    //{
    //    gameObject.SetActive(false);
    //}

    private void OnMouseDown()
    {
        gameObject.SetActive(false);
    }

}
