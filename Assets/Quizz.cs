using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Quizz : MonoBehaviour
{
    public TextMeshProUGUI texto;

    // Start is called before the first frame update
    void Start()
    {
         texto.text = "¿Cuál es tu canción favorita de MINISODE 2:Thursday's Child de TOMORROW BY TOGETHER?";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            texto.text = "Lonely Boy";
            texto.text = "Soy un chico solitario que se queda solo";
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            texto.text = "Quedáte por mí, no puedo acostumbrarme a esto";
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            texto.text = "Los chicos buenos se volvieron malos";
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            texto.text ="Soy un amante sin ningún dolar";
        }
    }
}
