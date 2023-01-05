using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour

{
    private void OnTriggerEnter(Collider other)
    {




        Color randomlySelectedColor = GetRandomColorWithAlpha();
        GetComponent<Renderer>().material.color = randomlySelectedColor;
    }

    private Color GetRandomColorWithAlpha()

    {
        return new Color(
        r: UnityEngine.Random.Range(0f, 1f),
        g: UnityEngine.Random.Range(0f, 1f),
        b: UnityEngine.Random.Range(0f, 1f),
        a: 0.25f);
    }
}
