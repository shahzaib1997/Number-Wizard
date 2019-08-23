using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max, min;
    int guess;
    [SerializeField] TextMeshProUGUI guessText;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
    }

    public void OnPressHigher()
    {
        if (guess != max)
        {
            min = guess + 1;
        }
        NextGuess();
    }

    public void OnPressLower()
    {
        if (guess != min)
        {
            max = guess - 1;
        }
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }
}