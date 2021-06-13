using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rspostaCorreta : MonoBehaviour
{
    private static SonsRespostas sonsRespostas;
    // Start is called before the first frame update

    public GameObject somCorreto;

    void Awake()
    {


        if (sonsRespostas == null)
        {
            DontDestroyOnLoad(somCorreto);
        }

        else
        {
            Destroy(somCorreto);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
