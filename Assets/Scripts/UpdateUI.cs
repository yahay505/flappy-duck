using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateUI : MonoBehaviour
{
    public TextMeshProUGUI text,highscoretext;
    private void Update()
    {
        text.text =GameManager.Score.ToString();
        highscoretext.text = GameManager.HighScore.ToString();

    }
}
