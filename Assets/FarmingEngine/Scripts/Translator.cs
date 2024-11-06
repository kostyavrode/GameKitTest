using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Translator : MonoBehaviour
{
    public static Translator instance;
    public string[] portugalWord;
    public Text[] texts;

    public bool isPortu;

    private void Awake()
    {
        instance = this;
        if (SwitchToPortu.instance.isPortu)
        {
            TranslateToPortugal();
            isPortu = true;
        }
        else
        {
            Debug.Log("NOT PORTY");
        }
    }

    public void TranslateToPortugal()
    {
        for (int i = 0; i < texts.Length; i++)
        {
            Debug.Log("Translated");
            texts[i].text=portugalWord[i];
        }
    }
}
