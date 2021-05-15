using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalFantasXIX : MonoBehaviour
{
    [SerializeField] Text storyText;
    [SerializeField] State startingState;

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        storyText.text = state.GetStateText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
