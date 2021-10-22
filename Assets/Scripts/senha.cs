using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class senha : MonoBehaviour
{

    public Text textoDaSenha;

    // Update is called once per frame
    void Update()
    {
        if (textoDaSenha.text == "19734642")
        {
            carregaCena("Título");
        }
       
    }
    public void carregaCena(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);
    }
}