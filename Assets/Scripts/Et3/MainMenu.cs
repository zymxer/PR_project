using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ServerButton()
    {
        SceneManager.LoadSceneAsync("Server");
    }

    public void ClientButton()
    {
        SceneManager.LoadSceneAsync("Client");
    }
}
