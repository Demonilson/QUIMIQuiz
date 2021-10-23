using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.Sprites;
public class responder : MonoBehaviour
{

    private int idTema;

    public Text pergunta;
    public Text respostaA;
    public Text respostaB;
    public Text respostaC;
    public Text respostaD;
    public Text infoRespostas;
    public Text respostaCerta;
    public Text dicaPergunta;

    public AudioSource[] sons;
    public GameObject painelDicas;
    public GameObject respostaCorreta;
    public GameObject respostaErrada;
    public GameObject painelPergunta;

    public Button botãoA;
    public Button botãoB;
    public Button botãoC;
    public Button botãoD;
    public Button dica;
    public Button fecharDica;
    public Image imagemPergunta;
    public Button btnProximaPergunta;


    public string[] perguntas;         //armazenas as perguntas
    public string[] alternativaA;      //armazena as alternativas A
    public string[] alternativaB;      //armazena as alternativas B
    public string[] alternativaC;      //armazena as alternativas C
    public string[] alternativaD;      //armazena as alternativas D
    public string[] corretas;          //armazena as alternativas corretas
    public Sprite[] imagemDasQuestoes; //armazena as imagens das dicas
    public string[] dicas;           //armazena as dicas


    private int   idPergunta;

    private float acertos;
    private float questoes;
    private float media;
    private int notaFinal;

    // Start is called before the first frame update
    void Start()
    {

        idTema = PlayerPrefs.GetInt("idTema");

        idPergunta = 0;
        questoes = perguntas.Length;

        pergunta.text =     perguntas[idPergunta];
        respostaA.text =    alternativaA[idPergunta];
        respostaB.text =    alternativaB[idPergunta];
        respostaC.text =    alternativaC[idPergunta];
        respostaD.text =    alternativaD[idPergunta];
        imagemPergunta.sprite = imagemDasQuestoes[idPergunta];
        




        dicaPergunta.text = dicas[idPergunta];

        infoRespostas.text = "Respondendo " + (idPergunta + 1).ToString() + " de " + questoes.ToString()+" perguntas";
 
    }

   

    public void resposta(string alternativa)
    {
        
        if (alternativa == "A")
        {
            //EXECUTA O COMANDO PARA RESPOSTA A
            if(alternativaA[idPergunta] == corretas[idPergunta])
            {
                acertos += 1;
                Correta();
                sons[0].Play();
            }
            else if (alternativaA[idPergunta] != corretas[idPergunta])
            {
                sons[1].Play();
                Errada();
                respostaCerta.text = "Que pena, você errou. A resposta correta é " + (corretas[idPergunta].ToString());
            }

        }

        else if(alternativa == "B")
        {
            //EXECUTA O COMANDO PARA RESPOSTA B
            if (alternativaB[idPergunta] == corretas[idPergunta])
            {
                acertos += 1;
                Correta();
                sons[0].Play();

            }

            else if(alternativaB[idPergunta] != corretas[idPergunta])
            {
                respostaCerta.text = "Que pena, você errou. A resposta correta é " + (corretas[idPergunta].ToString());
                sons[1].Play();
                Errada();
            }
        }

        else if(alternativa == "C")
        {
            //EXECUTA O COMANDO PARA RESPOSTA C
            if (alternativaC[idPergunta] == corretas[idPergunta])
            {
                acertos += 1;
                Correta();
                sons[0].Play();

            }
            else if (alternativaC[idPergunta] != corretas[idPergunta])
            {
                respostaCerta.text = "Que pena, você errou. A resposta correta é " + (corretas[idPergunta].ToString());
                sons[1].Play();
                Errada();
            }

        }

        else if(alternativa == "D")
        {
            //EXECUTA O COMANDO PARA RESPOSTA D
            if (alternativaD[idPergunta] == corretas[idPergunta])
            {
                acertos += 1;
                Correta();
                sons[0].Play();

            }
            else if (alternativaD[idPergunta] != corretas[idPergunta])
            {
                respostaCerta.text = "Que pena, você errou. A resposta correta é " + (corretas[idPergunta].ToString());
                sons[1].Play();
                Errada();
            }
        }
    }

