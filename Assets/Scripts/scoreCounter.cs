using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreCounter : MonoBehaviour
{
    public Text txtscore;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        txtscore.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        AlimentoScript Alimento;
        Alimento = collision.gameObject.GetComponent<AlimentoScript>();
        score += Alimento.valorAlimentario;
        txtscore.text = score.ToString();
    }
}
