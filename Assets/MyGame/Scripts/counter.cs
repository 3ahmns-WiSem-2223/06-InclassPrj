using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class counter : MonoBehaviour
{
    Vector3 position;
    float x;
    float y;
    [SerializeField]
    Score score;
    

    void Update()
    {
        x = Random.Range(10f, -10f);
        y = Random.Range(3.1f, -3.1f);
    }

    public void Pressed()
    {
        score.Count();
        
        position = new Vector3(x, y, 0);
        gameObject.SetActive(false);
        gameObject.transform.position = position;
        gameObject.SetActive(true);
        
    }
}