    public void mostrarPainel()
    {
        painelDicas.gameObject.SetActive(true);
        dica.gameObject.SetActive(false);
        fecharDica.gameObject.SetActive(true);
    }
    public void ocultarPainel()
    {
        painelDicas.gameObject.SetActive(false);
        dica.gameObject.SetActive(true);
        fecharDica.gameObject.SetActive(false);
    }

    public void mostrarBotoes()
    {
        botãoA.gameObject.SetActive(true);
        botãoB.gameObject.SetActive(true);
        botãoC.gameObject.SetActive(true);
        botãoD.gameObject.SetActive(true);
    }
    public void ocultarBotoes()
    {
        botãoA.gameObject.SetActive(false);
        botãoB.gameObject.SetActive(false);
        botãoC.gameObject.SetActive(false);
        botãoD.gameObject.SetActive(false);
    }

    void Correta()
    {
        respostaCorreta.gameObject.SetActive(true);
        btnProximaPergunta.gameObject.SetActive(true);
        painelPergunta.gameObject.SetActive(false);
        pergunta.gameObject.SetActive(false);
        botãoA.gameObject.SetActive(false);
        botãoB.gameObject.SetActive(false);
        botãoC.gameObject.SetActive(false);
        botãoD.gameObject.SetActive(false);
        dica.gameObject.SetActive(false);

    }
    void Errada()
    {
        respostaErrada.gameObject.SetActive(true);
        btnProximaPergunta.gameObject.SetActive(true);
        painelPergunta.gameObject.SetActive(false);
        pergunta.gameObject.SetActive(false);
        botãoA.gameObject.SetActive(false);
        botãoB.gameObject.SetActive(false);
        botãoC.gameObject.SetActive(false);
        botãoD.gameObject.SetActive(false);
        dica.gameObject.SetActive(false);
    }

    public void AvancarPergunta()
    {
        respostaCorreta.gameObject.SetActive(false);
        respostaErrada.gameObject.SetActive(false);
        btnProximaPergunta.gameObject.SetActive(false);
        painelPergunta.gameObject.SetActive(true);
        pergunta.gameObject.SetActive(true);
        botãoA.gameObject.SetActive(true);
        botãoB.gameObject.SetActive(true);
        botãoC.gameObject.SetActive(true);
        botãoD.gameObject.SetActive(true);
        dica.gameObject.SetActive(true);
        proximaPergunta();
        
    }
    void proximaPergunta()
    {
        idPergunta += 1;

        if (idPergunta <= (questoes - 1))
        {


            pergunta.text = perguntas[idPergunta];
            respostaA.text = alternativaA[idPergunta];
            respostaB.text = alternativaB[idPergunta];
            respostaC.text = alternativaC[idPergunta];
            respostaD.text = alternativaD[idPergunta];
            imagemPergunta.sprite = imagemDasQuestoes[idPergunta];
            dicaPergunta.text = dicas[idPergunta];

            infoRespostas.text = "Respondendo " + (idPergunta + 1).ToString() + " de " + questoes.ToString() + " perguntas";
        }
        else
        {

            media = 10 * (acertos / questoes);  //calcula a media de acertos com base no percentual
            notaFinal = Mathf.RoundToInt(media); //arendonda a nota para mais ou para menos

            if (notaFinal > PlayerPrefs.GetInt("notaFinal" + idTema.ToString()))
            {
                PlayerPrefs.SetInt("notaFinal" + idTema.ToString(), notaFinal);
                PlayerPrefs.SetInt("acertos" + idTema.ToString(), (int)acertos);
            }

            PlayerPrefs.SetInt("notaFinalTemp" + idTema.ToString(), notaFinal);
            PlayerPrefs.SetInt("acertosTemp" + idTema.ToString(), (int)acertos);

            SceneManager.LoadScene("notaFinal");

  
        }

    
    }

}
