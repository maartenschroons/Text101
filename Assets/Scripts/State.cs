using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    
    [TextArea(14,10)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates;
    [SerializeField] bool roomKey;
    [SerializeField] bool roomDoor;

    public State[] getNextstates()
    {
 
        return nextStates;
    }

    public string getStateStory()
    {
        return storyText;
    }

    public bool getRoomKey()
    {
        return roomKey;
    }

    public bool getRoomDoor()
    {
        return roomDoor;
    }
}
