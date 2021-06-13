using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class somTema : MonoBehaviour
{

    public AudioSource temaSelecionado;
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(temaSelecionado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
