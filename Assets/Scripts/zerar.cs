using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class zerar : MonoBehaviour
{
    public void zerarpontuação()
    {
        PlayerPrefs.DeleteAll();
    }

    public void carregaCena(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);
    }
}
