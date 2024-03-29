using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float move_speed;
    Rigidbody2D rbody2D;
    PlantPool plantPool;

    // Start is called before the first frame update
    void Start()
    {
        rbody2D = GetComponent<Rigidbody2D>();
        plantPool = GameObject.Find("PlantPool").GetComponent<PlantPool>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            plantPool.Seed(gameObject.transform);
        }
    }

    void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        rbody2D.velocity = new Vector2(h * move_speed, v * move_speed);
    }
}
