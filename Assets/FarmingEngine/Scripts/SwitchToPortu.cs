using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SwitchToPortu : MonoBehaviour
{
    public static SwitchToPortu instance;
    public bool isPortu;

    public TMP_Text[] texts;
    public string[] translate;
    private void Awake()
    {
        instance = this;
        
    }
    public void SwitchToPortug()
    {
        isPortu = true;
        for (int i=0; i<texts.Length; i++)
        {

        }
        Object.Destroy(gameObject);
    }
}
