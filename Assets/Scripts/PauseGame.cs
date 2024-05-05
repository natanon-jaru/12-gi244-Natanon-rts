using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class PauseGame : MonoBehaviour
{
    private bool Pause = false;
    [SerializeField] private TextMeshProUGUI PauseText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Pause)
            {
                NotPauseG();
            }
            else
            {
                PauseG();
            }
        }
    }

    void PauseG()
    {
        Time.timeScale = 0f;
        Pause = true;
        Debug.Log("Game Paused");
        PauseText.gameObject.SetActive(true);
    }

    void NotPauseG()
    {
        Time.timeScale = 1f;
        Pause = false;
        Debug.Log("Stop Paused");
        PauseText.gameObject.SetActive(false);
    }
}
