using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class comandosBasicos : MonoBehaviour
{

    

    public void carregaCena(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);
    }

    public void zerarpontuação()
    {
        PlayerPrefs.DeleteAll();
    }

    public void sairJogo()
    {
        Application.Quit();
    }

  
}
