using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    public static int score = 0;

    public GameObject item;
    public TextMeshProUGUI scoreText;

    public void Collect()
    {
        score++;
        scoreText.text = "SCORE: " + score.ToString(); 
        Destroy(item);
    }
}
