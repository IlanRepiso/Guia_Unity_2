using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene1 : MonoBehaviour
{
    public int edad;
    public Text miTexto;

    // Start is called before the first frame update
    void Start()
    {
        if (edad < 18)
        {
            miTexto.text = "Es menor de edad";
            Debug.Log("Es menor de edad"); 
        }
        else
        {
            miTexto.text = "Es mayor de edad";
            Debug.Log("Es mayor de edad");
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
