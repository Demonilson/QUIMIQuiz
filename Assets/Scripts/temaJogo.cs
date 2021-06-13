using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class temaJogo : MonoBehaviour
{

    public Button       btnPlay;
    public Text         txtNomeTema;

    public GameObject   infoTema;
    public Text         txtInfoTema;
    public GameObject   estrela1;
    public GameObject   estrela2;
    public GameObject   estrela3;

    public Button btnTema1;
    public Button btnTema2;
    public Button btnTema3;
    public Button btnTema4;
    public Button btnTema5;


    public string[]     nomeTema;
    public int          numeroQuestoes;

    private int         idTema;

    // Start is called before the first frame update
    void Start()
    {     

        idTema = 0;
        PlayerPrefs.SetInt("idTema", idTema);
        txtNomeTema.text = nomeTema[idTema];
        txtInfoTema.text = "Você acertou X de X questões!";
        infoTema.SetActive(false);
        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);
        btnPlay.interactable = false;


        }

   

    public void selecioneTema(int i)
    {
        idTema = i;

        PlayerPrefs.SetInt("idTema", idTema);
        txtNomeTema.text = nomeTema[idTema];

        int notaFinal = PlayerPrefs.GetInt("notaFinal" + idTema.ToString());
        int acertos = PlayerPrefs.GetInt("acertos" + idTema.ToString());

        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);

        if (notaFinal == 10)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(true);
        }

        else if (notaFinal >= 7)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(false);
        }

        else if (notaFinal >= 3)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(false);
            estrela3.SetActive(false);
        }

        txtInfoTema.text = "Você acertou " + acertos.ToString() + " de " + numeroQuestoes.ToString() + " questões";
        
        infoTema.SetActive(true);
        btnPlay.interactable = true;

       

    }
    public void jogar()
    {
        SceneManager.LoadScene("T" + idTema.ToString());
    }
}
