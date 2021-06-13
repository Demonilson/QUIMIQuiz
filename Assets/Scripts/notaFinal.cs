using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class notaFinal : MonoBehaviour
{

    private int idTema;

    public Text txtNota;
    public Text txtInfoTema;

    public Button btnTemas;
    public Button btnHome;
    public GameObject estrela1;
    public GameObject estrela2;
    public GameObject estrela3;

    public AudioSource som;
    public AudioSource errouTudo;

    private int notaF;
    private int acertos;

    public int numeroQuestoes;
   

    // Start is called before the first frame update
    void Start()
    {

        idTema = PlayerPrefs.GetInt("idTema");

        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);
        
        notaF = PlayerPrefs.GetInt("notaFinalTemp" + idTema.ToString());
        acertos = PlayerPrefs.GetInt("acertosTemp" + idTema.ToString());

        txtNota.text = notaF.ToString();

            txtInfoTema.text = "Você acertou " + acertos.ToString() + " de " + numeroQuestoes.ToString() + " questões";

        if (notaF == 10)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(true);

            txtInfoTema.text = "Parabens, você acertou todas as questões!";

            ReproduzirSom();

        }

        else if (notaF >= 7)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(false);
        }

        else if(notaF >= 3)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(false);
            estrela3.SetActive(false);
        }

        if(notaF == 0)
        {
            txtInfoTema.text = "Parece que você errou todas as questões, tente novamente.";
            btnTemas.interactable = false;
            btnHome.interactable = false;

            ErrouTudo();
        }



    }

    void ReproduzirSom()
    {
        som.Play();
    }

    void ErrouTudo()
    {
        errouTudo.Play();
    }

    public void jogarNovamente()
    {
        SceneManager.LoadScene("T" + idTema.ToString());
    }
}
