using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerController : MonoBehaviour
{
    public float move_speed;
    Rigidbody2D rbody2D;
    PlantPool plantPool;
    bool onFarm = false;

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
            if (onFarm)
            {
                plantPool.Seed(gameObject.transform);
            }
            else
            {
                Debug.Log("이곳에는 식물을 심을 수 없습니다.");
            }
        }
    }

    void Move()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        rbody2D.velocity = new Vector2(h * move_speed, v * move_speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Farm")
        {
            onFarm = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Farm")
        {
            onFarm = false;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Plant")
        {
            if (Input.GetKey(KeyCode.E))
            {
                collision.GetComponent<Plant>().GetPlant();
                
            }
        }
    }
}
