using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPattern02 : MonoBehaviour
{
    public GameObject BulletPrefab;



    // Start is called before the first frame update
    void Start()
    {
        
            Pattern02();
        
    }



    void Pattern02()
    {
        // ������ ������ ź�� ������ŭ �ݺ��� ����
        for (int i = 0; i < 50; i++) 
        {
            var bullet = Instantiate(BulletPrefab);
            bullet.transform.position = transform.position;
            bullet.transform.rotation = Quaternion.identity;

            Rigidbody2D rbody = bullet.GetComponent<Rigidbody2D>();

            //�� ��� ���� ���� �� ���
            // x��ǥ, y��ǥ�� ���� ���� ����ϰ� x -> Cos, y -> Sin

            Vector2 direction = new Vector2(Mathf.Cos(Mathf.PI * 2 * i / 50), Mathf.Sin(Mathf.PI * 2 * i / 50));
            rbody.AddForce(direction.normalized * 2.0f, ForceMode2D.Impulse);

            // ����) AddForce�� ���� ���ϳ�, �߻� ������ ���� ȸ�� �� ������ �ȵǼ� ������ �ٸ��� ���� �������� ��ġ�� ���� ���� �������� ��� �Ǵ� ������ �߻�
            
            Vector3 rotation = (Vector3.forward * 360 * i / 50) + Vector3.forward * 90;

            bullet.transform.Rotate(rotation);
        }
    }

}
