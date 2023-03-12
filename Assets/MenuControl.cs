using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControl : MonoBehaviour
{

    [SerializeField]
    Slider slider;

    [SerializeField]
    TMP_Text textForDifficulty;

    public void Quit()
    {
        Application.Quit();
    }
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    static public void LoadScene(string sceneName, bool isStatic)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void UpdateDifficulty()
    {
        switch (slider.value)
        {
            case 0:
                textForDifficulty.text = "EASY";
                UserInterface.SetDifficulties((int)slider.value);
                
                break;

            case 1:
                textForDifficulty.text = "MEDIUM";
                UserInterface.SetDifficulties((int)slider.value);

                break;

            case 2:
                textForDifficulty.text = "HARD";
                UserInterface.SetDifficulties((int)slider.value);
                break;


        }
    }
}
