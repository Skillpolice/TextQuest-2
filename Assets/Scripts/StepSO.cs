using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Step", fileName = "New Step")]
public class StepSO : ScriptableObject
{
    [TextArea(15, 50)]
    public string content;
    public string location;
    public Sprite sprite;

    public StepSO[] nextSteps;
}
