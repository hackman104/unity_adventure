using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TypewriterTextEffect : MonoBehaviour
{
    public float interval;

    private TextMeshProUGUI textComponent;
    private int currentWordIndex;
    private float timeElapsed;
    private string[] textWords;
    private string text = @"Jacob stood up and stretched. His company liked to advertise this new generation of hypersleep pods as ‘finally putting the side effects of suspended animation to bed,’ but he and his aching joints begged to differ. Two weeks was a long time to stay in one position, no matter what you did with suspension fluids and oxygenation levels. Maybe they should add an arm to periodically turn you over, he thought; like a chicken in a rotisserie.

Hypersleep pods were a necessary evil, though, for traveling the vast empty space between destinations in the solar system. And Jacob was glad to have one, despite its small inconveniences. It meant he didn’t have to spend this last two weeks doing nothing but reading and re-reading the file on his current assignment.

His sudden recollection of the job at hand triggered a twinge of pride. Sure, he’d already been in the belt repairing a mining vessel, and so had been the nearest engineer the company had when the distress call went out, but they wouldn’t have picked him if they didn’t think he could handle it, and this was priority one.";

    void Start()
    {
        textWords = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        this.textComponent = this.GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        var deltaTime = Time.deltaTime;
        timeElapsed += deltaTime;

        Debug.LogWarning("time elapsed " + timeElapsed);
        if (timeElapsed > interval)
        {
            textComponent.text += textWords[currentWordIndex] + " ";
            currentWordIndex += 1;
            timeElapsed = 0;
        }
    }
}
