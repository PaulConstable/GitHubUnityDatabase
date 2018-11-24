﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Regristration : MonoBehaviour {


    public InputField emailField;
    public InputField nameField;
    public InputField passwordField
;

    public Button submitButton;

    public void CallRegister()
    {
        StartCoroutine(Register());
    }

    IEnumerator Register()
    {
        WWWForm form = new WWWForm();
        form.AddField("email", emailField.text);
        form.AddField("name", nameField.text);
        form.AddField("password", passwordField.text);
        WWW www = new WWW("https://kunet.kingston.ac.uk/k1609271/MultiplayerGame/Register.php", form);
        yield return www;
        if (www.text == "0")
        {
            Debug.Log("User Created Successfully");
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        else
        {
            Debug.Log("User Creation Failed. Error #" + www.text);
        }
    }


        public void VerifyInputs()
        {
            submitButton.interactable = (nameField.text.Length >= 8 && passwordField.text.Length >= 8 && emailField.text.Length >= 8);
        }
    }

