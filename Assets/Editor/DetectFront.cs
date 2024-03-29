using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Detector))] // ������ Ÿ���� ������� ����
public class DetectFront : Editor
{
    //GUI ȯ�濡�� ó���� ����� �ۼ��ϴ� ��ġ
    private void OnSceneGUI()
    {
        // Ÿ���� �����ͷ� ����ϴ�.
        Detector detector = (Detector)target;

        Handles.color = Color.red;
        // �ڵ��� ���� red�� ����

        Handles.DrawLine(detector.transform.position, detector.transform.forward * 2.0f, 3.0f);
        // �ڵ��� ���� �������� ��ġ���� �� �������� 2��ŭ ���� �׸��ڽ��ϴ�. ����� 3

        Handles.color = Color.green;
        //�ڵ��� ���� �ʷϻ����� �����ϴ� �۾�

        Handles.DrawLine(Vector3.zero, AngleDirection(detector.angle) * 0.5f * detector.radius); // ������
        Handles.DrawLine(Vector3.zero, AngleDirection(detector.angle) * -1 * 0.5f * detector.radius); // ����

    }

    Vector3 AngleDirection(float angle) => new Vector3(Mathf.Sin(angle * Mathf.Deg2Rad), Mathf.Cos(angle * Mathf.Deg2Rad), 0);

}
