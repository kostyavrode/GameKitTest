using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptySceneTest : MonoBehaviour
{
    public UniWebView uniWebView;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(uniWebView.GetUserAgent());
        }
    }
}
