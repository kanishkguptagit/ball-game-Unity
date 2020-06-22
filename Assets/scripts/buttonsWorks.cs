using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonsWorks : MonoBehaviour
{
    
    public void onPressPlay()
    {
        SceneManager.LoadScene(1);
    }
    public void onPressQuit()
    {
        Application.Quit();
    }
}
