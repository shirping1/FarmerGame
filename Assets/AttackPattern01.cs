using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPattern01 : MonoBehaviour
{
    public GameObject BulletPrefab;

    // 부채꼴 모양 발사 기능
    private void Start()
    {
    }

    private void Update()
    {
        FireSector();
        
    }

    private void FireSector()
    {
        var bullet = Instantiate(BulletPrefab);
        Rigidbody2D rbody = bullet.GetComponent<Rigidbody2D>();
        Vector2 dir = new Vector2(Mathf.Cos(Mathf.PI * Time.time), -1);
        rbody.AddForce(dir.normalized * 3, ForceMode2D.Impulse);
    }
}
