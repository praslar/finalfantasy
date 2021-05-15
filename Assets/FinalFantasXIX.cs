using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalFantasXIX : MonoBehaviour
{
    [SerializeField] Text storyText;
    [SerializeField] State startingState;
    [SerializeField] Text optionLeft;
    [SerializeField] Text optionRight;
    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        storyText.text = state.GetStateText();
        optionLeft.text = state.GetLeftOptionText();
        optionRight.text = state.GetRightOptionText();
    }

    // Update is called once per frame
    void Update()
    {
        var nextStates = state.GetNextStates();
        var nextLeftOption = state;
    }
}
