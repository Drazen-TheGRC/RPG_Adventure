using UnityEngine;

// Player is a MonoBehaviour attached to the player GameObject.
// It owns and controls the player's State Machine.
public class Player : MonoBehaviour
{
    // The StateMachine that controls which state the player is currently in.
    // Other classes can READ this, but only Player can assign it.
    public StateMachine stateMachine { get; private set; }

    // Reference to the Idle state.
    // Stored here so we can reuse it or switch back to it later.
    private EntityState idleState;

    // Awake is called when the object is first created (before Start).
    // Use Awake for setup and references.
    private void Awake()
    {
        // Create the state machine instance
        stateMachine = new StateMachine();

        // Create the idle state and give it a reference to the state machine
        // so it can request state changes when needed.
        idleState = new EntityState(stateMachine, "Idle State");
    }

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // This is a good place to set the initial state.
    void Start()
    {
        // Initialize the state machine with the starting state
        stateMachine.Initialize(idleState);
    }

    // Update is called once per frame.
    // We forward Update to the currently active state.
    void Update()
    {
        // Run the Update logic of the current state
        stateMachine.currentState.Update();
    }
}
