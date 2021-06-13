using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repostaErrada : MonoBehaviour
{
    private static SonsRespostas sonsRespostas;
    public GameObject somIncorreto;

    void Awake()
    {


        if (sonsRespostas == null)
        {
            DontDestroyOnLoad(somIncorreto);
        }

        else
        {
            Destroy(somIncorreto);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
