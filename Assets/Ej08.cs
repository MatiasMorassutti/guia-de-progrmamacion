//8. Crear una variable entera que pueda ser modificada desde el Inspector.Suponiendo que el primer día de la semana es el Domingo, mostrar el nombre del día correspondiente al valor de la variable “dia”. Si el día no está en el rango  permitido debe emitir por pantalla el mensaje de error "El día ingresado no es válido". 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej08 : MonoBehaviour
{
    public int dado1;
    public int dado2;
    public int dado3;
    int cantSeis;
    // Start is called before the first frame update
    void Start()
    {
        if (dado1 == 6)
        {
            cantSeis++;
        }
        if (dado2 == 6)
        {
            cantSeis++;
        }
        if (dado3 == 6)
        {
            cantSeis++;
        }

        switch (cantSeis)
        {
            case 3:
                Debug.Log("Excelente");
                break;
            case 2:
                Debug.Log("Muy bueno");
                break;
            case 1:
                Debug.Log("Bueno");
                break;
            default:
                Debug.Log("Insuficiente");
                break;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
