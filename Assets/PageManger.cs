using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PageManger : MonoBehaviour
{
    [SerializeField] private GameObject[] pages;

    [SerializeField] private string[] names;

    [SerializeField] private TextMeshProUGUI text;
    
    private int num;

    public void Next()
    {
        num++;
        if (num >= pages.Length)
        {
            num = 0;
        }
        OnOff();
    }

    public void Pervous()
    {
        num--;
        if (num < 0)
        {
            num = 2;
        }
        OnOff();
    }

    private void OnOff()
    {
        for (int i = 0; i < pages.Length; i++)
        {
            pages[i].SetActive(false);
        }
        pages[num].SetActive(true);
        text.text = names[num];
    }

    private void Update()
    {
        Debug.Log(pages.Length);
    }
}
