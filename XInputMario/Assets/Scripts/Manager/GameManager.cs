using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    private InputManager inputManager;

    public void Start()
    {
        SetInputDevice();
        inputManager.Start();
    }

    public void Update() =>
        inputManager.Update();

    public void SetInputDevice()
    {
    #if UNITY_ANDROID
        inputManager = new InputManager(new MobileXInput());
    #endif //UNITY_ANDROID

    #if UNITY_EDITOR_WIN || UNITY_STANDALONE_WIN
        inputManager = new InputManager(new PCXInput());
    #endif //UNITY_EDITOR_WINDOWS || UNITY_STANDALONE_WINDOWS
    }

}
