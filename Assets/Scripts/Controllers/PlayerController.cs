using UnityEngine;
using UnityEngine.InputSystem;
using static DebugDraw;

public class PlayerController : ControllerInterface
{
    private InputAction cursorAction;
    private Vector3 cursorWorldPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected void Start()
    {
        Debug.Log("PlayerController Start called");
        cursorAction = InputSystem.actions.FindAction("Player/Look");
        base.Start();
    }

    // Update is called once per frame
    protected void Update()
    {
        base.Update();
    }

    protected void FixedUpdate()
    {
        base.FixedUpdate();
    }

    public override Vector3 GetLookTarget()
    {
        Vector3 cursorInput = cursorAction.ReadValue<Vector2>();
        var cursorPosition = Camera.main.ScreenToWorldPoint(
            new Vector3(cursorInput.x, cursorInput.y, Camera.main.nearClipPlane)
        );
        return new Vector3(cursorPosition.x, cursorPosition.y, 0f);
    }
}
