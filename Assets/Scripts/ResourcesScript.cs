using UnityEngine;

public class Resource : MonoBehaviour
{
    /// <summary>
    /// Name of the resource.
    /// </summary>
    [SerializeField]
    string _name;

    /// <summary> 
    /// Returns the name of the resource.
    /// </summary>
    public string GetName() => _name;

    /// <summary>
    /// Used to count how much of the resource there is.
    /// </summary>
    public float Value { get; private set; }

    /// <summary>
    /// Adds an amount to the resources value.
    /// </summary>
    /// <param name="amount">
    /// The amount to add to the value.
    /// </param>
    public void AddToValue(float amount) => Value += amount;

    /// <summary>
    /// Subtracts an amount to the resources value.
    /// </summary>
    /// <param name="amount">
    /// The amount to subtract to the value.
    /// </param>
    public void SubFromValue(float amount) => Value -= amount;

    // Sets the value of the resource to 0 on start.
    // Can easily be changed later on.
    private void Start() => Value = 0;
}