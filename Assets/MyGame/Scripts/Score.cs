using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField]
    int score;
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void Count()
    {
        score += 1;
        gameObject.GetComponent<TextMeshProUGUI>().text = score.ToString();
    }
}
