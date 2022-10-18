using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIcontroller : MonoBehaviour
{

    public void Restart()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void HomePage()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
