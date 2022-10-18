using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        int selectedPlayer = int.Parse(EventSystem.current.currentSelectedGameObject.name);


        Gamemanager.instance.charIndex = selectedPlayer;
        SceneManager.LoadScene("Gameplay");
    }
}
