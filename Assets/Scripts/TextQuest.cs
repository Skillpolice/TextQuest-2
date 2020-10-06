using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuest : MonoBehaviour
{
    public Text contentText;
    public Text locationText;
    public Image image;

    public Step startStep;

    public Step currentStep;


    // Start is called before the first frame update
    void Start()
    {
        currentStep = startStep;
        UpdateElements();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CheckNumber(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            CheckNumber(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            CheckNumber(2);
        }
    }

    private void CheckNumber(int number)
    {
        if (currentStep.nextSteps.Length > number)
        {
            if (currentStep.nextSteps[number] != null)
            {
                currentStep = currentStep.nextSteps[number];
                UpdateElements();
            }
        }
    }

    private void UpdateElements()
    {
        contentText.text = currentStep.content;
        locationText.text = currentStep.location;
        image.sprite = currentStep.sprite;
    }
}
