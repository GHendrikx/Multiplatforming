using UnityEngine;

[System.Serializable]
public class InputManager
{
    private XInput xInput;
    public InputManager(XInput xInput) =>
        this.xInput = xInput;
    // Start is called before the first frame update
    public void Start() =>
        xInput.Start();

    // Update is called once per frame
    public void Update() =>
        xInput.Update();
}
