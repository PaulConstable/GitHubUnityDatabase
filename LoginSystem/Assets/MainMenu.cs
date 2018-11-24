using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public Text playernameDisplay;

    private void Start()
    {
        if(DBManager.LoggedIn)
        {
            playernameDisplay.text = "Player: " + DBManager.username;
        }
    }

    public void GoToRegister ()
    {
        SceneManager.LoadScene("RegisterScene");
    }

    public void GoToLogIn()
    {
        SceneManager.LoadScene("LoginMenu");
    }
}
