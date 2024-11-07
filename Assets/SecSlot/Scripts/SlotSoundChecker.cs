using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SlotSoundChecker : MonoBehaviour
{
    public AudioSource audioSource;

    public TMP_Text[] texts;
    public string[] translates;

    private void OnEnable()
    {
        if (Translator.instance.isPortu)
        {
            Translate();
        }
    }

    public void Translate()
    {
        
        {
            for (int i = 0; i < texts.Length; i++)
            {
                texts[i].text= translates[i];
            }
        }
    }
    private void Start()
    {
        if (PlayerPrefs.GetString("Sound")=="true")
        {
            audioSource.Play();
        }
        else
        {
            audioSource.Pause();
        }
    }
}
