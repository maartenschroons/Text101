using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;
    State state;
    bool roomKey;


    void Start()
    {
        state = startingState;
        textComponent.text = state.getStateStory();
        roomKey = false;
    }


    // Update is called once per frame
    void Update()
    {
        ManageState();
        if (state.getRoomKey())
        {
            roomKey = state.getRoomKey();
        }
    }

    private void ManageState()
    {
        var nextStates = state.getNextstates();
        if (state.getRoomDoor())
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                if (roomKey)
                {
                    state = nextStates[2];
                }
                else
                {
                    state = nextStates[0];
                }
                
            }else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                state = nextStates[1];
            }
        }
        else
        {
            for (int i = 0; i < nextStates.Length; i++)
            {
                if (Input.GetKeyDown(KeyCode.Alpha1 + i))
                {
                    state = nextStates[i];
                }
            }
        }

        textComponent.text = state.getStateStory();
    }
}
