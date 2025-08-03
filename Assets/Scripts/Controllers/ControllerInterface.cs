using UnityEngine;

public abstract class ControllerInterface : MonoBehaviour
{
    [Header("References")]
    [SerializeField]
    private Transform EntityBody;

    [Header("Rotation Settings")]
    [SerializeField]
    private float rotationSpeed = 15f; // degrees per second
    public Vector3 LookTarget { get; private set; }
    public Quaternion LookRotationTarget { get; private set; }

    [Header("Movement Settings")]
    [SerializeField]
    private float moveSpeed = 5f;
    private Rigidbody2D rigidbody2D;

    protected void Start()
    {
        Debug.Log("ControllerInterface Start called");
        rigidbody2D = GetComponent<Rigidbody2D>();

        var children = GetComponentsInChildren<Transform>();
        foreach (var child in children)
        {
            if (child.name.ToLower() == "body")
            {
                EntityBody = child;
                break;
            }
        }
        LookTarget = transform.position; // Initialize LookTarget to the current position
        LookRotationTarget = transform.rotation; // Initialize LookRotationTarget to the current rotation
    }

    protected void Update()
    {
        LookTarget = GetLookTarget();
    }

    protected void FixedUpdate()
    {
        UpdateRotation();
    }

    public void UpdateRotation()
    {
        Vector2 direction = (LookTarget - transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        Quaternion targetRotation = Quaternion.AngleAxis(angle, Vector3.forward);
        LookRotationTarget = targetRotation;
        EntityBody.rotation = Quaternion.RotateTowards(
            EntityBody.rotation,
            LookRotationTarget,
            rotationSpeed * Time.fixedDeltaTime
        );
    }

    // <summary>
    // A function that returns the current look target in world space.
    // Logic should be implemented in derived classes:
    // </summary>
    public abstract Vector3 GetLookTarget();
}
