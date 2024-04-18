using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectSide : MonoBehaviour
{
    [SerializeField] private string mainMenuScene;
    [SerializeField] private string chooseMapScene;

    public void backToMainMenu()
    {
        SceneManager.LoadScene(mainMenuScene);
    }

    private void gotoChooseMap()
    {
        SceneManager.LoadScene(chooseMapScene);
    }

    public void ChooseSide(int i)
    {
        Settings.SelectSide(i);
        gotoChooseMap();
    }
}
