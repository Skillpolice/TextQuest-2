using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step : MonoBehaviour
{
    [TextArea(15, 50)]
    public string content;
    public string location;
    public Sprite sprite;

    public Step[] nextSteps;
}
