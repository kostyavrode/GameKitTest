using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SwitchToPortu : MonoBehaviour
{
    public static SwitchToPortu instance;
    public bool isPortu;

    public Sprite englHeader;
    public Sprite portuHeader;

    public Image headerPlaceholder;

    public TMP_Text[] texts;
    public string[] translate;
    private void Awake()
    {
        instance = this;
        
    }
    public void SwitchToPortug()
    {
        isPortu = true;
        headerPlaceholder.sprite = portuHeader;
        for (int i=0; i<texts.Length; i++)
        {
            texts[i].text = translate[i];
        }
        Object.DontDestroyOnLoad(gameObject);
    }
}
