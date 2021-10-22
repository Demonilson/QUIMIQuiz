using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class zerar : MonoBehaviour
{
    public GameObject zerarScore;
    public GameObject painelZerar;
    public GameObject sim;
    public GameObject nao;

    public void zerarpontuação()
    {
        painelZerar.gameObject.SetActive(true);
        sim.gameObject.SetActive(true);
        nao.gameObject.SetActive(true);
        zerarScore.gameObject.SetActive(false);
    }

    public void zerarpontos()
    {
        PlayerPrefs.DeleteAll();
        mostrar();
    }

    public void mostrar()
    {
        painelZerar.gameObject.SetActive(false);
        sim.gameObject.SetActive(false);
        nao.gameObject.SetActive(false);
        zerarScore.gameObject.SetActive(true);
    }

    public void carregaCena(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);
    }
}
