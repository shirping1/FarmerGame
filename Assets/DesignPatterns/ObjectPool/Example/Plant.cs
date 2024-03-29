using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    public Sprite[] images = new Sprite[3];
    float checkTime = 0.0f;
    int nowImage = 0;
    SpriteRenderer mySpriteRenderer;
    private void Awake()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        nowImage = 0;
        mySpriteRenderer.sprite = images[nowImage];
    }

    private void OnEnable()
    {
        checkTime = 0.0f;
        mySpriteRenderer.sprite = images[nowImage];
    }

    // Update is called once per frame
    void Update()
    {
        checkTime += Time.deltaTime;
        ChangeImage();
    }

    void ChangeImage()
    {
        if (checkTime >= 5.0f && nowImage < images.Length - 1)
        {
            nowImage++;
            mySpriteRenderer.sprite = images[nowImage];
            checkTime = 0.0f;
        }
    }

    public void GetPlant()
    {
        switch (nowImage)
        {
            case 0:
                gameObject.SetActive(false);
                UIController.Instance.GetPoint(0);
                break;
            case 1:
                gameObject.SetActive(false);
                UIController.Instance.GetPoint(10);
                break;
            case 2:
                gameObject.SetActive(false);
                UIController.Instance.GetPoint(20);
                break;
        }
        nowImage = 0;
    }
}
