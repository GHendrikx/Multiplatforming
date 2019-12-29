using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    private InputManager inputManager;

    [SerializeField]
    private Player player;

    public void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex != 0)
            SetInputDevice();
        inputManager.Start();
    }

    public void Update() =>
        inputManager.Update();

    public void SetInputDevice()
    {
#if UNITY_ANDROID
        inputManager = new InputManager(new MobileXInput(player));
#endif //UNITY_ANDROID

#if UNITY_EDITOR_WIN || UNITY_STANDALONE_WIN
        inputManager = new InputManager(new PCXInput(player));
#endif //UNITY_EDITOR_WINDOWS || UNITY_STANDALONE_WINDOWS
    }
}
