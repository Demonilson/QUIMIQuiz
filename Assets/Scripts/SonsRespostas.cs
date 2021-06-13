using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonsRespostas : MonoBehaviour
{

    private static SonsRespostas sonsRespostas;
    // Start is called before the first frame update

    public GameObject cenario;
    public GameObject somSelecionado;

    void Awake()
    {

        
        if (sonsRespostas == null)
        {
            DontDestroyOnLoad(cenario);
            DontDestroyOnLoad(somSelecionado);
        }

        else
        {
            Destroy(cenario);
            Destroy(somSelecionado);
        }

    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
