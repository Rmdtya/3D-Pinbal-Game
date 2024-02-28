using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUIController : MonoBehaviour
{

    public TMP_Text textScore;
    public ScoreManager scoreManager;

    void Update()
    {
        textScore.text = scoreManager.score.ToString();
    }
}
