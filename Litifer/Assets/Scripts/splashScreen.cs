using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class splashScreen : MonoBehaviour
{

    void Start()
    {
       
         //   Invoke("change", 3f);
    }

    public void change()
    {
        SceneManager.LoadScene("scrollview");
    }
    public void Update()
    {
        if (Input.touchCount == 1)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                change();
            }
        }



        if (Application.platform == RuntimePlatform.Android)
            {
                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    Application.Quit();
                }
            }
    }
}
