using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFSignalLight : MonoBehaviour {

    public GameObject redLight;
    public GameObject yellowLight;
    public GameObject greenLight;

    Renderer rendGreen;
    Renderer rendRed;
    Renderer rendYellow;


    public IEnumerator SetRed()
    {
        if (rendRed.material.GetColor("_EmissionColor") != Color.red)
        {
            rendGreen.material.SetColor("_EmissionColor", Color.white);
            rendYellow.material.SetColor("_EmissionColor", Color.yellow);
            Debug.Log("yellow");

            yield return new WaitForSeconds(1);
            rendYellow.material.SetColor("_EmissionColor", Color.white);
            rendRed.material.SetColor("_EmissionColor", Color.red);
            Debug.Log("red");
        }


    }

    public void GreenOn()
    {
        StartCoroutine(SetGreen());
    }

    public void RedOn()
    {
        StartCoroutine(SetRed());
    }



    public IEnumerator SetGreen()
    {
        if (rendGreen.material.GetColor("_EmissionColor") != Color.green)
        {
            rendRed.material.SetColor("_EmissionColor", Color.white);
            rendYellow.material.SetColor("_EmissionColor", Color.yellow);
            Debug.Log("yellow");
            yield return new WaitForSeconds(1);
            rendYellow.material.SetColor("_EmissionColor", Color.white);
            rendGreen.material.SetColor("_EmissionColor", Color.green);
            Debug.Log("red");

        }


    }

    public void Start()
    {
        rendGreen = greenLight.GetComponent<Renderer>();
        rendYellow = yellowLight.GetComponent<Renderer>();
        rendRed = redLight.GetComponent<Renderer>();

        //rendGreen.material.DisableKeyword ("_EMISSION");



    }

    
}
