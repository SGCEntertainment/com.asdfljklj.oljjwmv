using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Item : MonoBehaviour
{
    [SerializeField] private string text, text1;

    [SerializeField] private TextMeshProUGUI t;

    private void Start()
    {
        t.text = text;
    }

    public void Click()
    {
        Pnel.instance.SetRes(text, text1);
    }
}
