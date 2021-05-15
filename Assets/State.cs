using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = ("State"))]
public class State : ScriptableObject
{
    [TextArea(10, 14)] [SerializeField] string storyText;
    [SerializeField] string optionLeft;
    [SerializeField] string optionRight;
    [SerializeField] State[] nextStates;


    public string GetStateText()
    {
        return storyText;
    }

    public string GetLeftOptionText()
    {
        return optionLeft;
    }
    public string GetRightOptionText()
    {
        return optionRight;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }
}
