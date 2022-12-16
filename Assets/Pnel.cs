using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pnel : MonoBehaviour
{
    public static Pnel instance;

    [SerializeField] private TextMeshProUGUI text, text1;


    private void Awake()
    {
        instance = this;
    }

    public void SetRes(string t, string t1)
    {
        text.text = t;
        text1.text = t1;
    }
}
