using UnityEngine;
using System.Collections;

public class InicioJuegos : MonoBehaviour {

    public void Iniciar_P_vs_IA1()
    {
        Application.LoadLevel("Scene");
    }

    public void Iniciar_P_vs_IA2()
    {
        Application.LoadLevel("Scene2");
    }

    public void Iniciar_IA1_vs_IA2()
    {
        Application.LoadLevel("Scene3");
    }
}
