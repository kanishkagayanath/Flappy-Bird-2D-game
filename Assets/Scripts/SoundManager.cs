using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public GameObject PlayerFly; // Assign this in the inspector.
    public GameObject gameoversound; // Assign this in the inspector.

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject); // Ensures only one SoundManager instance exists.
        }
    }
}

