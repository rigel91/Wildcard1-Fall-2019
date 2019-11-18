using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void OptionsButton()
    {
        SceneManager.LoadScene("OptionsScene");
    }

    public void CreditsButton()
    {
        SceneManager.LoadScene("CreditsScene");
    }
}
