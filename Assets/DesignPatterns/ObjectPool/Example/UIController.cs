using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Text pointText;
    int point;

    public static UIController Instance;

    private void Start()
    {
        Instance = this;
        point = 0;
    }

    public void GetPoint(int point)
    {
        this.point += point;
        pointText.text = this.point.ToString();
    }

}
