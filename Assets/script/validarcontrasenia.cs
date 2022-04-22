using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class validarcontrasenia : MonoBehaviour
{
    string contraseñacorrecta;
    string contraseñausuario;
     public Text ingresousuario;
    public Text textoMsj;
    public GameObject cartelitoMsj;
    // Start is called before the first frame update
    void Start()
    {
        contraseñacorrecta = "12345";
        cartelitoMsj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void validarcontrasenias()
    {
        contraseñausuario = ingresousuario.text;
        if(contraseñausuario == contraseñacorrecta)
        {
            cartelitoMsj.SetActive(true);
            textoMsj.text = "bienvenido";
            Debug.Log("bienvenido");
        }
        else
        {
            cartelitoMsj.SetActive(true);
            textoMsj.text = "contraseña incorrecta";
            Debug.Log("contraseña incorrecta");
        }
    }
}
